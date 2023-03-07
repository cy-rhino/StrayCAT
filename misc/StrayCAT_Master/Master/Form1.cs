using EasyTest;
using SOEM;
using System;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace Master
{
    public partial class Form1 : Form
    {
        Thread threadEtherCAT;

        public bool isConnected = false;

        public object m_lockobj = new object();

        /* user application variable */
        public byte Leds;
        public byte vol_h;
        public byte vol_l;
        public byte dip_sw;
        public int slv_count;

        public Form1()
        {
            InitializeComponent();

            ButtonDisconnect.Enabled = false;

            UpdateNicList();
        }

        void ThreadFunc_EtherCAT()
        {
            while (true)
            {
                lock (m_lockobj)
                {
                    EtherCAT.setOutputPDO(1, 0, (byte)Leds);
                }

                EtherCAT.transferPDO();

                int[] vol = new int[2];

                vol_l = EtherCAT.getInputPDO(1, 0);
                vol_h = EtherCAT.getInputPDO(1, 1);
                vol[0] = (vol_h << 8) | vol_l;

                vol_l = EtherCAT.getInputPDO(1, 2);
                vol_h = EtherCAT.getInputPDO(1, 3);
                vol[1] = (vol_h << 8) | vol_l;

                dip_sw = EtherCAT.getInputPDO(1, 6);

                this.BeginInvoke((Action)(() =>
                {
                    TextBoxVol0.Text = vol[0].ToString();
                    TextBoxVol1.Text = vol[1].ToString();

                    if ((dip_sw & 8) == 8) {
                        CheckBoxS0.Checked = true;
                    } else {
                        CheckBoxS0.Checked = false;
                    }
                    if ((dip_sw & 4) == 4) {
                        CheckBoxS1.Checked = true;
                    } else {
                        CheckBoxS1.Checked = false;
                    }
                    if ((dip_sw & 2) == 2) {
                        CheckBoxS2.Checked = true;
                    } else {
                        CheckBoxS2.Checked = false;
                    }
                    if ((dip_sw & 1) == 1) {
                        CheckBoxS3.Checked = true;
                    } else {
                        CheckBoxS3.Checked = false;
                    }
                }));

                if (!isConnected)
                {
                    break;
                }

                Thread.Sleep(10);  // 10 mSec
            }

            this.BeginInvoke((Action)(() =>
            {
                EtherCAT.requestState(EtherCAT.ALL_SLAVES, EtherCAT.STATE_INIT);
                EtherCAT.close();

                ButtonConnect.Enabled = true;
                ButtonDisconnect.Enabled = false;
                ButtonUpdate.Enabled = true;
                ComboBoxNicName.Enabled = true;
            }));
        }

        void UpdateNicList()
        {
            ComboBoxNicName.Items.Clear();
            string nicName = Properties.Settings.Default.NicName;
            var interfaces = NetworkInterface.GetAllNetworkInterfaces();
            bool selected = false;

            foreach (var ni in interfaces)
            {
                var nic = new NicInfo(ni.Name, ni.Id);
                ComboBoxNicName.Items.Add(nic);

                if (nic.Name.Equals(nicName))
                {
                    ComboBoxNicName.SelectedItem = nic;
                    selected = true;
                }
            }
            if (!selected && (interfaces.Length > 0))
            {
                ComboBoxNicName.SelectedIndex = 0;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isConnected)
            {
                isConnected = false;
            }
            threadEtherCAT?.Join();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            UpdateNicList();
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                int result = EtherCAT.open(@"\Device\NPF_" + ((NicInfo)ComboBoxNicName.SelectedItem).ID);
                if (result == EtherCAT.FAILED)
                {
                    MessageBox.Show("The network interface cannot be opened.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                result = EtherCAT.config();
                if (result == EtherCAT.NO_SLAVES_FOUND)
                {
                    MessageBox.Show("No slave device found.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (result == EtherCAT.NOT_ALL_OP_STATE)
                {
                    MessageBox.Show("Some devices cannot be shifted to the Operational state.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Properties.Settings.Default.NicName = ComboBoxNicName.Text;
                Properties.Settings.Default.Save();

                isConnected = true;

                ButtonConnect.Enabled = false;
                ButtonDisconnect.Enabled = true;
                ButtonUpdate.Enabled = false;
                ComboBoxNicName.Enabled = false;

                threadEtherCAT = new Thread(new ThreadStart(ThreadFunc_EtherCAT));
                threadEtherCAT.Start();

                slv_count = EtherCAT.getSlaveCount();
                label2.Text = slv_count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            label2.Text = "0";
            isConnected = false;
        }

        private void CheckBoxD3_CheckedChanged(object sender, EventArgs e)
        {
            lock (m_lockobj)
            {
                if (CheckBoxD3.Checked == true) {
                    Leds = (byte)(Leds | 0b0001);
                } else {
                    Leds = (byte)(Leds & 0b1110);
                }
            }
        }

        private void CheckBoxD2_CheckedChanged(object sender, EventArgs e)
        {
            lock (m_lockobj)
            {
                if (CheckBoxD2.Checked == true) {
                    Leds = (byte)(Leds | 0b0010);
                } else {
                    Leds = (byte)(Leds & 0b1101);
                }
            }
        }

        private void CheckBoxD1_CheckedChanged(object sender, EventArgs e)
        {
            lock (m_lockobj)
            {
                if (CheckBoxD1.Checked == true) {
                    Leds = (byte)(Leds | 0b0100);
                } else {
                    Leds = (byte)(Leds & 0b1011);
                }
            }
        }

        private void CheckBoxD0_CheckedChanged(object sender, EventArgs e)
        {
            lock (m_lockobj)
            {
                if (CheckBoxD0.Checked == true) {
                    Leds = (byte)(Leds | 0b1000);
                } else {
                    Leds = (byte)(Leds & 0b0111);
                }
            }
        }
    }
}
