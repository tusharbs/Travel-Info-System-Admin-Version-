Imports MySql.Data.MySqlClient
Imports System.IO
Public Class AddPlacePage
    Dim cmd As New MySqlCommand
    Dim cn As New MySqlConnection
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose image(*JPG;*PNG;*GIF)|*jpg;*png;*gif"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub AddPlacePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "server = 10.50.45.158; userid=tushar; password=tushar.123; database=dbms;"
        cn.Open()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
        Try
            pcat = category.Text
            cname = cityname.Text
            pid = placeid.Text
            temp = avgratings.Text
            pname = placename.Text
            pabt = placeabout.Text
            pweb = website.Text
            pexp = expense.Text
            ptimings = placetimings.Text
            pavgrating = System.Convert.ToDecimal(temp)
            pphone = phone.Text
            prevno = reviewno.Text
            padd = placeaddress.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error Message")
        End Try
        Dim ms As New MemoryStream

        cmd.Connection = cn


        cmd.CommandText = "Insert into places(place_id,city_name,category,place_name,place_img,place_about,place_timings,expense,avg_rating,address,phone,website,review_number) values(@id,@cn,@cat,@pn,@pimg,@abt,@timings,@exp,@avgrat,@add,@ph,@web,@rno) "


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
        My.Forms.AddPlacePage.Close()
        My.Forms.homepage.Show()

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Forms.AddPlacePage.Close()
        My.Forms.homepage.Show()
    End Sub
End Class