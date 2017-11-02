Imports MySql.Data.MySqlClient
Public Class resolvequerypage
    Dim cn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Private Sub resolvequerypage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim report As String
        Dim rd As MySqlDataReader
        cn.ConnectionString = "server = 10.50.45.158; userid=tushar; password=tushar.123; database=dbms;"
        cn.Open()
        report = My.Forms.reviewpage.cur_report
        cmd.Connection = cn
        cmd.CommandText = "select * from reviews where review=@r"
        cmd.Parameters.AddWithValue("@r", report)
        rd = cmd.ExecuteReader()

        If rd.Read() Then
            placeidLabel.Text = rd.GetInt32("place_id")
            Label3.Text = rd.GetString("review")
            Label5.Text = rd.GetString("place_name")
            Label7.Text = rd.GetString("user_id")
            Label9.Text = rd.GetInt32("rating")
        End If
        rd.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub placeidLabel_Click(sender As Object, e As EventArgs) Handles placeidLabel.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd.CommandText = "DELETE FROM reviews WHERE review=@rev"
        cmd.Parameters.AddWithValue("@rev", Label3.Text)
        cmd.ExecuteNonQuery()
        My.Forms.UpdatePlacePage.placeid.Text = placeidLabel.Text
        My.Forms.UpdatePlacePage.Show()
        cn.Close()
        My.Forms.resolvequerypage.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class