Imports MySql.Data.MySqlClient
Imports System.IO
Public Class AddCityPage
    Dim cmd As New MySqlCommand
    Dim cn As New MySqlConnection
    Private Sub AddCityPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "server = 10.50.45.158; userid=tushar; password=tushar.123; database=dbms;"
        cn.Open()

    End Sub

    Private Sub Enter_Click(sender As Object, e As EventArgs) Handles Enter.Click
        Dim cid As New Integer
        Dim cstate As String
        Dim cname As String
        Dim cabt As String

        cid = cityid.Text
        cstate = state.Text
        cname = cityname.Text
        cabt = cityabt.Text

        Dim ms As New MemoryStream

        cmd.Connection = cn
        cmd.CommandText = "Insert into city(city_id,state,city_name,city_img,city_about) values(@id,@s,@name,@cimg,@cabout) "


        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        cmd.Parameters.AddWithValue("@id", cid)
        cmd.Parameters.AddWithValue("@s", cstate)
        cmd.Parameters.AddWithValue("@name", cname)
        cmd.Parameters.AddWithValue("@cabout", cabt)
        cmd.Parameters.Add("@cimg", MySqlDbType.Blob).Value = ms.ToArray

        'If cmd.ExecuteNonQuery() = 1 Then
        'MessageBox.Show("Inserted")
        'Else
        'MessageBox.Show("Not insered")
        'End If

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error Message")
        End Try


        My.Forms.AddCityPage.Close()
        My.Forms.homepage.Show()

    End Sub

    Private Sub cityabt_TextChanged(sender As Object, e As EventArgs) Handles cityabt.TextChanged

    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose image(*JPG;*PNG;*GIF)|*jpg;*png;*gif"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.AddCityPage.Close()
        My.Forms.homepage.Show()
    End Sub
End Class