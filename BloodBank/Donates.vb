Imports Azure.Core.HttpHeader
Imports Microsoft.Data.SqlClient
Imports Microsoft.Identity.Client.Cache
Imports System.Drawing.Drawing2D

Public Class Donates
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sfaru\Documents\BloodDB.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub DisplayDonors()
        Con.Open()
        Dim query = "SELECT DName, DBGroup FROM DonorTbl"
        Dim adpter As SqlDataAdapter
        adpter = New SqlDataAdapter(query, Con)
        Dim builder = New SqlCommandBuilder(adpter)
        Dim ds As DataSet
        ds = New DataSet()
        adpter.Fill(ds)
        DonorsDGV.DataSource = ds.Tables(0)
        Con.Close()

    End Sub
    Private Sub DisplayBlood()
        Con.Open()
        Dim query = "SELECT * FROM BloodStockTbl"
        Dim adpter As SqlDataAdapter
        adpter = New SqlDataAdapter(query, Con)
        Dim builder = New SqlCommandBuilder(adpter)
        Dim ds As DataSet
        ds = New DataSet()
        adpter.Fill(ds)
        BloodStockDGV.DataSource = ds.Tables(0)
        Con.Close()

    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Dim OldStock
    Private Sub FetchQty()
        Con.Open()
        Dim query = "SELECT * FROM BloodStockTbl  WHERE BGroup='" & DBGroup.Text & "'"
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            OldStock = Convert.ToInt32(reader(2))
        End While
        Con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DonateBtn.Click
        If DName.Text = "" Or DBGroup.Text = "" Then
            MsgBox("Select A Donor")
        Else
            FetchQty()
            Dim NewStock As Integer
            NewStock = OldStock + 1
            Con.Open()
            Dim query = "update BloodStockTbl set BStock=" & NewStock & " WHERE BGroup='" & DBGroup.Text & "'"
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Blood Updated Successfully...")
            Con.Close()
            DisplayBlood()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub
    Dim Key As Integer

    Private Sub DonorsListDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DonorsDGV.CellMouseClick
        Dim row As DataGridViewRow = DonorsDGV.Rows(e.RowIndex)
        DName.Text = row.Cells(0).Value.ToString
        DBGroup.Text = row.Cells(1).Value.ToString

    End Sub

    Private Sub Donates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayDonors()
        DisplayBlood()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dashboard.Show()
        Donors.Hide()
        Transfers.Hide()
        Patients.Hide()
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dashboard.Hide()
        Donors.Show()
        Transfers.Hide()
        Patients.Hide()
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dashboard.Hide()
        Donors.Hide()
        Transfers.Hide()
        Patients.Show()
        Me.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dashboard.Hide()
        Donors.Hide()
        Transfers.Show()
        Patients.Hide()
        Me.Close()
    End Sub
End Class