Public Class Form1
    Dim poziom1, poziom2, poziom3 As Integer
    Dim connected As Boolean


    Private Sub BtnCon_Click(sender As Object, e As EventArgs) Handles BtnCon.Click
        Dim ADport() As String

        Dim arrexist As Boolean
        Dim Finport As String
        Finport = Me.TxtPort.Text


        ADport = IO.Ports.SerialPort.GetPortNames()
        arrexist = False
        For i = LBound(ADport) To UBound(ADport)
            If ADport(i) = Finport Then
                SerialPort1.PortName = Finport
                SerialPort1.BaudRate = Me.TxtBaud.Text

                arrexist = True
                Exit For
            End If
        Next i

        If arrexist = True Then
            MsgBox("port istnieje")
            SerialPort1.Open()
            Timer1.Start()
            connected = True
        Else
            MsgBox("PORTU NIE MA!")
            connected = False
        End If

        BtnCon.Enabled = False

    End Sub

    Private Sub BtnDiscon_Click(sender As Object, e As EventArgs) Handles BtnDiscon.Click
        SerialPort1.Close()
        BtnCon.Enabled = True
        Timer1.Stop()

        BtnDiscon.Enabled = False
        connected = False

    End Sub

    Private Sub BtnSendSettingToArduino_Click(sender As Object, e As EventArgs) Handles BtnSendSettingToArduino.Click
        ' package starts with <, ends with >, separated by ,
        ' <1,1,1, - wartosci dla EM1,2,3
        '<1,1,1, 1,0.0, = full time, 
        '<1,1,1,0,0.7 = part time z 0.7
        '<1,1,1,0,1,0.7,1,0,0,0 - 1 contactron for all
        '<1,1,1,0,1,0.7,0,1,1,0 - 2 kontaktrony osobno
        '<1,1,1,0,1,0.7,0,1,1,1> - 3 kontaktrony osobno, part time
        If connected = False Then
            MsgBox("Nie polaczyles sie z portem")
            Exit Sub
        End If
        Dim StringAD As String
        Dim strcont1 As String, strcont2 As String, strcont3 As String
        StringAD = "<"
        If Me.Chk_EM1.Checked = True Then
            StringAD = StringAD & "1,"
        Else
            StringAD = StringAD & "0,"
        End If
        If Me.Chk_EM2.Checked = True Then
            StringAD = StringAD & "1,"
        Else
            StringAD = StringAD & "0,"
        End If
        If Me.Chk_EM3.Checked = True Then
            StringAD = StringAD & "1,"
        Else
            StringAD = StringAD & "0,"
        End If
        If Me.Chk_Time_Full.Checked = True Then
            StringAD = StringAD & "1,0.0,"
        Else
            StringAD = StringAD & "0," & Mid(Me.Txt_Time_Part.Text, 1, 4) & ","
        End If
        If Me.Chk_Contactron_1_All.Checked = True Then
            StringAD = StringAD & "1,0,0,0"
        Else
            If Me.Chk_Contactron1.Checked = True Then
                strcont1 = "1,"
            Else
                strcont1 = "0,"
            End If
            If Me.Chk_Contactron2.Checked = True Then
                strcont2 = "1,"
            Else
                strcont2 = "0,"
            End If
            If Me.Chk_Contactron3.Checked = True Then
                strcont3 = "1" 'tu bez przecinka, bo koniec pakietu
            Else
                strcont3 = "0"
            End If
            StringAD = StringAD & "0," & strcont1 & strcont2 & strcont3
        End If
        StringAD = StringAD & ">"
        MsgBox(StringAD)
        Me.LblLastUpload.Text = StringAD
        SerialPort1.Write(StringAD)
    End Sub

    Private Sub Chk_Time_Full_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Time_Full.CheckedChanged
        If Me.Chk_Time_Full.Checked = True Then
            Me.Chk_Time_Part.Checked = False
        End If
    End Sub

    Private Sub Chk_Time_Part_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Time_Part.CheckedChanged
        If Me.Chk_Time_Part.Checked = True Then
            Me.Chk_Time_Full.Checked = False
        End If
    End Sub

    Private Sub Chk_Contactron_1_All_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Contactron_1_All.CheckedChanged
        If Me.Chk_Contactron_1_All.Checked = True Then
            Me.Chk_Contactron1.Checked = False
            Me.Chk_Contactron2.Checked = False
            Me.Chk_Contactron3.Checked = False
        End If
    End Sub

    Private Sub Chk_Contactron1_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Contactron1.CheckedChanged
        If Me.Chk_Contactron1.Checked = True Then
            Me.Chk_Contactron_1_All.Checked = False
        End If
    End Sub

    Private Sub Chk_Contactron2_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Contactron2.CheckedChanged
        If Me.Chk_Contactron2.Checked = True Then
            Me.Chk_Contactron_1_All.Checked = False
        End If
    End Sub

    Private Sub Chk_Contactron3_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Contactron3.CheckedChanged
        If Me.Chk_Contactron3.Checked = True Then
            Me.Chk_Contactron_1_All.Checked = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SerialPort1.Write(Me.TxtToSend.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connected = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim i As String = SerialPort1.ReadExisting
            Me.LblKomenda.Text = i
            'Dim subString As String = Me.LblKomenda.Text
            'If subString.Substring(0, Math.Min(16, subString.Length)) = ("$0102002lew 35 ^") Then '$0102002lew %d ^",35
            '    Me.LblGet.Text = i
            '    ' Me.BtnLeft.PerformClick()


            'ElseIf subString.Substring(0, Math.Min(16, subString.Length)) = ("$0102002pra 48 ^") Then '$0102002lew %d ^",35
            '    Me.LblGet.Text = i
            '    '  Me.BtnRight.PerformClick()
            'ElseIf subString.Substring(0, Math.Min(16, subString.Length)) = ("$0102002gor 74 ^") Then
            '    Me.LblGet.Text = i
            '    ' Me.BtnUp.PerformClick()
            'ElseIf subString.Substring(0, Math.Min(16, subString.Length)) = ("$0102002dol 96 ^") Then
            '    Me.LblGet.Text = i
            '    ' Me.BtnDown.PerformClick()
            'ElseIf subString.Substring(0, Math.Min(16, subString.Length)) = ("$0102002ent 98 ^") Then
            '    Me.LblGet.Text = i
            '    '  Me.BtnEnter.PerformClick()
            'Else
            '    Me.LblGet.Text = "zła komenda"
            'End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        '  For i = 1 To Me.txtsend.TextLength
        ' SerialPort1.Write(Mid(Me.txtsend.Text, i, 1))
        'Next i
        SerialPort1.Write(Me.txtsend.Text)
    End Sub


End Class
























