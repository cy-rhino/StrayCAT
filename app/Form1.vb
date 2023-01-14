'
' StrayCAT ESI Tool
'
' Copyright (c) 2022 Keizo Yoshikawa
'
' This software is released under the MIT License.
' http://opensource.org/licenses/mit-license.php
'
'

Public Class Form1
    Private typeTable As New DataTable("typeTable")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        typeTable.Columns.Add("Display", GetType(String))
        typeTable.Columns.Add("Value", GetType(Integer))
        typeTable.Rows.Add("uint8_t", 0)
        typeTable.Rows.Add("uint16_t", 1)
        typeTable.Rows.Add("uint32_t", 2)
        typeTable.Rows.Add("uint64_t", 3)
        typeTable.Rows.Add("int8_t", 4)
        typeTable.Rows.Add("int16_t", 5)
        typeTable.Rows.Add("int32_t", 6)
        typeTable.Rows.Add("int64_t", 7)
        typeTable.Rows.Add("float", 8)
        typeTable.Rows.Add("double", 9)

        DataGridView_In.ColumnCount = 1
        DataGridView_In.RowCount = 16
        DataGridView_Out.ColumnCount = 1
        DataGridView_Out.RowCount = 16

        DataGridView_In.Columns(0).Name = "Type"
        Using column_In As New DataGridViewComboBoxColumn()
            column_In.DataPropertyName = DataGridView_In.Columns("Type").DataPropertyName
            column_In.DataSource = typeTable
            column_In.ValueMember = "Value"
            column_In.DisplayMember = "Display"
            DataGridView_In.Columns.Insert(0, column_In)
        End Using

        DataGridView_In.Columns(0).HeaderText = "Type"
        DataGridView_In.Columns(1).Name = "Name"
        DataGridView_In.Columns(1).HeaderText = "Name"

        DataGridView_Out.Columns(0).Name = "Type"
        Using column_Out As New DataGridViewComboBoxColumn()
            column_Out.DataPropertyName = DataGridView_Out.Columns("Type").DataPropertyName
            column_Out.DataSource = typeTable
            column_Out.ValueMember = "Value"
            column_Out.DisplayMember = "Display"
            DataGridView_Out.Columns.Insert(0, column_Out)
        End Using

        DataGridView_Out.Columns(0).HeaderText = "Type"
        DataGridView_Out.Columns(1).Name = "Name"
        DataGridView_Out.Columns(1).HeaderText = "Name"

        Dim srIniFile As New System.IO.StreamReader("StrayCAT_ESI_Tool.ini")
        Dim rdata As String
        Dim i As Integer = 0
        While srIniFile.Peek() > -1
            TextBox_Vendor_ID.Text = srIniFile.ReadLine()
            TextBox_Vendor_Name.Text = srIniFile.ReadLine()
            TextBox_Product_Code.Text = srIniFile.ReadLine()
            TextBox_Revision.Text = srIniFile.ReadLine()
            TextBox_Locale_ID.Text = srIniFile.ReadLine()
            TextBox_Group_Name.Text = srIniFile.ReadLine()
            TextBox_Device_Name.Text = srIniFile.ReadLine()
            TextBox_Eeprom.Text = srIniFile.ReadLine()
            rdata = srIniFile.ReadLine()
            If rdata = "<!-- PDO In  -->" Then
                rdata = srIniFile.ReadLine()
                Do Until rdata = "<!-- PDO Out -->"
                    DataGridView_In.Rows(i).Cells(0).Value = Integer.Parse(rdata)
                    rdata = srIniFile.ReadLine()
                    DataGridView_In.Rows(i).Cells(1).Value = rdata
                    rdata = srIniFile.ReadLine()
                    i += 1
                Loop
                i = 0
                rdata = srIniFile.ReadLine()
                Do Until rdata = "<!-- END -->"
                    DataGridView_Out.Rows(i).Cells(0).Value = Integer.Parse(rdata)
                    rdata = srIniFile.ReadLine()
                    DataGridView_Out.Rows(i).Cells(1).Value = rdata
                    rdata = srIniFile.ReadLine()
                    i += 1
                Loop
                i = 0
            End If
        End While
        srIniFile.Close()

        Dim srVImgFile As New System.IO.StreamReader("StrayCAT_ESI_Vendor_Image.ini")
        TextBox_Vendor_Image.Text = srVImgFile.ReadLine()
        srVImgFile.Close()

        Dim srGImgFile As New System.IO.StreamReader("StrayCAT_ESI_Group_Image.ini")
        TextBox_Group_Image.Text = srGImgFile.ReadLine()
        srGImgFile.Close()

        ActiveControl = Nothing
    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click

        Dim CUST_BYTE_NUM_OUT As Integer = 0
        Dim CUST_BYTE_NUM_IN As Integer = 0

        Dim swIniFile As New System.IO.StreamWriter("StrayCAT_ESI_Tool.ini", False, System.Text.Encoding.GetEncoding("UTF-8"))
        swIniFile.WriteLine(TextBox_Vendor_ID.Text)
        swIniFile.WriteLine(TextBox_Vendor_Name.Text)
        swIniFile.WriteLine(TextBox_Product_Code.Text)
        swIniFile.WriteLine(TextBox_Revision.Text)
        swIniFile.WriteLine(TextBox_Locale_ID.Text)
        swIniFile.WriteLine(TextBox_Group_Name.Text)
        swIniFile.WriteLine(TextBox_Device_Name.Text)
        swIniFile.WriteLine(TextBox_Eeprom.Text)

        swIniFile.WriteLine("<!-- PDO In  -->")
        For i As Integer = 0 To DataGridView_In.Rows.Count - 2
            If DataGridView_In.Rows(i).Cells(0).Value Is Nothing Or
               DataGridView_In.Rows(i).Cells(1).Value Is Nothing Then
            Else
                swIniFile.WriteLine(DataGridView_In.Rows(i).Cells(0).Value)
                swIniFile.WriteLine(DataGridView_In.Rows(i).Cells(1).Value)
            End If
        Next

        swIniFile.WriteLine("<!-- PDO Out -->")
        For i As Integer = 0 To DataGridView_Out.Rows.Count - 2
            If DataGridView_Out.Rows(i).Cells(0).Value Is Nothing Or
               DataGridView_Out.Rows(i).Cells(1).Value Is Nothing Then
            Else
                swIniFile.WriteLine(DataGridView_Out.Rows(i).Cells(0).Value)
                swIniFile.WriteLine(DataGridView_Out.Rows(i).Cells(1).Value)
            End If
        Next
        swIniFile.WriteLine("<!-- END -->")
        swIniFile.Close()

        Dim swXmlFile As New System.IO.StreamWriter("StrayCAT.xml", False, System.Text.Encoding.GetEncoding("UTF-8"))
        swXmlFile.WriteLine("<?xml version=""1.0"" encoding=""utf-8""?>")
        swXmlFile.WriteLine("<EtherCATInfo xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xsi:noNamespaceSchemaLocation=""EtherCATInfo.xsd"" Version=""1.6"">")
        swXmlFile.WriteLine("   <Vendor>")
        swXmlFile.WriteLine("       <Id>#x" + TextBox_Vendor_ID.Text + "</Id>")
        swXmlFile.WriteLine("       <Name>" + TextBox_Vendor_Name.Text + "</Name>")
        swXmlFile.WriteLine("       <ImageData16x14>" + TextBox_Vendor_Image.Text + "</ImageData16x14>")
        swXmlFile.WriteLine("   </Vendor>")
        swXmlFile.WriteLine("   <Descriptions>")
        swXmlFile.WriteLine("       <Groups>")
        swXmlFile.WriteLine("           <Group>")
        swXmlFile.WriteLine("               <Type>StrayCAT</Type>")
        swXmlFile.WriteLine("               <Name>" + TextBox_Group_Name.Text + "</Name>")
        swXmlFile.WriteLine("               <ImageData16x14>" + TextBox_Group_Image.Text + "</ImageData16x14>")
        swXmlFile.WriteLine("           </Group>")
        swXmlFile.WriteLine("       </Groups>")
        swXmlFile.WriteLine("       <Devices>")
        swXmlFile.WriteLine("           <!-- Custom Device -->")
        swXmlFile.WriteLine("           <Device Physics=""YY"">")
        swXmlFile.WriteLine("               <Type ProductCode=""#x" + TextBox_Product_Code.Text + """ RevisionNo=""#x" + TextBox_Revision.Text + """ CheckRevisionNo=""EQ_OR_G"">" + TextBox_Device_Name.Text + "</Type>")
        swXmlFile.WriteLine("               <Name LcId=""" + TextBox_Locale_ID.Text + """><![CDATA[" + TextBox_Device_Name.Text + "]]></Name>")
        swXmlFile.WriteLine("               <Info>")
        swXmlFile.WriteLine("                   <EtherCATController>")
        swXmlFile.WriteLine("                       <DpramSize>4096</DpramSize>")
        swXmlFile.WriteLine("                       <SmCount>4</SmCount>")
        swXmlFile.WriteLine("                       <FmmuCount>3</FmmuCount>")
        swXmlFile.WriteLine("                   </EtherCATController>")
        swXmlFile.WriteLine("                   <Port>")
        swXmlFile.WriteLine("                       <Type>MII</Type>")
        swXmlFile.WriteLine("                       <PhysicalPhyAddr>0</PhysicalPhyAddr>")
        swXmlFile.WriteLine("                   </Port>")
        swXmlFile.WriteLine("                   <Port>")
        swXmlFile.WriteLine("                       <Type>MII</Type>")
        swXmlFile.WriteLine("                       <PhysicalPhyAddr>1</PhysicalPhyAddr>")
        swXmlFile.WriteLine("                   </Port>")
        swXmlFile.WriteLine("                   <IdentificationAdo>#x0012</IdentificationAdo>")
        swXmlFile.WriteLine("               </Info>")
        swXmlFile.WriteLine("               <GroupType>StrayCAT</GroupType>")
        swXmlFile.WriteLine("               <Fmmu>Outputs</Fmmu>")
        swXmlFile.WriteLine("               <Fmmu>Inputs</Fmmu>")
        swXmlFile.WriteLine("               <!-- Output base physical address -->")
        swXmlFile.WriteLine("               <Sm StartAddress=""#x1000"" ControlByte=""#x64"" Enable=""1"">Outputs</Sm>")
        swXmlFile.WriteLine("               <!-- Input base physical address -->")
        swXmlFile.WriteLine("               <Sm StartAddress=""#x1200"" ControlByte=""#x20"" Enable=""1"">Inputs</Sm>")
        swXmlFile.WriteLine("               <!-- Output PDO -->")
        swXmlFile.WriteLine("               <RxPdo Fixed=""1"" Mandatory=""1"" Sm=""0"">")
        swXmlFile.WriteLine("                   <Index>#x1600</Index>")
        swXmlFile.WriteLine("                   <Name>Outputs</Name>")

        For i As Integer = 0 To DataGridView_Out.Rows.Count - 2
            If DataGridView_Out.Rows(i).Cells(0).Value Is Nothing Or
               DataGridView_Out.Rows(i).Cells(1).Value Is Nothing Then
            Else
                swXmlFile.WriteLine("                   <Entry>")
                swXmlFile.WriteLine("                       <Index>#x7000</Index>")
                swXmlFile.WriteLine("                       <SubIndex>" + (i + 1).ToString() + "</SubIndex>")
                If DataGridView_Out.Rows(i).Cells(0).Value = 0 Or
                   DataGridView_Out.Rows(i).Cells(0).Value = 4 Then
                    swXmlFile.WriteLine("                       <BitLen>8</BitLen>")
                    CUST_BYTE_NUM_OUT += 1
                    If DataGridView_Out.Rows(i).Cells(0).Value = 0 Then
                        swXmlFile.WriteLine("                       <Name>" + DataGridView_Out.Rows(i).Cells(1).Value + "</Name>")
                        swXmlFile.WriteLine("                       <DataType>USINT</DataType>")
                    ElseIf DataGridView_Out.Rows(i).Cells(0).Value = 4 Then
                        swXmlFile.WriteLine("                       <Name>" + DataGridView_Out.Rows(i).Cells(1).Value + "</Name>")
                        swXmlFile.WriteLine("                       <DataType>SINT</DataType>")
                    End If
                ElseIf DataGridView_Out.Rows(i).Cells(0).Value = 1 Or
                       DataGridView_Out.Rows(i).Cells(0).Value = 5 Then
                    swXmlFile.WriteLine("                       <BitLen>16</BitLen>")
                    CUST_BYTE_NUM_OUT += 2
                    If DataGridView_Out.Rows(i).Cells(0).Value = 1 Then
                        swXmlFile.WriteLine("                       <Name>" + DataGridView_Out.Rows(i).Cells(1).Value + "</Name>")
                        swXmlFile.WriteLine("                       <DataType>UINT</DataType>")
                    ElseIf DataGridView_Out.Rows(i).Cells(0).Value = 5 Then
                        swXmlFile.WriteLine("                       <Name>" + DataGridView_Out.Rows(i).Cells(1).Value + "</Name>")
                        swXmlFile.WriteLine("                       <DataType>INT</DataType>")
                    End If
                ElseIf DataGridView_Out.Rows(i).Cells(0).Value = 2 Or
                       DataGridView_Out.Rows(i).Cells(0).Value = 6 Or
                       DataGridView_Out.Rows(i).Cells(0).Value = 8 Then
                    swXmlFile.WriteLine("                       <BitLen>32</BitLen>")
                    CUST_BYTE_NUM_OUT += 4
                    If DataGridView_Out.Rows(i).Cells(0).Value = 2 Then
                        swXmlFile.WriteLine("                       <Name>" + DataGridView_Out.Rows(i).Cells(1).Value + "</Name>")
                        swXmlFile.WriteLine("                       <DataType>UDINT</DataType>")
                    ElseIf DataGridView_Out.Rows(i).Cells(0).Value = 6 Then
                        swXmlFile.WriteLine("                       <Name>" + DataGridView_Out.Rows(i).Cells(1).Value + "</Name>")
                        swXmlFile.WriteLine("                       <DataType>DINT</DataType>")
                    ElseIf DataGridView_Out.Rows(i).Cells(0).Value = 8 Then
                        swXmlFile.WriteLine("                       <Name>" + DataGridView_Out.Rows(i).Cells(1).Value + "</Name>")
                        swXmlFile.WriteLine("                       <DataType>REAL</DataType>")
                    End If
                ElseIf DataGridView_Out.Rows(i).Cells(0).Value = 3 Or
                       DataGridView_Out.Rows(i).Cells(0).Value = 7 Or
                       DataGridView_Out.Rows(i).Cells(0).Value = 9 Then
                    swXmlFile.WriteLine("                       <BitLen>64</BitLen>")
                    CUST_BYTE_NUM_OUT += 8
                    If DataGridView_Out.Rows(i).Cells(0).Value = 3 Then
                        swXmlFile.WriteLine("                       <Name>" + DataGridView_Out.Rows(i).Cells(1).Value + "</Name>")
                        swXmlFile.WriteLine("                       <DataType>ULINT</DataType>")
                    ElseIf DataGridView_Out.Rows(i).Cells(0).Value = 7 Then
                        swXmlFile.WriteLine("                       <Name>" + DataGridView_Out.Rows(i).Cells(1).Value + "</Name>")
                        swXmlFile.WriteLine("                       <DataType>LINT</DataType>")
                    ElseIf DataGridView_Out.Rows(i).Cells(0).Value = 9 Then
                        swXmlFile.WriteLine("                       <Name>" + DataGridView_Out.Rows(i).Cells(1).Value + "</Name>")
                        swXmlFile.WriteLine("                       <DataType>LREAL</DataType>")
                    End If
                End If
                swXmlFile.WriteLine("                   </Entry>")
            End If
        Next
        swXmlFile.WriteLine("               </RxPdo>")
        swXmlFile.WriteLine("               <!-- Input PDO -->")
        swXmlFile.WriteLine("               <TxPdo Fixed=""1"" Mandatory=""1"" Sm=""1"">")
        swXmlFile.WriteLine("                   <Index>#x1A00</Index>")
        swXmlFile.WriteLine("                   <Name>Inputs</Name>")

        For i As Integer = 0 To DataGridView_In.Rows.Count - 2
            If DataGridView_In.Rows(i).Cells(0).Value Is Nothing Or
               DataGridView_In.Rows(i).Cells(1).Value Is Nothing Then
            Else
                swXmlFile.WriteLine("                   <Entry>")
                swXmlFile.WriteLine("                       <Index>#x6000</Index>")
                swXmlFile.WriteLine("                       <SubIndex>" + (i + 1).ToString() + "</SubIndex>")
                If DataGridView_In.Rows(i).Cells(0).Value = 0 Or
                   DataGridView_In.Rows(i).Cells(0).Value = 4 Then
                    swXmlFile.WriteLine("                       <BitLen>8</BitLen>")
                    CUST_BYTE_NUM_IN += 1
                    If DataGridView_In.Rows(i).Cells(0).Value = 0 Then
                        swXmlFile.WriteLine("                       <Name>" + DataGridView_In.Rows(i).Cells(1).Value + "</Name>")
                        swXmlFile.WriteLine("                       <DataType>USINT</DataType>")
                    ElseIf DataGridView_In.Rows(i).Cells(0).Value = 4 Then
                        swXmlFile.WriteLine("                       <Name>" + DataGridView_In.Rows(i).Cells(1).Value + "</Name>")
                        swXmlFile.WriteLine("                       <DataType>SINT</DataType>")
                    End If
                ElseIf DataGridView_In.Rows(i).Cells(0).Value = 1 Or
                       DataGridView_In.Rows(i).Cells(0).Value = 5 Then
                    swXmlFile.WriteLine("                       <BitLen>16</BitLen>")
                    CUST_BYTE_NUM_IN += 2
                    If DataGridView_In.Rows(i).Cells(0).Value = 1 Then
                        swXmlFile.WriteLine("                       <Name>" + DataGridView_In.Rows(i).Cells(1).Value + "</Name>")
                        swXmlFile.WriteLine("                       <DataType>UINT</DataType>")
                    ElseIf DataGridView_In.Rows(i).Cells(0).Value = 5 Then
                        swXmlFile.WriteLine("                       <Name>" + DataGridView_In.Rows(i).Cells(1).Value + "</Name>")
                        swXmlFile.WriteLine("                       <DataType>INT</DataType>")
                    End If
                ElseIf DataGridView_In.Rows(i).Cells(0).Value = 2 Or
                       DataGridView_In.Rows(i).Cells(0).Value = 6 Or
                       DataGridView_In.Rows(i).Cells(0).Value = 8 Then
                    swXmlFile.WriteLine("                       <BitLen>32</BitLen>")
                    CUST_BYTE_NUM_IN += 4
                    If DataGridView_In.Rows(i).Cells(0).Value = 2 Then
                        swXmlFile.WriteLine("                       <Name>" + DataGridView_In.Rows(i).Cells(1).Value + "</Name>")
                        swXmlFile.WriteLine("                       <DataType>UDINT</DataType>")
                    ElseIf DataGridView_In.Rows(i).Cells(0).Value = 6 Then
                        swXmlFile.WriteLine("                       <Name>" + DataGridView_In.Rows(i).Cells(1).Value + "</Name>")
                        swXmlFile.WriteLine("                       <DataType>DINT</DataType>")
                    ElseIf DataGridView_In.Rows(i).Cells(0).Value = 8 Then
                        swXmlFile.WriteLine("                       <Name>" + DataGridView_In.Rows(i).Cells(1).Value + "</Name>")
                        swXmlFile.WriteLine("                       <DataType>REAL</DataType>")
                    End If
                ElseIf DataGridView_In.Rows(i).Cells(0).Value = 3 Or
                       DataGridView_In.Rows(i).Cells(0).Value = 7 Or
                       DataGridView_In.Rows(i).Cells(0).Value = 9 Then
                    swXmlFile.WriteLine("                       <BitLen>64</BitLen>")
                    CUST_BYTE_NUM_IN += 8
                    If DataGridView_In.Rows(i).Cells(0).Value = 3 Then
                        swXmlFile.WriteLine("                       <Name>" + DataGridView_In.Rows(i).Cells(1).Value + "</Name>")
                        swXmlFile.WriteLine("                       <DataType>ULINT</DataType>")
                    ElseIf DataGridView_In.Rows(i).Cells(0).Value = 7 Then
                        swXmlFile.WriteLine("                       <Name>" + DataGridView_In.Rows(i).Cells(1).Value + "</Name>")
                        swXmlFile.WriteLine("                       <DataType>LINT</DataType>")
                    ElseIf DataGridView_In.Rows(i).Cells(0).Value = 9 Then
                        swXmlFile.WriteLine("                       <Name>" + DataGridView_In.Rows(i).Cells(1).Value + "</Name>")
                        swXmlFile.WriteLine("                       <DataType>LREAL</DataType>")
                    End If
                End If
                swXmlFile.WriteLine("                   </Entry>")
            End If
        Next
        swXmlFile.WriteLine("               </TxPdo>")
        swXmlFile.WriteLine("               <!-- Synchronization -->")
        swXmlFile.WriteLine("               <DC>")
        swXmlFile.WriteLine("                   <Opmode>")
        swXmlFile.WriteLine("                       <Name>Synchron</Name>")
        swXmlFile.WriteLine("                       <Desc>SM-Synchron</Desc>")
        swXmlFile.WriteLine("                       <AssignActivate>#x0</AssignActivate>")
        swXmlFile.WriteLine("                   </Opmode>")
        swXmlFile.WriteLine("                   <Opmode>")
        swXmlFile.WriteLine("                       <Name>DC</Name>")
        swXmlFile.WriteLine("                       <Desc>DC-Synchron</Desc>")
        swXmlFile.WriteLine("                       <AssignActivate>#x300</AssignActivate>")
        swXmlFile.WriteLine("                       <CycleTimeSync0 Factor=""1"">0</CycleTimeSync0>")
        swXmlFile.WriteLine("                       <CycleTimeSync1 Factor=""1"">0</CycleTimeSync1>")
        swXmlFile.WriteLine("                   </Opmode>")
        swXmlFile.WriteLine("               </DC>")
        swXmlFile.WriteLine("               <!-- EEPROM -->")
        swXmlFile.WriteLine("               <Eeprom>")
        swXmlFile.WriteLine("                   <ByteSize>2048</ByteSize>")
        swXmlFile.WriteLine("                   <ConfigData>" + TextBox_Eeprom.Text + "</ConfigData>")
        swXmlFile.WriteLine("               </Eeprom>")
        swXmlFile.WriteLine("           </Device>")
        swXmlFile.WriteLine("       </Devices>")
        swXmlFile.WriteLine("   </Descriptions>")
        swXmlFile.Write("</EtherCATInfo>")
        swXmlFile.Close()

        Dim swVImgFile As New System.IO.StreamWriter("StrayCAT_ESI_Vendor_Image.ini", False, System.Text.Encoding.GetEncoding("UTF-8"))
        swVImgFile.WriteLine(TextBox_Vendor_Image.Text)
        swVImgFile.Close()

        Dim swGImgFile As New System.IO.StreamWriter("StrayCAT_ESI_Group_Image.ini", False, System.Text.Encoding.GetEncoding("UTF-8"))
        swGImgFile.WriteLine(TextBox_Group_Image.Text)
        swGImgFile.Close()

        Dim swHeaderFile As New System.IO.StreamWriter("StrayCAT_Custom.h", False, System.Text.Encoding.GetEncoding("shift-jis"))
        swHeaderFile.WriteLine("/*")
        swHeaderFile.WriteLine(" *  Header file for EasyCAT library")
        swHeaderFile.WriteLine(" *")
        swHeaderFile.WriteLine(" *  This file has been created by the StrayCAT ESI Tool.")
        swHeaderFile.WriteLine(" */")
        swHeaderFile.WriteLine("")
        swHeaderFile.WriteLine("#ifndef CUSTOM_PDO_NAME_H")
        swHeaderFile.WriteLine("#define CUSTOM_PDO_NAME_H")
        swHeaderFile.WriteLine("")
        swHeaderFile.WriteLine("#define CUST_BYTE_NUM_OUT " + CUST_BYTE_NUM_OUT.ToString)
        swHeaderFile.WriteLine("#define CUST_BYTE_NUM_IN  " + CUST_BYTE_NUM_IN.ToString)
        swHeaderFile.WriteLine("#define TOT_BYTE_NUM_ROUND_OUT " + (Math.Ceiling(CUST_BYTE_NUM_OUT / 4) * 4).ToString)
        swHeaderFile.WriteLine("#define TOT_BYTE_NUM_ROUND_IN  " + (Math.Ceiling(CUST_BYTE_NUM_IN / 4) * 4).ToString)
        swHeaderFile.WriteLine("")
        swHeaderFile.WriteLine("// output buffer")
        swHeaderFile.WriteLine("typedef union")
        swHeaderFile.WriteLine("{")
        swHeaderFile.WriteLine("  uint8_t Byte [TOT_BYTE_NUM_ROUND_OUT];")
        swHeaderFile.WriteLine("  struct")
        swHeaderFile.WriteLine("  {")
        For i As Integer = 0 To DataGridView_Out.Rows.Count - 2
            If DataGridView_Out.Rows(i).Cells(0).Value Is Nothing Or
               DataGridView_Out.Rows(i).Cells(1).Value Is Nothing Then
            Else
                swHeaderFile.WriteLine("    " + typeTable.Rows(DataGridView_Out.Rows(i).Cells(0).Value)(0) + " " + DataGridView_Out.Rows(i).Cells(1).Value + ";")
            End If
        Next
        swHeaderFile.WriteLine("  } Cust;")
        swHeaderFile.WriteLine("} PROCBUFFER_OUT;")
        swHeaderFile.WriteLine("")
        swHeaderFile.WriteLine("// input buffer")
        swHeaderFile.WriteLine("typedef union")
        swHeaderFile.WriteLine("{")
        swHeaderFile.WriteLine("  uint8_t Byte [TOT_BYTE_NUM_ROUND_IN];")
        swHeaderFile.WriteLine("  struct")
        swHeaderFile.WriteLine("  {")
        For i As Integer = 0 To DataGridView_In.Rows.Count - 2
            If DataGridView_In.Rows(i).Cells(0).Value Is Nothing Or
               DataGridView_In.Rows(i).Cells(1).Value Is Nothing Then
            Else
                swHeaderFile.WriteLine("    " + typeTable.Rows(DataGridView_In.Rows(i).Cells(0).Value)(0) + " " + DataGridView_In.Rows(i).Cells(1).Value + ";")
            End If
        Next
        swHeaderFile.WriteLine("  } Cust;")
        swHeaderFile.WriteLine("} PROCBUFFER_IN;")
        swHeaderFile.WriteLine("")
        swHeaderFile.Write("#endif")
        swHeaderFile.Close()

    End Sub

    Private Sub Button_PDO_In_Clear_Click(sender As Object, e As EventArgs) Handles Button_PDO_In_Clear.Click
        For Each row As DataGridViewRow In DataGridView_In.SelectedRows
            row.Cells(0).Value = Nothing
            row.Cells(1).Value = Nothing
        Next
    End Sub

    Private Sub Button_PDO_Out_Clear_Click(sender As Object, e As EventArgs) Handles Button_PDO_Out_Clear.Click
        For Each row As DataGridViewRow In DataGridView_Out.SelectedRows
            row.Cells(0).Value = Nothing
            row.Cells(1).Value = Nothing
        Next
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Close()
    End Sub
End Class
