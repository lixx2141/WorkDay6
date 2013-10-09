Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click
        Dim curPop As Double
        Dim curYear As Integer

        curPop = 7000
        curYear = 2012

        Do While (curPop > 6)
            curPop = curPop / 2
            curYear = curYear - 50
        Loop

        MessageBox.Show("The year is " & curYear, "World Population")

    End Sub
End Class
