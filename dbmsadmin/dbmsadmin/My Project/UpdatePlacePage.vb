Imports MySql.Data.MySqlClient
Imports System.IO

Public Class UpdatePlacePage
    Dim cmd As New MySqlCommand
    Dim cn As New MySqlConnection
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub UpdatePlacePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "server = 10.50.45.158; userid=tushar; password=tushar.123; database=dbms;"
        cn.Open()
    End Sub

    Private Sub Check_Click(sender As Object, e As EventArgs) Handles Check.Click
        Dim rd As MySqlDataReader
        Dim pid As Integer
        cmd.Connection = cn
        pid = placeid.Text
        cmd.CommandText = "select * from places where place_id=@p_id  "

        cmd.Parameters.AddWithValue("@p_id", pid)
        rd = cmd.ExecuteReader
        If rd.Read Then
            cityname.Text = rd.GetString(10).ToUpper
            category.Text = rd.GetString(1)
            placename.Text = rd.GetString(11).ToUpper
            placeabout.Text = rd.GetString(3)
            placetimings.Text = rd.GetString(4)
            expense.Text = rd.GetInt32(5)
            averageratings.Text = rd.GetString(6)
            placeaddress.Text = rd.GetString(8)
            phone.Text = rd.GetString(9)
            website.Text = rd.GetString(12)
            reviewnumber.Text = rd.GetString(7)

            Dim byteImage() As Byte = rd("place_img")
            Dim pic As New System.IO.MemoryStream(byteImage)
            PictureBox1.Image = Image.FromStream(pic)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            rd.Close()
        End If
        cmd.Parameters.Clear()
    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose image(*JPG;*PNG;*GIF)|*jpg;*png;*gif"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub category_TextChanged(sender As Object, e As EventArgs) Handles category.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pid As New Integer
        Dim cname As String
        Dim pname As String
        Dim pabt As String
        Dim pweb As String
        Dim pexp As Integer
        Dim ptimings As String
        Dim pavgrating As Decimal
        Dim pphone As String
        Dim prevno As Integer
        Dim padd As String
        Dim pcat As String
        Dim temp As String
        pcat = category.Text
        cname = cityname.Text.ToLower
        pid = placeid.Text
        temp = averageratings.Text
        pname = placename.Text.ToLower
        pabt = placeabout.Text
        pweb = website.Text
        pexp = expense.Text
        ptimings = placetimings.Text
        pavgrating = System.Convert.ToDecimal(temp)
        pphone = phone.Text
        prevno = reviewnumber.Text
        padd = placeaddress.Text


        Dim ms As New MemoryStream

        cmd.Connection = cn
        cmd.CommandText = "UPDATE places SET city_name=@cn,category=@cat,place_name=@pn,place_img=@pimg,place_about=@abt,place_timings=@timings,expense=@exp,avg_rating=@avgrat,address=@add,phone=@ph,website=@web,review_number=@rno where place_id=@id "


        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        cmd.Parameters.AddWithValue("@id", pid)
        cmd.Parameters.AddWithValue("@cn", cname)
        cmd.Parameters.AddWithValue("@cat", pcat)
        cmd.Parameters.AddWithValue("@pn", pname)
        cmd.Parameters.AddWithValue("@abt", pabt)
        cmd.Parameters.AddWithValue("@timings", ptimings)
        cmd.Parameters.AddWithValue("@exp", pexp)
        cmd.Parameters.AddWithValue("@avgrat", pavgrating)
        cmd.Parameters.AddWithValue("@add", padd)
        cmd.Parameters.AddWithValue("@ph", pphone)
        cmd.Parameters.AddWithValue("@web", pweb)
        cmd.Parameters.AddWithValue("@rno", prevno)


        cmd.Parameters.Add("@pimg", MySqlDbType.Blob).Value = ms.ToArray

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error Message")
        End Try
        cmd.Parameters.Clear()
        My.Forms.UpdatePlacePage.Close()
        My.Forms.homepage.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Forms.UpdatePlacePage.Close()
        My.Forms.homepage.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        My.Forms.ImagesPage.Show()
    End Sub
End Class