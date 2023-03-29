Imports Microsoft.Data.SqlClient

Public Class Transfers
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sfaru\Documents\BloodDB.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub GetPatinets()
        Con.Open()
        Dim Sql = "select * from PatientTbl "
        Dim cmd As New SqlCommand(Sql, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        PatientId.DataSource = Tbl
        PatientId.DisplayMember = "PId"
        PatientId.ValueMember = "PId"
        Con.Close()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles PatientBGroup.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles PatientName.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
    Dim AvailableStock As Integer
    Private Sub FetchQty()
        Con.Open()
        Dim query = "SELECT * FROM BloodStockTbl  WHERE BGroup='" & PatientBGroup.Text & "'"
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            AvailableStock = Convert.ToInt32(reader(2))
        End While
        Con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles TransferBtn.Click

    End Sub

    Private Sub Transfers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetPatinets()
    End Sub
    Private Sub GetData()
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If

        Dim query = "select * from PatientTbl where PId=" & PatientId.SelectedValue.ToString() & ""
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            PatientName.Text = reader(1).ToString()
            PatientBGroup.Text = reader(5).ToString()
        End While
        Con.Close()
    End Sub
    Private Sub PatientId_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles PatientId.SelectionChangeCommitted
        GetData()
        FetchQty()
        If AvailableStock = 0 Then
            Available.Text = "No Blood Available"
        Else
            Available.Text = AvailableStock
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles DashboardLinkBtn.Click
        Dashboard.Show()
        Donors.Hide()
        Donates.Hide()
        Patients.Hide()
        Me.Close()
    End Sub

    Private Sub DonorsLinkBtn_Click(sender As Object, e As EventArgs) Handles DonorsLinkBtn.Click
        Dashboard.Hide()
        Donors.Show()
        Donates.Hide()
        Patients.Hide()
        Me.Close()
    End Sub

    Private Sub PatientLinkBtn_Click(sender As Object, e As EventArgs) Handles PatientLinkBtn.Click
        Dashboard.Hide()
        Donors.Hide()
        Donates.Hide()
        Patients.Show()
        Me.Close()
    End Sub

    Private Sub DonateLinkBtn_Click(sender As Object, e As EventArgs) Handles DonateLinkBtn.Click
        Dashboard.Hide()
        Donors.Hide()
        Donates.Show()
        Patients.Hide()
        Me.Close()
    End Sub
End Class