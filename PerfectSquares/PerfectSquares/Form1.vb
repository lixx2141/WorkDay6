Option Strict On

Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
        Dim num As Integer
        Dim sqr As Integer

        num = 1

        Do While (num <= 10)
            sqr = num * num
            lstResult.Items.Add(sqr)
            num = num + 1
        Loop

    End Sub
End Class
