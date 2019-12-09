Public Class frmMainForm

    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub frmMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchPanel(frmDashboard)
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        switchPanel(frmDashboard)
    End Sub

    Private Sub RecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecordsToolStripMenuItem.Click
        switchPanel(frmRecords)
    End Sub

    Private Sub pbxCancel_Click(sender As Object, e As EventArgs) Handles pbxCancel.Click
        Application.Exit()
    End Sub
End Class