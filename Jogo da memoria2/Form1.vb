Public Class Form1
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox1.BackgroundImage = My.Resources.Resources.imagem(0)
    End Sub

    Function imagem(i)
        Select Case i
            Case 0
                Return My.Resources.Resources.juventus
            Case 1
                Return My.Resources.Resources.fiorentina
            Case 2
                Return My.Resources.Resources.spal
            Case 3
                Return My.Resources.Resources.roma
            Case 4
                Return My.Resources.Resources.napoli
            Case 5
                Return My.Resources.Resources.lazio
            Case 6
                Return My.Resources.Resources.inter
        End Select
    End Function
End Class