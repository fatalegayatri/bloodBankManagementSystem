Imports Azure.Core.HttpHeader
Imports System.Drawing.Drawing2D
Imports Microsoft.Data.SqlClient
Imports Microsoft.Identity.Client.Cache

Public Class Patients
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sfaru\Documents\BloodDB.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub DisplayPatients()
        Con.Open()
        Dim query = "select * from PatientTbl"
        Dim adpter As SqlDataAdapter
        adpter = New SqlDataAdapter(query, Con)
        Dim builder = New SqlCommandBuilder(adpter)
        Dim ds As DataSet
        ds = New DataSet()
        adpter.Fill(ds)
        PatientsDGV.DataSource = ds.Tables(0)
        Con.Close()

    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Try
            Con.Open()
            Dim query = "insert into PatientTbl(PName,PAge,PGender,PPhone,PBloodGroup,PAddress) values(@PName,@PAge,@PGender,@PPhone,@PBloodGroup,@PAddress)"

            Dim cmd As New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@PName", PName.Text)
            cmd.Parameters.AddWithValue("@PAge", PAge.Text)
            cmd.Parameters.AddWithValue("@PGender", PGender.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@PPhone", PPhone.Text)
            cmd.Parameters.AddWithValue("@PBloodGroup", PBloodGroup.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@PAddress", PAddress.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Patient Saved...")
            Con.Close()
            DisplayPatients()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Patients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayPatients()
    End Sub

    Private Sub DelBtn_Click(sender As Object, e As EventArgs) Handles DelBtn.Click
        If Key = 0 Then
            MsgBox("Select Patient to Delete.!")
        Else
            Con.Open()
            Dim cmd As SqlCommand
            Dim query = "delete from PatientTbl where PId=" & Key & " "
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Patient Deleted Successfully....")
            Con.Close()
            DisplayPatients()
        End If
    End Sub
    Dim Key As Integer
    Private Sub PatientsDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles PatientsDGV.CellMouseClick
        Dim row As DataGridViewRow = PatientsDGV.Rows(e.RowIndex)
        PName.Text = row.Cells(1).Value.ToString
        PAge.Text = row.Cells(2).Value.ToString
        PPhone.Text = row.Cells(3).Value.ToString
        PGender.Text = row.Cells(4).Value.ToString
        PBloodGroup.Text = row.Cells(5).Value.ToString
        PAddress.Text = row.Cells(6).Value.ToString
        If PName.Text = "Patient Name " Or PName.Text = "" Then
            Key = 0
        Else
            Key = row.Cells(0).Value.ToString
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If Key = 0 Or PName.Text = "" Or PAge.Text = "" Or PPhone.Text = "" Or PAddress.Text = "" Then
            MsgBox("Incomplete Information")
        Else
            Con.Open()
            Dim query = "update PatientTbl set PName='" & PName.Text & "', PAge='" & PAge.Text & "', PGender='" & PGender.SelectedItem.ToString & "', PPhone='" & PPhone.Text & "', PBloodGroup='" & PBloodGroup.SelectedItem.ToString & "', PAddress='" & PAddress.Text & "' where PId='" & Key & "'"
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Updated Successfully...")
            Con.Close()
            DisplayPatients()
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Donates.Hide()
        Dashboard.Show()
        Transfers.Hide()
        Donors.Hide()
        Me.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Donates.Show()
        Dashboard.Hide()
        Transfers.Hide()
        Donors.Hide()
        Me.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Donates.Hide()
        Dashboard.Hide()
        Transfers.Show()
        Donors.Hide()
        Me.Close()
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Donates.Hide()
        Dashboard.Hide()
        Transfers.Hide()
        Donors.Show()
        Me.Close()
    End Sub
End Class