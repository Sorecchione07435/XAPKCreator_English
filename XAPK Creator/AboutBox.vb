Public Class AboutBox

    Private Sub AboutBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = My.Application.Info.AssemblyName
        Label2.Text = My.Application.Info.Version.ToString
        Label3.Text = My.Application.Info.CompanyName
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class