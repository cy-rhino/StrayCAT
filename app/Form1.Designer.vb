<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.TextBox_Vendor_ID = New System.Windows.Forms.TextBox()
        Me.Label_Vendor_ID = New System.Windows.Forms.Label()
        Me.TextBox_Vendor_Name = New System.Windows.Forms.TextBox()
        Me.Label_Vendor_Name = New System.Windows.Forms.Label()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.TextBox_Product_Code = New System.Windows.Forms.TextBox()
        Me.Label_Product_Code = New System.Windows.Forms.Label()
        Me.Label_0x_1 = New System.Windows.Forms.Label()
        Me.Label_0x_2 = New System.Windows.Forms.Label()
        Me.Label_Revision = New System.Windows.Forms.Label()
        Me.TextBox_Revision = New System.Windows.Forms.TextBox()
        Me.Label_0x_3 = New System.Windows.Forms.Label()
        Me.TextBox_Group_Name = New System.Windows.Forms.TextBox()
        Me.Label_Group_Name = New System.Windows.Forms.Label()
        Me.TextBox_Device_Name = New System.Windows.Forms.TextBox()
        Me.Label_Device_Name = New System.Windows.Forms.Label()
        Me.TextBox_Vendor_Image = New System.Windows.Forms.TextBox()
        Me.Label_Vendor_Image = New System.Windows.Forms.Label()
        Me.Label_Group_Image = New System.Windows.Forms.Label()
        Me.TextBox_Group_Image = New System.Windows.Forms.TextBox()
        Me.TextBox_Locale_ID = New System.Windows.Forms.TextBox()
        Me.Label_Locale_ID = New System.Windows.Forms.Label()
        Me.DataGridView_In = New System.Windows.Forms.DataGridView()
        Me.DataGridView_Out = New System.Windows.Forms.DataGridView()
        Me.GroupBox_PDO_In = New System.Windows.Forms.GroupBox()
        Me.Button_PDO_In_Clear = New System.Windows.Forms.Button()
        Me.GroupBox_PDO_Out = New System.Windows.Forms.GroupBox()
        Me.Button_PDO_Out_Clear = New System.Windows.Forms.Button()
        Me.TextBox_Eeprom = New System.Windows.Forms.TextBox()
        Me.Label_Eeprom = New System.Windows.Forms.Label()
        CType(Me.DataGridView_In, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Out, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_PDO_In.SuspendLayout()
        Me.GroupBox_PDO_Out.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Close
        '
        Me.Button_Close.Location = New System.Drawing.Point(525, 466)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(75, 23)
        Me.Button_Close.TabIndex = 0
        Me.Button_Close.Text = "Close"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'TextBox_Vendor_ID
        '
        Me.TextBox_Vendor_ID.Location = New System.Drawing.Point(117, 30)
        Me.TextBox_Vendor_ID.Name = "TextBox_Vendor_ID"
        Me.TextBox_Vendor_ID.Size = New System.Drawing.Size(103, 19)
        Me.TextBox_Vendor_ID.TabIndex = 3
        '
        'Label_Vendor_ID
        '
        Me.Label_Vendor_ID.AutoSize = True
        Me.Label_Vendor_ID.Location = New System.Drawing.Point(20, 33)
        Me.Label_Vendor_ID.Name = "Label_Vendor_ID"
        Me.Label_Vendor_ID.Size = New System.Drawing.Size(56, 12)
        Me.Label_Vendor_ID.TabIndex = 1
        Me.Label_Vendor_ID.Text = "Vendor ID"
        '
        'TextBox_Vendor_Name
        '
        Me.TextBox_Vendor_Name.Location = New System.Drawing.Point(100, 55)
        Me.TextBox_Vendor_Name.Name = "TextBox_Vendor_Name"
        Me.TextBox_Vendor_Name.Size = New System.Drawing.Size(120, 19)
        Me.TextBox_Vendor_Name.TabIndex = 5
        '
        'Label_Vendor_Name
        '
        Me.Label_Vendor_Name.AutoSize = True
        Me.Label_Vendor_Name.Location = New System.Drawing.Point(20, 58)
        Me.Label_Vendor_Name.Name = "Label_Vendor_Name"
        Me.Label_Vendor_Name.Size = New System.Drawing.Size(74, 12)
        Me.Label_Vendor_Name.TabIndex = 4
        Me.Label_Vendor_Name.Text = "Vendor Name"
        '
        'Button_Save
        '
        Me.Button_Save.Location = New System.Drawing.Point(434, 466)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(75, 23)
        Me.Button_Save.TabIndex = 30
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'TextBox_Product_Code
        '
        Me.TextBox_Product_Code.Location = New System.Drawing.Point(117, 80)
        Me.TextBox_Product_Code.Name = "TextBox_Product_Code"
        Me.TextBox_Product_Code.Size = New System.Drawing.Size(103, 19)
        Me.TextBox_Product_Code.TabIndex = 8
        '
        'Label_Product_Code
        '
        Me.Label_Product_Code.AutoSize = True
        Me.Label_Product_Code.Location = New System.Drawing.Point(20, 83)
        Me.Label_Product_Code.Name = "Label_Product_Code"
        Me.Label_Product_Code.Size = New System.Drawing.Size(74, 12)
        Me.Label_Product_Code.TabIndex = 6
        Me.Label_Product_Code.Text = "Product Code"
        '
        'Label_0x_1
        '
        Me.Label_0x_1.AutoSize = True
        Me.Label_0x_1.Location = New System.Drawing.Point(100, 33)
        Me.Label_0x_1.Name = "Label_0x_1"
        Me.Label_0x_1.Size = New System.Drawing.Size(17, 12)
        Me.Label_0x_1.TabIndex = 2
        Me.Label_0x_1.Text = "0x"
        '
        'Label_0x_2
        '
        Me.Label_0x_2.AutoSize = True
        Me.Label_0x_2.Location = New System.Drawing.Point(100, 83)
        Me.Label_0x_2.Name = "Label_0x_2"
        Me.Label_0x_2.Size = New System.Drawing.Size(17, 12)
        Me.Label_0x_2.TabIndex = 7
        Me.Label_0x_2.Text = "0x"
        '
        'Label_Revision
        '
        Me.Label_Revision.AutoSize = True
        Me.Label_Revision.Location = New System.Drawing.Point(20, 108)
        Me.Label_Revision.Name = "Label_Revision"
        Me.Label_Revision.Size = New System.Drawing.Size(49, 12)
        Me.Label_Revision.TabIndex = 9
        Me.Label_Revision.Text = "Revision"
        '
        'TextBox_Revision
        '
        Me.TextBox_Revision.Location = New System.Drawing.Point(117, 105)
        Me.TextBox_Revision.Name = "TextBox_Revision"
        Me.TextBox_Revision.Size = New System.Drawing.Size(103, 19)
        Me.TextBox_Revision.TabIndex = 11
        '
        'Label_0x_3
        '
        Me.Label_0x_3.AutoSize = True
        Me.Label_0x_3.Location = New System.Drawing.Point(100, 108)
        Me.Label_0x_3.Name = "Label_0x_3"
        Me.Label_0x_3.Size = New System.Drawing.Size(17, 12)
        Me.Label_0x_3.TabIndex = 10
        Me.Label_0x_3.Text = "0x"
        '
        'TextBox_Group_Name
        '
        Me.TextBox_Group_Name.Location = New System.Drawing.Point(100, 155)
        Me.TextBox_Group_Name.Name = "TextBox_Group_Name"
        Me.TextBox_Group_Name.Size = New System.Drawing.Size(120, 19)
        Me.TextBox_Group_Name.TabIndex = 15
        '
        'Label_Group_Name
        '
        Me.Label_Group_Name.AutoSize = True
        Me.Label_Group_Name.Location = New System.Drawing.Point(20, 158)
        Me.Label_Group_Name.Name = "Label_Group_Name"
        Me.Label_Group_Name.Size = New System.Drawing.Size(68, 12)
        Me.Label_Group_Name.TabIndex = 14
        Me.Label_Group_Name.Text = "Group Name"
        '
        'TextBox_Device_Name
        '
        Me.TextBox_Device_Name.Location = New System.Drawing.Point(100, 180)
        Me.TextBox_Device_Name.Name = "TextBox_Device_Name"
        Me.TextBox_Device_Name.Size = New System.Drawing.Size(120, 19)
        Me.TextBox_Device_Name.TabIndex = 17
        '
        'Label_Device_Name
        '
        Me.Label_Device_Name.AutoSize = True
        Me.Label_Device_Name.Location = New System.Drawing.Point(20, 183)
        Me.Label_Device_Name.Name = "Label_Device_Name"
        Me.Label_Device_Name.Size = New System.Drawing.Size(73, 12)
        Me.Label_Device_Name.TabIndex = 16
        Me.Label_Device_Name.Text = "Device Name"
        '
        'TextBox_Vendor_Image
        '
        Me.TextBox_Vendor_Image.Location = New System.Drawing.Point(320, 30)
        Me.TextBox_Vendor_Image.Multiline = True
        Me.TextBox_Vendor_Image.Name = "TextBox_Vendor_Image"
        Me.TextBox_Vendor_Image.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextBox_Vendor_Image.Size = New System.Drawing.Size(280, 64)
        Me.TextBox_Vendor_Image.TabIndex = 19
        Me.TextBox_Vendor_Image.WordWrap = False
        '
        'Label_Vendor_Image
        '
        Me.Label_Vendor_Image.AutoSize = True
        Me.Label_Vendor_Image.Location = New System.Drawing.Point(240, 33)
        Me.Label_Vendor_Image.Name = "Label_Vendor_Image"
        Me.Label_Vendor_Image.Size = New System.Drawing.Size(75, 12)
        Me.Label_Vendor_Image.TabIndex = 18
        Me.Label_Vendor_Image.Text = "Vendor Image"
        '
        'Label_Group_Image
        '
        Me.Label_Group_Image.AutoSize = True
        Me.Label_Group_Image.Location = New System.Drawing.Point(240, 108)
        Me.Label_Group_Image.Name = "Label_Group_Image"
        Me.Label_Group_Image.Size = New System.Drawing.Size(69, 12)
        Me.Label_Group_Image.TabIndex = 20
        Me.Label_Group_Image.Text = "Group Image"
        '
        'TextBox_Group_Image
        '
        Me.TextBox_Group_Image.Location = New System.Drawing.Point(320, 105)
        Me.TextBox_Group_Image.Multiline = True
        Me.TextBox_Group_Image.Name = "TextBox_Group_Image"
        Me.TextBox_Group_Image.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextBox_Group_Image.Size = New System.Drawing.Size(280, 64)
        Me.TextBox_Group_Image.TabIndex = 21
        Me.TextBox_Group_Image.WordWrap = False
        '
        'TextBox_Locale_ID
        '
        Me.TextBox_Locale_ID.Location = New System.Drawing.Point(100, 130)
        Me.TextBox_Locale_ID.Name = "TextBox_Locale_ID"
        Me.TextBox_Locale_ID.Size = New System.Drawing.Size(120, 19)
        Me.TextBox_Locale_ID.TabIndex = 13
        '
        'Label_Locale_ID
        '
        Me.Label_Locale_ID.AutoSize = True
        Me.Label_Locale_ID.Location = New System.Drawing.Point(20, 133)
        Me.Label_Locale_ID.Name = "Label_Locale_ID"
        Me.Label_Locale_ID.Size = New System.Drawing.Size(53, 12)
        Me.Label_Locale_ID.TabIndex = 12
        Me.Label_Locale_ID.Text = "Locale ID"
        '
        'DataGridView_In
        '
        Me.DataGridView_In.AllowUserToAddRows = False
        Me.DataGridView_In.AllowUserToResizeRows = False
        Me.DataGridView_In.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_In.Location = New System.Drawing.Point(8, 20)
        Me.DataGridView_In.Name = "DataGridView_In"
        Me.DataGridView_In.RowTemplate.Height = 21
        Me.DataGridView_In.Size = New System.Drawing.Size(265, 180)
        Me.DataGridView_In.TabIndex = 25
        '
        'DataGridView_Out
        '
        Me.DataGridView_Out.AllowUserToAddRows = False
        Me.DataGridView_Out.AllowUserToResizeRows = False
        Me.DataGridView_Out.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Out.Location = New System.Drawing.Point(8, 20)
        Me.DataGridView_Out.Name = "DataGridView_Out"
        Me.DataGridView_Out.RowTemplate.Height = 21
        Me.DataGridView_Out.Size = New System.Drawing.Size(265, 180)
        Me.DataGridView_Out.TabIndex = 28
        '
        'GroupBox_PDO_In
        '
        Me.GroupBox_PDO_In.Controls.Add(Me.Button_PDO_In_Clear)
        Me.GroupBox_PDO_In.Controls.Add(Me.DataGridView_In)
        Me.GroupBox_PDO_In.Location = New System.Drawing.Point(20, 210)
        Me.GroupBox_PDO_In.Name = "GroupBox_PDO_In"
        Me.GroupBox_PDO_In.Size = New System.Drawing.Size(280, 240)
        Me.GroupBox_PDO_In.TabIndex = 24
        Me.GroupBox_PDO_In.TabStop = False
        Me.GroupBox_PDO_In.Text = "PDO Input Entries"
        '
        'Button_PDO_In_Clear
        '
        Me.Button_PDO_In_Clear.Location = New System.Drawing.Point(8, 206)
        Me.Button_PDO_In_Clear.Name = "Button_PDO_In_Clear"
        Me.Button_PDO_In_Clear.Size = New System.Drawing.Size(150, 23)
        Me.Button_PDO_In_Clear.TabIndex = 26
        Me.Button_PDO_In_Clear.Text = "Clear Selected Row(s)"
        Me.Button_PDO_In_Clear.UseVisualStyleBackColor = True
        '
        'GroupBox_PDO_Out
        '
        Me.GroupBox_PDO_Out.Controls.Add(Me.Button_PDO_Out_Clear)
        Me.GroupBox_PDO_Out.Controls.Add(Me.DataGridView_Out)
        Me.GroupBox_PDO_Out.Location = New System.Drawing.Point(320, 210)
        Me.GroupBox_PDO_Out.Name = "GroupBox_PDO_Out"
        Me.GroupBox_PDO_Out.Size = New System.Drawing.Size(280, 240)
        Me.GroupBox_PDO_Out.TabIndex = 27
        Me.GroupBox_PDO_Out.TabStop = False
        Me.GroupBox_PDO_Out.Text = "PDO Output Entries"
        '
        'Button_PDO_Out_Clear
        '
        Me.Button_PDO_Out_Clear.Location = New System.Drawing.Point(8, 206)
        Me.Button_PDO_Out_Clear.Name = "Button_PDO_Out_Clear"
        Me.Button_PDO_Out_Clear.Size = New System.Drawing.Size(150, 23)
        Me.Button_PDO_Out_Clear.TabIndex = 29
        Me.Button_PDO_Out_Clear.Text = "Clear Selected Row(s)"
        Me.Button_PDO_Out_Clear.UseVisualStyleBackColor = True
        '
        'TextBox_Eeprom
        '
        Me.TextBox_Eeprom.Location = New System.Drawing.Point(320, 180)
        Me.TextBox_Eeprom.Name = "TextBox_Eeprom"
        Me.TextBox_Eeprom.Size = New System.Drawing.Size(280, 19)
        Me.TextBox_Eeprom.TabIndex = 23
        '
        'Label_Eeprom
        '
        Me.Label_Eeprom.AutoSize = True
        Me.Label_Eeprom.Location = New System.Drawing.Point(240, 183)
        Me.Label_Eeprom.Name = "Label_Eeprom"
        Me.Label_Eeprom.Size = New System.Drawing.Size(51, 12)
        Me.Label_Eeprom.TabIndex = 22
        Me.Label_Eeprom.Text = "EEPROM"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 501)
        Me.Controls.Add(Me.Label_Eeprom)
        Me.Controls.Add(Me.TextBox_Eeprom)
        Me.Controls.Add(Me.GroupBox_PDO_Out)
        Me.Controls.Add(Me.GroupBox_PDO_In)
        Me.Controls.Add(Me.Label_Locale_ID)
        Me.Controls.Add(Me.TextBox_Locale_ID)
        Me.Controls.Add(Me.TextBox_Group_Image)
        Me.Controls.Add(Me.Label_Group_Image)
        Me.Controls.Add(Me.Label_Vendor_Image)
        Me.Controls.Add(Me.TextBox_Vendor_Image)
        Me.Controls.Add(Me.Label_Device_Name)
        Me.Controls.Add(Me.TextBox_Device_Name)
        Me.Controls.Add(Me.Label_Group_Name)
        Me.Controls.Add(Me.TextBox_Group_Name)
        Me.Controls.Add(Me.Label_0x_3)
        Me.Controls.Add(Me.TextBox_Revision)
        Me.Controls.Add(Me.Label_Revision)
        Me.Controls.Add(Me.Label_0x_2)
        Me.Controls.Add(Me.Label_0x_1)
        Me.Controls.Add(Me.Label_Product_Code)
        Me.Controls.Add(Me.TextBox_Product_Code)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.Label_Vendor_Name)
        Me.Controls.Add(Me.TextBox_Vendor_Name)
        Me.Controls.Add(Me.Label_Vendor_ID)
        Me.Controls.Add(Me.TextBox_Vendor_ID)
        Me.Controls.Add(Me.Button_Close)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "StrayCAT ESI Tool"
        CType(Me.DataGridView_In, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Out, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_PDO_In.ResumeLayout(False)
        Me.GroupBox_PDO_Out.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Close As Button
    Friend WithEvents TextBox_Vendor_ID As TextBox
    Friend WithEvents Label_Vendor_ID As Label
    Friend WithEvents TextBox_Vendor_Name As TextBox
    Friend WithEvents Label_Vendor_Name As Label
    Friend WithEvents Button_Save As Button
    Friend WithEvents TextBox_Product_Code As TextBox
    Friend WithEvents Label_Product_Code As Label
    Friend WithEvents Label_0x_1 As Label
    Friend WithEvents Label_0x_2 As Label
    Friend WithEvents Label_Revision As Label
    Friend WithEvents TextBox_Revision As TextBox
    Friend WithEvents Label_0x_3 As Label
    Friend WithEvents TextBox_Group_Name As TextBox
    Friend WithEvents Label_Group_Name As Label
    Friend WithEvents TextBox_Device_Name As TextBox
    Friend WithEvents Label_Device_Name As Label
    Friend WithEvents TextBox_Vendor_Image As TextBox
    Friend WithEvents Label_Vendor_Image As Label
    Friend WithEvents Label_Group_Image As Label
    Friend WithEvents TextBox_Group_Image As TextBox
    Friend WithEvents TextBox_Locale_ID As TextBox
    Friend WithEvents Label_Locale_ID As Label
    Friend WithEvents DataGridView_In As DataGridView
    Friend WithEvents DataGridView_Out As DataGridView
    Friend WithEvents GroupBox_PDO_In As GroupBox
    Friend WithEvents GroupBox_PDO_Out As GroupBox
    Friend WithEvents Button_PDO_In_Clear As Button
    Friend WithEvents Button_PDO_Out_Clear As Button
    Friend WithEvents TextBox_Eeprom As TextBox
    Friend WithEvents Label_Eeprom As Label
End Class
