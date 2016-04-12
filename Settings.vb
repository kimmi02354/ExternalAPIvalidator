Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.txtServerLink.Text = My.Settings.ServerLink
        Me.txtTimeOut.Text = My.Settings.timeOutValue
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.ServerLink = Me.txtServerLink.Text
        My.Settings.timeOutValue = Me.txtTimeOut.Text
        My.Settings.Save()

        MsgBox("Saved")
    End Sub
End Class