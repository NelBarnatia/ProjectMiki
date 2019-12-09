Imports MySql.Data.MySqlClient

Public Class Form1

    'Testing Commit
    Dim con As New MySqlConnection("server=localhost;username=root;password=;database=dentalclinic")
    'Testing Commit
    'Testing Commit

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = Nothing Or txtPassword.Text = Nothing Then
            MsgBox("Fill the boxes", MsgBoxStyle.Exclamation)

        Else
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim cmd As New MySqlCommand("Select count(*) from tblLogin where Username = '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'", con)
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                frmMainForm.Show()
                Me.Hide()

            Else
                MsgBox("Incorrect Username or Password", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtPassword_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class
