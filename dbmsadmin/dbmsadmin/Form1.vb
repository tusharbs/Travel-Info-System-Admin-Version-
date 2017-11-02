Imports MySql.Data.MySqlClient
Public Class Form1
    Dim cn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Public user_id As String
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles userid.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "server = 10.50.45.158; userid=tushar; password=tushar.123; database=dbms;"
        cn.Open()


        passwd.Enabled = True
        userid.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles loginbutton.Click
        Dim input As String
        Dim pass As String
        Dim user As String
        Dim rd As MySqlDataReader
        input = passwd.Text
        pass = Nothing
        input = passwd.Text
        user = userid.Text
        cmd.Connection = cn
        cmd.CommandText = "SELECT passwords from admindb where userid = @userid ;"
        cmd.Parameters.AddWithValue("@userid", user)
        cmd.Prepare()
        rd = cmd.ExecuteReader
        If rd.Read Then
            pass = rd.GetString(0)
        End If
        rd.Close()
        cmd.Parameters.Clear()
        If String.Compare(pass, input) = 0 Then
            user_id = userid.Text
            MsgBox("Welcome back " & user & "!")

            passwd.Clear()
            My.Forms.homepage.Show()
            My.Forms.Form1.Hide()
        Else
            MsgBox("Incorrect password.Enter again")
            passwd.Clear()
        End If

    End Sub

    Private Sub check_Click(sender As Object, e As EventArgs)
        Dim user As String
        Dim input As String
        Dim rd As MySqlDataReader
        input = userid.Text
        cmd.Connection = cn
        cmd.CommandText = "SELECT userid  FROM admindb where userid = @input ;"
        cmd.Parameters.AddWithValue("@input", input)
        rd = cmd.ExecuteReader
        If rd.Read Then
            user = rd.GetString(0)
        End If
        rd.Close()
        If String.IsNullOrEmpty(user) Then
            MsgBox("Enter valid userID")
            userid.Clear()
        Else
            MsgBox("User record found")
            passwd.Enabled = True
        End If
        cmd.Parameters.Clear()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        My.Forms.register_page.Show()
        My.Forms.Form1.Hide()
    End Sub
End Class
