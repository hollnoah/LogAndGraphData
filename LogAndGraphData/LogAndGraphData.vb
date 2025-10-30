﻿Option Strict On
Option Explicit On
Imports System.Runtime.InteropServices
Public Class LogAndGraphData
    Function GetRandomNumberAround(thisnUmber%, Optional within% = 10) As Integer
        Dim result%

        result = GetRandomNumber(within) + GetRandomNumber(within)

        Return result
    End Function

    Function GetRandomNumber(max%) As Integer
        Randomize()

        Return CInt(System.Math.Floor((Rnd() * max)) + 1)
    End Function
    Function GetData() As Integer
        Return 5
    End Function

    Sub GraphData()
        Dim g As Graphics = GraphPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Lime)
        Dim scaleX As Single = CSng(GraphPictureBox.Width / 100)
        Dim scaleY As Single = CSng((GraphPictureBox.Width / 100) * -1)
        Dim oldY% = 50


        g.TranslateTransform(0, GraphPictureBox.Height)
        g.ScaleTransform(scaleX, scaleY)

        pen.Width = 0.25

        For x = 0 To 100
            g.DrawLine(pen, x - 1, oldY, x, 50)

        Next

        g.Dispose()
        pen.Dispose()

    End Sub
    '---------------------------------------------------EVENT HANDLERS---------------------------------------------------------------------------------------------------
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub GraphButton_Click(sender As Object, e As EventArgs) Handles GraphButton.Click
        'GraphData()
        For i = 1 To 100
            Console.WriteLine(GetRandomNumberAround(50, 10))
        Next
    End Sub
End Class
