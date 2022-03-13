Public Class Form1
    Private Sub num0_BTN_Click(sender As Object, e As EventArgs) Handles num0_BTN.Click
        InsertNumber(0)
    End Sub
    Private Sub num1_BTN_Click(sender As Object, e As EventArgs) Handles num1_BTN.Click
        InsertNumber(1)
    End Sub
    Private Sub num2_BTN_Click(sender As Object, e As EventArgs) Handles num2_BTN.Click
        InsertNumber(2)
    End Sub
    Private Sub num3_BTN_Click(sender As Object, e As EventArgs) Handles num3_BTN.Click
        InsertNumber(3)
    End Sub
    Private Sub num4_BTN_Click(sender As Object, e As EventArgs) Handles num4_BTN.Click
        InsertNumber(4)
    End Sub
    Private Sub num5_BTN_Click(sender As Object, e As EventArgs) Handles num5_BTN.Click
        InsertNumber(5)
    End Sub
    Private Sub num6_BTN_Click(sender As Object, e As EventArgs) Handles num6_BTN.Click
        InsertNumber(6)
    End Sub
    Private Sub num7_BTN_Click(sender As Object, e As EventArgs) Handles num7_BTN.Click
        InsertNumber(7)
    End Sub
    Private Sub num8_BTN_Click(sender As Object, e As EventArgs) Handles num8_BTN.Click
        InsertNumber(8)
    End Sub
    Private Sub num9_BTN_Click(sender As Object, e As EventArgs) Handles num9_BTN.Click
        InsertNumber(9)
    End Sub

    Private Sub InsertNumber(num As Integer)

        'Dont insert multiple 0 
        If (main_TB.Text = "0" And num = 0) Or (main_TB.Text.Length > 13) Then
            Return
        End If

        If main_TB.Text = "0" Then
            main_TB.Text = num.ToString()
            Return
        End If

        main_TB.Text += num.ToString()
        'main_TB.Text = Format(Double.Parse(main_TB.Text), "##,##0.00")
    End Sub
End Class
