<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnCon = New System.Windows.Forms.Button()
        Me.TxtPort = New System.Windows.Forms.TextBox()
        Me.TxtBaud = New System.Windows.Forms.TextBox()
        Me.BtnDiscon = New System.Windows.Forms.Button()
        Me.LblGet = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnSend = New System.Windows.Forms.Button()
        Me.txtsend = New System.Windows.Forms.TextBox()
        Me.LblKomenda = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LblPoz1 = New System.Windows.Forms.Label()
        Me.LblPoz2 = New System.Windows.Forms.Label()
        Me.LblPoz3 = New System.Windows.Forms.Label()
        Me.Lbl_ListName = New System.Windows.Forms.Label()
        Me.LblSecondLst = New System.Windows.Forms.Label()
        Me.Chk_EM1 = New System.Windows.Forms.CheckBox()
        Me.Chk_EM2 = New System.Windows.Forms.CheckBox()
        Me.Chk_EM3 = New System.Windows.Forms.CheckBox()
        Me.Chk_Time_Full = New System.Windows.Forms.CheckBox()
        Me.Chk_Time_Part = New System.Windows.Forms.CheckBox()
        Me.Txt_Time_Part = New System.Windows.Forms.TextBox()
        Me.Chk_Contactron_1_All = New System.Windows.Forms.CheckBox()
        Me.Chk_Contactron1 = New System.Windows.Forms.CheckBox()
        Me.Chk_Contactron2 = New System.Windows.Forms.CheckBox()
        Me.Chk_Contactron3 = New System.Windows.Forms.CheckBox()
        Me.BtnSendSettingToArduino = New System.Windows.Forms.Button()
        Me.TxtToSend = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblLastUpload = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCon
        '
        Me.BtnCon.Location = New System.Drawing.Point(143, 86)
        Me.BtnCon.Name = "BtnCon"
        Me.BtnCon.Size = New System.Drawing.Size(123, 40)
        Me.BtnCon.TabIndex = 0
        Me.BtnCon.Text = "Connect"
        Me.BtnCon.UseVisualStyleBackColor = True
        '
        'TxtPort
        '
        Me.TxtPort.Location = New System.Drawing.Point(287, 68)
        Me.TxtPort.Name = "TxtPort"
        Me.TxtPort.Size = New System.Drawing.Size(89, 20)
        Me.TxtPort.TabIndex = 1
        Me.TxtPort.Text = "COM3"
        '
        'TxtBaud
        '
        Me.TxtBaud.Location = New System.Drawing.Point(439, 71)
        Me.TxtBaud.Name = "TxtBaud"
        Me.TxtBaud.Size = New System.Drawing.Size(129, 20)
        Me.TxtBaud.TabIndex = 2
        Me.TxtBaud.Text = "115200"
        '
        'BtnDiscon
        '
        Me.BtnDiscon.Location = New System.Drawing.Point(142, 129)
        Me.BtnDiscon.Name = "BtnDiscon"
        Me.BtnDiscon.Size = New System.Drawing.Size(124, 44)
        Me.BtnDiscon.TabIndex = 3
        Me.BtnDiscon.Text = "Disconnet"
        Me.BtnDiscon.UseVisualStyleBackColor = True
        '
        'LblGet
        '
        Me.LblGet.AutoSize = True
        Me.LblGet.Location = New System.Drawing.Point(612, 192)
        Me.LblGet.Name = "LblGet"
        Me.LblGet.Size = New System.Drawing.Size(59, 13)
        Me.LblGet.TabIndex = 4
        Me.LblGet.Text = "LblGetText"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'BtnSend
        '
        Me.BtnSend.Location = New System.Drawing.Point(615, 129)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(110, 51)
        Me.BtnSend.TabIndex = 5
        Me.BtnSend.Text = "BtnSend"
        Me.BtnSend.UseVisualStyleBackColor = True
        '
        'txtsend
        '
        Me.txtsend.Location = New System.Drawing.Point(583, 254)
        Me.txtsend.Name = "txtsend"
        Me.txtsend.Size = New System.Drawing.Size(189, 20)
        Me.txtsend.TabIndex = 6
        Me.txtsend.Text = "What To sent"
        '
        'LblKomenda
        '
        Me.LblKomenda.AutoSize = True
        Me.LblKomenda.Location = New System.Drawing.Point(563, 352)
        Me.LblKomenda.Name = "LblKomenda"
        Me.LblKomenda.Size = New System.Drawing.Size(92, 13)
        Me.LblKomenda.TabIndex = 20
        Me.LblKomenda.Text = "LblKomenda Must"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(371, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(143, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(91, 20)
        Me.TextBox1.TabIndex = 23
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(240, 19)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(91, 20)
        Me.TextBox2.TabIndex = 24
        '
        'LblPoz1
        '
        Me.LblPoz1.AutoSize = True
        Me.LblPoz1.Location = New System.Drawing.Point(505, 15)
        Me.LblPoz1.Name = "LblPoz1"
        Me.LblPoz1.Size = New System.Drawing.Size(39, 13)
        Me.LblPoz1.TabIndex = 27
        Me.LblPoz1.Text = "Label1"
        '
        'LblPoz2
        '
        Me.LblPoz2.AutoSize = True
        Me.LblPoz2.Location = New System.Drawing.Point(560, 12)
        Me.LblPoz2.Name = "LblPoz2"
        Me.LblPoz2.Size = New System.Drawing.Size(39, 13)
        Me.LblPoz2.TabIndex = 28
        Me.LblPoz2.Text = "Label1"
        '
        'LblPoz3
        '
        Me.LblPoz3.AutoSize = True
        Me.LblPoz3.Location = New System.Drawing.Point(622, 9)
        Me.LblPoz3.Name = "LblPoz3"
        Me.LblPoz3.Size = New System.Drawing.Size(39, 13)
        Me.LblPoz3.TabIndex = 29
        Me.LblPoz3.Text = "Label1"
        '
        'Lbl_ListName
        '
        Me.Lbl_ListName.AutoSize = True
        Me.Lbl_ListName.Location = New System.Drawing.Point(675, 6)
        Me.Lbl_ListName.Name = "Lbl_ListName"
        Me.Lbl_ListName.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_ListName.TabIndex = 30
        Me.Lbl_ListName.Text = "Label1"
        '
        'LblSecondLst
        '
        Me.LblSecondLst.AutoSize = True
        Me.LblSecondLst.Location = New System.Drawing.Point(703, 48)
        Me.LblSecondLst.Name = "LblSecondLst"
        Me.LblSecondLst.Size = New System.Drawing.Size(39, 13)
        Me.LblSecondLst.TabIndex = 40
        Me.LblSecondLst.Text = "Label1"
        '
        'Chk_EM1
        '
        Me.Chk_EM1.AutoSize = True
        Me.Chk_EM1.Checked = True
        Me.Chk_EM1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_EM1.Location = New System.Drawing.Point(66, 250)
        Me.Chk_EM1.Name = "Chk_EM1"
        Me.Chk_EM1.Size = New System.Drawing.Size(67, 17)
        Me.Chk_EM1.TabIndex = 41
        Me.Chk_EM1.Text = "EM1 ON"
        Me.Chk_EM1.UseVisualStyleBackColor = True
        '
        'Chk_EM2
        '
        Me.Chk_EM2.AutoSize = True
        Me.Chk_EM2.Checked = True
        Me.Chk_EM2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_EM2.Location = New System.Drawing.Point(143, 250)
        Me.Chk_EM2.Name = "Chk_EM2"
        Me.Chk_EM2.Size = New System.Drawing.Size(67, 17)
        Me.Chk_EM2.TabIndex = 42
        Me.Chk_EM2.Text = "EM2 ON"
        Me.Chk_EM2.UseVisualStyleBackColor = True
        '
        'Chk_EM3
        '
        Me.Chk_EM3.AutoSize = True
        Me.Chk_EM3.Checked = True
        Me.Chk_EM3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_EM3.Location = New System.Drawing.Point(240, 250)
        Me.Chk_EM3.Name = "Chk_EM3"
        Me.Chk_EM3.Size = New System.Drawing.Size(67, 17)
        Me.Chk_EM3.TabIndex = 43
        Me.Chk_EM3.Text = "EM3 ON"
        Me.Chk_EM3.UseVisualStyleBackColor = True
        '
        'Chk_Time_Full
        '
        Me.Chk_Time_Full.AutoSize = True
        Me.Chk_Time_Full.Location = New System.Drawing.Point(61, 291)
        Me.Chk_Time_Full.Name = "Chk_Time_Full"
        Me.Chk_Time_Full.Size = New System.Drawing.Size(87, 17)
        Me.Chk_Time_Full.TabIndex = 44
        Me.Chk_Time_Full.Text = "Full Time ON"
        Me.Chk_Time_Full.UseVisualStyleBackColor = True
        '
        'Chk_Time_Part
        '
        Me.Chk_Time_Part.AutoSize = True
        Me.Chk_Time_Part.Checked = True
        Me.Chk_Time_Part.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_Time_Part.Location = New System.Drawing.Point(172, 290)
        Me.Chk_Time_Part.Name = "Chk_Time_Part"
        Me.Chk_Time_Part.Size = New System.Drawing.Size(90, 17)
        Me.Chk_Time_Part.TabIndex = 45
        Me.Chk_Time_Part.Text = "Part Time ON"
        Me.Chk_Time_Part.UseVisualStyleBackColor = True
        '
        'Txt_Time_Part
        '
        Me.Txt_Time_Part.Location = New System.Drawing.Point(277, 292)
        Me.Txt_Time_Part.Name = "Txt_Time_Part"
        Me.Txt_Time_Part.Size = New System.Drawing.Size(116, 20)
        Me.Txt_Time_Part.TabIndex = 46
        Me.Txt_Time_Part.Text = "0.70"
        '
        'Chk_Contactron_1_All
        '
        Me.Chk_Contactron_1_All.AutoSize = True
        Me.Chk_Contactron_1_All.Location = New System.Drawing.Point(59, 335)
        Me.Chk_Contactron_1_All.Name = "Chk_Contactron_1_All"
        Me.Chk_Contactron_1_All.Size = New System.Drawing.Size(127, 17)
        Me.Chk_Contactron_1_All.TabIndex = 47
        Me.Chk_Contactron_1_All.Text = "1 Contactron For ALL"
        Me.Chk_Contactron_1_All.UseVisualStyleBackColor = True
        '
        'Chk_Contactron1
        '
        Me.Chk_Contactron1.AutoSize = True
        Me.Chk_Contactron1.Checked = True
        Me.Chk_Contactron1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_Contactron1.Location = New System.Drawing.Point(60, 371)
        Me.Chk_Contactron1.Name = "Chk_Contactron1"
        Me.Chk_Contactron1.Size = New System.Drawing.Size(103, 17)
        Me.Chk_Contactron1.TabIndex = 48
        Me.Chk_Contactron1.Text = "EM1 Contactron"
        Me.Chk_Contactron1.UseVisualStyleBackColor = True
        '
        'Chk_Contactron2
        '
        Me.Chk_Contactron2.AutoSize = True
        Me.Chk_Contactron2.Checked = True
        Me.Chk_Contactron2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_Contactron2.Location = New System.Drawing.Point(181, 370)
        Me.Chk_Contactron2.Name = "Chk_Contactron2"
        Me.Chk_Contactron2.Size = New System.Drawing.Size(103, 17)
        Me.Chk_Contactron2.TabIndex = 49
        Me.Chk_Contactron2.Text = "EM2 Contactron"
        Me.Chk_Contactron2.UseVisualStyleBackColor = True
        '
        'Chk_Contactron3
        '
        Me.Chk_Contactron3.AutoSize = True
        Me.Chk_Contactron3.Checked = True
        Me.Chk_Contactron3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_Contactron3.Location = New System.Drawing.Point(295, 370)
        Me.Chk_Contactron3.Name = "Chk_Contactron3"
        Me.Chk_Contactron3.Size = New System.Drawing.Size(103, 17)
        Me.Chk_Contactron3.TabIndex = 50
        Me.Chk_Contactron3.Text = "EM3 Contactron"
        Me.Chk_Contactron3.UseVisualStyleBackColor = True
        '
        'BtnSendSettingToArduino
        '
        Me.BtnSendSettingToArduino.Location = New System.Drawing.Point(137, 425)
        Me.BtnSendSettingToArduino.Name = "BtnSendSettingToArduino"
        Me.BtnSendSettingToArduino.Size = New System.Drawing.Size(178, 48)
        Me.BtnSendSettingToArduino.TabIndex = 51
        Me.BtnSendSettingToArduino.Text = "SendSettingToArduino"
        Me.BtnSendSettingToArduino.UseVisualStyleBackColor = True
        '
        'TxtToSend
        '
        Me.TxtToSend.Location = New System.Drawing.Point(416, 425)
        Me.TxtToSend.Name = "TxtToSend"
        Me.TxtToSend.Size = New System.Drawing.Size(152, 20)
        Me.TxtToSend.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(408, 394)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Example  <Hello,12,0.7>"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(436, 466)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(189, 54)
        Me.Button2.TabIndex = 54
        Me.Button2.Text = "Send Example Text"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 497)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Last Uploaded Settings"
        '
        'LblLastUpload
        '
        Me.LblLastUpload.AutoSize = True
        Me.LblLastUpload.Location = New System.Drawing.Point(108, 519)
        Me.LblLastUpload.Name = "LblLastUpload"
        Me.LblLastUpload.Size = New System.Drawing.Size(13, 13)
        Me.LblLastUpload.TabIndex = 56
        Me.LblLastUpload.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 647)
        Me.Controls.Add(Me.LblLastUpload)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtToSend)
        Me.Controls.Add(Me.BtnSendSettingToArduino)
        Me.Controls.Add(Me.Chk_Contactron3)
        Me.Controls.Add(Me.Chk_Contactron2)
        Me.Controls.Add(Me.Chk_Contactron1)
        Me.Controls.Add(Me.Chk_Contactron_1_All)
        Me.Controls.Add(Me.Txt_Time_Part)
        Me.Controls.Add(Me.Chk_Time_Part)
        Me.Controls.Add(Me.Chk_Time_Full)
        Me.Controls.Add(Me.Chk_EM3)
        Me.Controls.Add(Me.Chk_EM2)
        Me.Controls.Add(Me.Chk_EM1)
        Me.Controls.Add(Me.LblSecondLst)
        Me.Controls.Add(Me.Lbl_ListName)
        Me.Controls.Add(Me.LblPoz3)
        Me.Controls.Add(Me.LblPoz2)
        Me.Controls.Add(Me.LblPoz1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblKomenda)
        Me.Controls.Add(Me.txtsend)
        Me.Controls.Add(Me.BtnSend)
        Me.Controls.Add(Me.LblGet)
        Me.Controls.Add(Me.BtnDiscon)
        Me.Controls.Add(Me.TxtBaud)
        Me.Controls.Add(Me.TxtPort)
        Me.Controls.Add(Me.BtnCon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCon As Button
    Friend WithEvents TxtPort As TextBox
    Friend WithEvents TxtBaud As TextBox
    Friend WithEvents BtnDiscon As Button
    Friend WithEvents LblGet As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnSend As Button
    Friend WithEvents txtsend As TextBox
    Friend WithEvents LblKomenda As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LblPoz1 As Label
    Friend WithEvents LblPoz2 As Label
    Friend WithEvents LblPoz3 As Label
    Friend WithEvents Lbl_ListName As Label
    Friend WithEvents LblSecondLst As Label
    Friend WithEvents Chk_EM1 As CheckBox
    Friend WithEvents Chk_EM2 As CheckBox
    Friend WithEvents Chk_EM3 As CheckBox
    Friend WithEvents Chk_Time_Full As CheckBox
    Friend WithEvents Chk_Time_Part As CheckBox
    Friend WithEvents Txt_Time_Part As TextBox
    Friend WithEvents Chk_Contactron_1_All As CheckBox
    Friend WithEvents Chk_Contactron1 As CheckBox
    Friend WithEvents Chk_Contactron2 As CheckBox
    Friend WithEvents Chk_Contactron3 As CheckBox
    Friend WithEvents BtnSendSettingToArduino As Button
    Friend WithEvents TxtToSend As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LblLastUpload As Label
End Class
