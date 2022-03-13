Public Class Form1

    Dim operand1, operand2 As Double
    Dim op As Char
    Dim isDot As Boolean = False
    Dim isOperand2 As Boolean = False
    Dim isResult As Boolean = False

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

        If isResult Then
            formula_TB.Text = ""
        End If
        'Dont insert another number if the size is over 14 char
        If main_TB.Text.Length > 12 Then
            Return
        End If
        'If the number is 0 change it to a number entered
        If main_TB.Text = "0" Or isOperand2 Then
            main_TB.Text = num.ToString()

            isOperand2 = False
            Return
        End If

        main_TB.Text += num.ToString()
    End Sub

    Private Sub comma_BTN_Click(sender As Object, e As EventArgs) Handles comma_BTN.Click

        'Dont insert another number if the size is over 14 char
        If main_TB.Text.Length > 12 Then
            Return
        End If

        If Not isDot Then
            main_TB.Text += "."
            isDot = True
        End If
    End Sub

    'Calculator Tools
    Private Sub back_BTN_Click(sender As Object, e As EventArgs) Handles back_BTN.Click
        formula_TB.Text = ""

        If main_TB.Text.Length = 0 Then
            Return
        End If
        'if dot removed make it available
        isDot = main_TB.Text.Contains("."c)

        main_TB.Text = main_TB.Text.Remove(main_TB.Text.Length - 1)
        If main_TB.Text.Length = 0 Then
            main_TB.Text = "0"
        End If
    End Sub

    Private Sub c_BTN_Click(sender As Object, e As EventArgs) Handles c_BTN.Click
        isDot = False
        isResult = False
        formula_TB.Text = ""
        main_TB.Text = "0"
    End Sub

    Private Sub ce_BTN_Click(sender As Object, e As EventArgs) Handles ce_BTN.Click
        isDot = False
        isResult = False
        formula_TB.Text = ""
        main_TB.Text = "0"
    End Sub

    'Change the sign of the number
    Private Sub sign_BTN_Click(sender As Object, e As EventArgs) Handles sign_BTN.Click

        If isResult Then
            formula_TB.Text = "negate(" + main_TB.Text + ")"
        End If

        If main_TB.Text = "0" Then
            Return
        End If

        If main_TB.Text(0) <> "-"c Then
            main_TB.Text = main_TB.Text.Insert(0, "-"c)
        Else
            main_TB.Text = main_TB.Text.Remove(0, 1)
        End If
    End Sub

    Private Sub add_BTN_Click(sender As Object, e As EventArgs) Handles add_BTN.Click
        Calculate("+"c)
    End Sub

    Private Sub sub_BTN_Click(sender As Object, e As EventArgs) Handles sub_BTN.Click
        Calculate("-"c)
    End Sub

    Private Sub mul_BTN_Click(sender As Object, e As EventArgs) Handles mul_BTN.Click
        Calculate("×"c)
    End Sub

    Private Sub div_BTN_Click(sender As Object, e As EventArgs) Handles div_BTN.Click
        Calculate("÷"c)
    End Sub

    Private Sub result_BTN_Click(sender As Object, e As EventArgs) Handles result_BTN.Click

        isOperand2 = True

        If Not isResult Then
            operand2 = Double.Parse(main_TB.Text)
            isResult = True
        Else
            operand1 = Double.Parse(main_TB.Text)
        End If

        Select Case op
            Case "+"c
                main_TB.Text = operand1 + operand2
            Case "-"c
                main_TB.Text = operand1 - operand2
            Case "×"c
                main_TB.Text = operand1 * operand2
            Case "÷"c
                main_TB.Text = operand1 / operand2
        End Select

        formula_TB.Text = operand1.ToString() + " " + op + " " + operand2.ToString() + " = "
    End Sub

    Private Sub Calculate(_op As Char)
        formula_TB.Text = main_TB.Text + " " + _op

        operand1 = Double.Parse(main_TB.Text)

        op = _op

        isDot = main_TB.Text.Contains("."c)
        isOperand2 = True
        isResult = False
    End Sub
    'Calculate

End Class
