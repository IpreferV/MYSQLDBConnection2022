Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=chinookcs"

        Try
            conn.Open()
            MessageBox.Show("Success!", "Testing ChinookCS DB Connection")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class
