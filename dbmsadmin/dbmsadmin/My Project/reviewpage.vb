Imports MySql.Data.MySqlClient
Public Class reviewpage
    Dim cn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Public cur_report As String
    Private Sub reviewpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "server = 10.50.45.158; userid=tushar; password=tushar.123; database=dbms;"
        cn.Open()
        fetch_reports()
    End Sub

    Private Sub fetch_reports()
        Dim reader As MySqlDataReader
        Dim Item As String
        Dim report = "report"
        Dim n = "--------------------------------------------------xxxxxx--------------------------------------------"
        cmd.Connection = cn
        cmd.CommandText = "SELECT review FROM reviews where review_category=@rep order by rating ;"
        cmd.Parameters.AddWithValue("@rep", report)
        cmd.Prepare()
        reader = cmd.ExecuteReader()
        If reader.HasRows Then
            Do While reader.Read()
                Item = reader.Item("review")
                reviewbox.Items.Add(New ListViewItem(Item).Text)
                reviewbox.Items.Add(New ListViewItem(n).Text)
            Loop
        End If
        reader.Close()
        cn.Close()
    End Sub



    Private Sub reviewbox_DoubleClick(sender As Object, e As EventArgs) Handles reviewbox.DoubleClick
        Dim curItem As String = reviewbox.SelectedItem.ToString()
        cur_report = curItem
        My.Forms.resolvequerypage.Show()
        My.Forms.reviewpage.Close()

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        My.Forms.reviewpage.Close()
        My.Forms.homepage.Show()
    End Sub
End Class