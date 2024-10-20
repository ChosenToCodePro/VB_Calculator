Imports System.Data
Public Class Form1
    Private Sub num_Click(sender As Object, e As EventArgs) Handles num_0.Click, num_1.Click, num_2.Click, num_3.Click, num_4.Click, num_5.Click, num_6.Click, num_7.Click, num_8.Click, num_9.Click, addition.Click, subtraction.Click, division.Click, period.Click, parentheses_end.Click, parenthesis_start.Click
        Dim button = CType(sender, Button)
        input_field.Text &= button.Text
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        input_field.Text = ""
        expression_history.Text = ""
    End Sub

    Private Sub equals_Click(sender As Object, e As EventArgs) Handles equals.Click
        Dim expression = input_field.Text
        Dim result = calc(expression)
        expression_history.Text = expression
        input_field.Text = result
    End Sub
    Private Function calc(e As String) As Object
        Dim tab As New DataTable()

        Try
            Return tab.Compute(e, Nothing)
        Catch ex As Exception
            Return "Invalid Input."
        End Try
    End Function
    Private Function scrolling(sender As Object, e As EventArgs)
        input_field.SelectionStart = input_field.Text.Length
        input_field.ScrollToCaret()
    End Function

    Private Sub multiplication_Click(sender As Object, e As EventArgs) Handles multiplication.Click
        input_field.Text += "*"
    End Sub

    Private Sub input_field_tc(sender As Object, e As EventArgs) Handles input_field.TextChanged
        scrolling(sender, e)
    End Sub

    Private Sub backspace_Click(sender As Object, e As EventArgs) Handles backspace.Click
        If input_field.Text.Length > 0 Then
            input_field.Text = input_field.Text.Substring(0, input_field.Text.Length - 1)
        End If
    End Sub
End Class
