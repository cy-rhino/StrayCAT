namespace Master
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
            this.ComboBoxNicName = new System.Windows.Forms.ComboBox();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ButtonDisconnect = new System.Windows.Forms.Button();
            this.TextBoxVol0 = new System.Windows.Forms.TextBox();
            this.TextBoxVol1 = new System.Windows.Forms.TextBox();
            this.CheckBoxD3 = new System.Windows.Forms.CheckBox();
            this.CheckBoxD2 = new System.Windows.Forms.CheckBox();
            this.CheckBoxD1 = new System.Windows.Forms.CheckBox();
            this.CheckBoxD0 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckBoxS3 = new System.Windows.Forms.CheckBox();
            this.CheckBoxS2 = new System.Windows.Forms.CheckBox();
            this.CheckBoxS1 = new System.Windows.Forms.CheckBox();
            this.CheckBoxS0 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ComboBoxNicName
            // 
            this.ComboBoxNicName.FormattingEnabled = true;
            this.ComboBoxNicName.Location = new System.Drawing.Point(30, 14);
            this.ComboBoxNicName.Name = "ComboBoxNicName";
            this.ComboBoxNicName.Size = new System.Drawing.Size(121, 20);
            this.ComboBoxNicName.TabIndex = 3;
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(210, 12);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(75, 23);
            this.ButtonUpdate.TabIndex = 0;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(210, 41);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(75, 23);
            this.ButtonConnect.TabIndex = 1;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ButtonDisconnect
            // 
            this.ButtonDisconnect.Location = new System.Drawing.Point(210, 70);
            this.ButtonDisconnect.Name = "ButtonDisconnect";
            this.ButtonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.ButtonDisconnect.TabIndex = 2;
            this.ButtonDisconnect.Text = "Disconnect";
            this.ButtonDisconnect.UseVisualStyleBackColor = true;
            this.ButtonDisconnect.Click += new System.EventHandler(this.ButtonDisconnect_Click);
            // 
            // TextBoxVol0
            // 
            this.TextBoxVol0.Location = new System.Drawing.Point(30, 43);
            this.TextBoxVol0.Name = "TextBoxVol0";
            this.TextBoxVol0.Size = new System.Drawing.Size(100, 19);
            this.TextBoxVol0.TabIndex = 4;
            // 
            // TextBoxVol1
            // 
            this.TextBoxVol1.Location = new System.Drawing.Point(30, 72);
            this.TextBoxVol1.Name = "TextBoxVol1";
            this.TextBoxVol1.Size = new System.Drawing.Size(100, 19);
            this.TextBoxVol1.TabIndex = 5;
            // 
            // CheckBoxD3
            // 
            this.CheckBoxD3.AutoSize = true;
            this.CheckBoxD3.Location = new System.Drawing.Point(30, 140);
            this.CheckBoxD3.Name = "CheckBoxD3";
            this.CheckBoxD3.Size = new System.Drawing.Size(38, 16);
            this.CheckBoxD3.TabIndex = 10;
            this.CheckBoxD3.Text = "D3";
            this.CheckBoxD3.UseVisualStyleBackColor = true;
            this.CheckBoxD3.CheckedChanged += new System.EventHandler(this.CheckBoxD3_CheckedChanged);
            // 
            // CheckBoxD2
            // 
            this.CheckBoxD2.AutoSize = true;
            this.CheckBoxD2.Location = new System.Drawing.Point(75, 140);
            this.CheckBoxD2.Name = "CheckBoxD2";
            this.CheckBoxD2.Size = new System.Drawing.Size(38, 16);
            this.CheckBoxD2.TabIndex = 11;
            this.CheckBoxD2.Text = "D2";
            this.CheckBoxD2.UseVisualStyleBackColor = true;
            this.CheckBoxD2.CheckedChanged += new System.EventHandler(this.CheckBoxD2_CheckedChanged);
            // 
            // CheckBoxD1
            // 
            this.CheckBoxD1.AutoSize = true;
            this.CheckBoxD1.Location = new System.Drawing.Point(120, 140);
            this.CheckBoxD1.Name = "CheckBoxD1";
            this.CheckBoxD1.Size = new System.Drawing.Size(38, 16);
            this.CheckBoxD1.TabIndex = 12;
            this.CheckBoxD1.Text = "D1";
            this.CheckBoxD1.UseVisualStyleBackColor = true;
            this.CheckBoxD1.CheckedChanged += new System.EventHandler(this.CheckBoxD1_CheckedChanged);
            // 
            // CheckBoxD0
            // 
            this.CheckBoxD0.AutoSize = true;
            this.CheckBoxD0.Location = new System.Drawing.Point(165, 140);
            this.CheckBoxD0.Name = "CheckBoxD0";
            this.CheckBoxD0.Size = new System.Drawing.Size(38, 16);
            this.CheckBoxD0.TabIndex = 13;
            this.CheckBoxD0.Text = "D0";
            this.CheckBoxD0.UseVisualStyleBackColor = true;
            this.CheckBoxD0.CheckedChanged += new System.EventHandler(this.CheckBoxD0_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "Count of Slave Devices : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "0";
            // 
            // CheckBoxS3
            // 
            this.CheckBoxS3.AutoCheck = false;
            this.CheckBoxS3.AutoSize = true;
            this.CheckBoxS3.Location = new System.Drawing.Point(30, 110);
            this.CheckBoxS3.Name = "CheckBoxS3";
            this.CheckBoxS3.Size = new System.Drawing.Size(37, 16);
            this.CheckBoxS3.TabIndex = 6;
            this.CheckBoxS3.Text = "S3";
            this.CheckBoxS3.UseVisualStyleBackColor = true;
            // 
            // CheckBoxS2
            // 
            this.CheckBoxS2.AutoCheck = false;
            this.CheckBoxS2.AutoSize = true;
            this.CheckBoxS2.Location = new System.Drawing.Point(75, 110);
            this.CheckBoxS2.Name = "CheckBoxS2";
            this.CheckBoxS2.Size = new System.Drawing.Size(37, 16);
            this.CheckBoxS2.TabIndex = 7;
            this.CheckBoxS2.Text = "S2";
            this.CheckBoxS2.UseVisualStyleBackColor = true;
            // 
            // CheckBoxS1
            // 
            this.CheckBoxS1.AutoCheck = false;
            this.CheckBoxS1.AutoSize = true;
            this.CheckBoxS1.Location = new System.Drawing.Point(120, 110);
            this.CheckBoxS1.Name = "CheckBoxS1";
            this.CheckBoxS1.Size = new System.Drawing.Size(37, 16);
            this.CheckBoxS1.TabIndex = 8;
            this.CheckBoxS1.Text = "S1";
            this.CheckBoxS1.UseVisualStyleBackColor = true;
            // 
            // CheckBoxS0
            // 
            this.CheckBoxS0.AutoCheck = false;
            this.CheckBoxS0.AutoSize = true;
            this.CheckBoxS0.Location = new System.Drawing.Point(165, 110);
            this.CheckBoxS0.Name = "CheckBoxS0";
            this.CheckBoxS0.Size = new System.Drawing.Size(37, 16);
            this.CheckBoxS0.TabIndex = 9;
            this.CheckBoxS0.Text = "S0";
            this.CheckBoxS0.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 201);
            this.Controls.Add(this.CheckBoxS0);
            this.Controls.Add(this.CheckBoxS1);
            this.Controls.Add(this.CheckBoxS2);
            this.Controls.Add(this.CheckBoxS3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckBoxD0);
            this.Controls.Add(this.CheckBoxD1);
            this.Controls.Add(this.CheckBoxD2);
            this.Controls.Add(this.CheckBoxD3);
            this.Controls.Add(this.TextBoxVol1);
            this.Controls.Add(this.TextBoxVol0);
            this.Controls.Add(this.ButtonDisconnect);
            this.Controls.Add(this.ButtonConnect);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ComboBoxNicName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "StrayCAT Master";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox ComboBoxNicName;
		private System.Windows.Forms.Button ButtonUpdate;
		private System.Windows.Forms.Button ButtonConnect;
		private System.Windows.Forms.Button ButtonDisconnect;
		private System.Windows.Forms.TextBox TextBoxVol0;
		private System.Windows.Forms.TextBox TextBoxVol1;
		private System.Windows.Forms.CheckBox CheckBoxD3;
		private System.Windows.Forms.CheckBox CheckBoxD2;
		private System.Windows.Forms.CheckBox CheckBoxD1;
		private System.Windows.Forms.CheckBox CheckBoxD0;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox CheckBoxS3;
		private System.Windows.Forms.CheckBox CheckBoxS2;
		private System.Windows.Forms.CheckBox CheckBoxS1;
		private System.Windows.Forms.CheckBox CheckBoxS0;
	}
}

