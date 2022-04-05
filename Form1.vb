Public Class Form1
    Dim x1, x2, y1, y2, sayac As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = Image.FromFile(Application.StartupPath + "\pictureodev_siyah.jpg")
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.Image = Image.FromFile(Application.StartupPath + "\pictureodev_siyah.jpg")
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        PictureBox1.CreateGraphics.DrawLine(Pens.Yellow, e.X, e.Y, e.X + 1, e.Y + 1)
    End Sub

    Private Sub PictureBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseClick
        sayac += 1
        'Doğru çalışan ama çizgiyi 2 adımda bir tersten çeken kodlar
        'If (sayac = 1) Then
        '    x1 = e.X
        '    y1 = e.Y
        'ElseIf (sayac = 2) Then
        '    x2 = e.X
        '    y2 = e.Y
        '    PictureBox2.CreateGraphics.DrawLine(Pens.Red, x1, y1, x2, y2)
        '    x1 = x2
        '    y1 = y2
        'Else
        '    If (sayac Mod 2 = 1) Then
        '        x1 = e.X
        '        y1 = e.Y
        '    Else
        '        x2 = e.X
        '        y2 = e.Y
        '    End If
        '    PictureBox2.CreateGraphics.DrawLine(Pens.Red, x1, y1, x2, y2)
        'End If

        'Çizgiyi önceki tıklanmış yerden şu an tıklanan yere çeken program
        If sayac = 1 Then
            x1 = e.X
            y1 = e.Y
        Else
            x2 = e.X
            y2 = e.Y
        End If
        If sayac > 1 Then
            PictureBox2.CreateGraphics.DrawLine(Pens.Red, x1, y1, x2, y2)
            x1 = x2
            y1 = y2
        End If
    End Sub
End Class
