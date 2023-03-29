Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Donates.Hide()
        Donors.Show()
        Transfers.Hide()
        Patients.Hide()
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Donates.Hide()
        Donors.Hide()
        Transfers.Hide()
        Patients.Show()
        Me.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Donates.Show()
        Donors.Hide()
        Transfers.Hide()
        Patients.Hide()
        Me.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Donates.Hide()
        Donors.Hide()
        Transfers.Show()
        Patients.Hide()
        Me.Close()
    End Sub
End Class