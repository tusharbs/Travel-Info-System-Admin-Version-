Imports MySql.Data.MySqlClient
Imports System.IO


Public Class ImagesPage
    Dim cn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim cur_pid As Int16
    Private Sub ImagesPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "server = 10.50.45.158; userid=tushar; password=tushar.123; database=dbms;"
        cn.Open()
        cur_pid = My.Forms.UpdatePlacePage.placeid.Text
        populate_images()
    End Sub
    Private Sub populate_images()
        Dim reader As MySqlDataReader
        Dim Item As String

        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM pictures where place_id = @pid ;"
        cmd.Parameters.AddWithValue("@pid", cur_pid)

        cmd.Prepare()
        reader = cmd.ExecuteReader()
        If reader.HasRows Then
            Do While reader.Read()
                Item = reader.GetString(0)
                imagelist.Items.Add(New ListViewItem(Item).Text)

            Loop
        End If
        reader.Close()
    End Sub

    Private Sub imagelist_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles imagelist.MouseDoubleClick
        Dim reader As MySqlDataReader
        cmd.Connection = cn
        Dim cur_uid As String
        Try
            cur_uid = imagelist.SelectedItem.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error Message")
        End Try

        cmd.CommandText = "SELECT picture FROM pictures where place_id = @piid and userid=@uid;"
        cmd.Parameters.AddWithValue("@piid", cur_pid)
        cmd.Parameters.AddWithValue("@uid", cur_uid)
        reader = cmd.ExecuteReader
        While reader.Read
            Dim byteImage() As Byte = reader("picture")
            Dim pic As New System.IO.MemoryStream(byteImage)
            imagebox.Image = Image.FromStream(pic)
            imagebox.SizeMode = PictureBoxSizeMode.Zoom
        End While
        reader.Close()
        cmd.Parameters.Clear()
    End Sub
End Class