Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Donors
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sfaru\Documents\BloodDB.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub DisplayDonors()
        Con.Open()
        Dim query = "select * from DonorTbl"
        Dim adpter As SqlDataAdapter
        adpter = New SqlDataAdapter(query, Con)
        Dim builder = New SqlCommandBuilder(adpter)
        Dim ds As DataSet
        ds = New DataSet()
        adpter.Fill(ds)
        DonorsDGV.DataSource = ds.Tables(0)
        Con.Close()

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Donors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayDonors()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles DName.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles DAge.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles DPhone.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles DAdd.TextChanged

    End Sub

    Private Sub Gender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DGend.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Try
            Con.Open()
            Dim query = "insert into DonorTbl(DName,DAge,DGend,DPhone,DBGroup,DAdd) values(@DName,@DAge,@DGend,@DPhone,@DBGroup,@DAdd)"

            Dim cmd As New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@DName", DName.Text)
            cmd.Parameters.AddWithValue("@DAge", DAge.Text)
            cmd.Parameters.AddWithValue("@DGend", DGend.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@DPhone", DPhone.Text)
            cmd.Parameters.AddWithValue("@DBGroup", DBGroup.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@DAdd", DAdd.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Donor Saved ..")
            Con.Close()
            DisplayDonors()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DonorsDGV.CellContentClick

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub DltBtn_Click(sender As Object, e As EventArgs) Handles DltBtn.Click
        If Key = 0 Then
            MsgBox("Select Donor to Delete.!")
        Else
            Con.Open()
            Dim cmd As SqlCommand
            Dim query = "delete from DonorTbl where Did=" & Key & " "
            cmd = New SqlCommand(query, Con)

            cmd.ExecuteNonQuery()
            MsgBox("Donor Deleted Successfully....")
            Con.Close()
            DisplayDonors()
        End If
    End Sub
    Dim Key As Integer
    Private Sub DonorsDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DonorsDGV.CellMouseClick
        Dim row As DataGridViewRow = DonorsDGV.Rows(e.RowIndex)
        DName.Text = row.Cells(1).Value.ToString
        DAge.Text = row.Cells(2).Value.ToString
        DPhone.Text = row.Cells(3).Value.ToString
        DGend.Text = row.Cells(4).Value.ToString
        DBGroup.Text = row.Cells(5).Value.ToString
        DAdd.Text = row.Cells(6).Value.ToString
        If DName.Text = "Donor Name " Or DName.Text = "" Then
            Key = 0
        Else
            Key = row.Cells(0).Value.ToString
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If Key = 0 Or DName.Text = "" Or DAge.Text = "" Or DPhone.Text = "" Or DAdd.Text = "" Then
            MsgBox("Incomplete Information")
        Else
            Con.Open()
            Dim query = "update DonorTbl set DName='" & DName.Text & "', DAge='" & DAge.Text & "', DGend='" & DGend.SelectedItem.ToString & "', DPhone='" & DPhone.Text & "', DBGroup='" & DBGroup.SelectedItem.ToString & "', DAdd='" & DAdd.Text & "' where DId='" & Key & "'"
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Updated Successfully...")
            Con.Close()
            DisplayDonors()
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Donates.Hide()
        Dashboard.Show()
        Transfers.Hide()
        Patients.Hide()
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Donates.Hide()
        Dashboard.Hide()
        Transfers.Hide()
        Patients.Show()
        Me.Close()
    End Sub

    Private Sub DonateLinkBtn_Click(sender As Object, e As EventArgs) Handles DonateLinkBtn.Click
        Donates.Show()
        Dashboard.Hide()
        Transfers.Hide()
        Patients.Hide()
        Me.Close()
    End Sub

    Private Sub TransferLinkBtn_Click(sender As Object, e As EventArgs) Handles TransferLinkBtn.Click
        Donates.Hide()
        Dashboard.Hide()
        Transfers.Show()
        Patients.Hide()
        Me.Close()
    End Sub
End Class