Imports MySql.Data.MySqlClient
Public Class homepage
    Dim cmd As New MySqlCommand
    Dim cn As New MySqlConnection



    Private Sub homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "server = 10.50.45.158; userid=tushar; password=tushar.123; database=dbms;"
        cn.Open()
        aname.Text = Form1.userid.Text

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Forms.reviewpage.Show()
        My.Forms.homepage.Hide()
    End Sub

    Private Sub AddPlace_Click(sender As Object, e As EventArgs) Handles AddPlace.Click
        My.Forms.AddPlacePage.Show()
        My.Forms.homepage.Hide()
    End Sub

    Private Sub AddCity_Click(sender As Object, e As EventArgs) Handles AddCity.Click
        My.Forms.AddCityPage.Show()
        My.Forms.homepage.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Forms.UpdateCityPage.Show()
        My.Forms.homepage.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Forms.UpdatePlacePage.Show()
        My.Forms.homepage.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        My.Forms.homepage.Close()
        My.Forms.Form1.Show()
    End Sub

    Private Sub aname_Click(sender As Object, e As EventArgs) Handles aname.Click

    End Sub
End Class