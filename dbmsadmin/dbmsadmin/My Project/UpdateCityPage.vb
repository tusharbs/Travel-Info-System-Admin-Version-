Imports MySql.Data.MySqlClient
Imports System.IO
Public Class UpdateCityPage
    Dim cmd As New MySqlCommand
    Dim cn As New MySqlConnection
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cid As New Integer
        Dim cstate As String
        Dim cname As String
        Dim cabt As String
        cid = cityid.Text
        cstate = state.Text.ToLower
        cname = cityname.Text.ToLower
        cabt = cityabt.Text

        Dim ms As New MemoryStream

        cmd.Connection = cn
        cmd.CommandText = "UPDATE city SET state=@s,city_name=@name,city_img=@cimg,city_about=@cabout WHERE city_id=@id"


        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        cmd.Parameters.AddWithValue("@id", cid)
        cmd.Parameters.AddWithValue("@s", cstate)
        cmd.Parameters.AddWithValue("@name", cname)
        cmd.Parameters.AddWithValue("@cabout", cabt)
        cmd.Parameters.Add("@cimg", MySqlDbType.Blob).Value = ms.ToArray

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error Message")
        End Try
        cmd.Parameters.Clear()
        My.Forms.UpdateCityPage.Close()
        My.Forms.homepage.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose image(*JPG;*PNG;*GIF)|*jpg;*png;*gif"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub UpdateCityPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "server = 10.50.45.158; userid=tushar; password=tushar.123; database=dbms;"
        cn.Open()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim rd As MySqlDataReader
        Dim cid As Integer
        cmd.Connection = cn
        cid = cityid.Text
        cmd.CommandText = "select * from city where city_id=@c_id  "

        cmd.Parameters.AddWithValue("@c_id", cid)
        rd = cmd.ExecuteReader
        If rd.Read Then
            state.Text = rd.GetString(1).ToUpper
            cityname.Text = rd.GetString(2).ToUpper
            cityabt.Text = rd.GetString(4)
            Dim byteImage() As Byte = rd("city_img")
            Dim pic As New System.IO.MemoryStream(byteImage)
            PictureBox1.Image = Image.FromStream(pic)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            cmd.Parameters.Clear()
            rd.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Forms.UpdateCityPage.Close()
        My.Forms.homepage.Show()
    End Sub
End Class