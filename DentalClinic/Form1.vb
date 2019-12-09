Imports MySql.Data.MySqlClient

Public Class Form1
    Dim con As New MySqlConnection("server=localhost;username=root;password=;database=dentalclinic")

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If txtUsername.Text = Nothing Or txtPassword.Text = Nothing Then
                MsgBox("Fill the boxes", MsgBoxStyle.Exclamation)
            Else
                btnLogin.Text = "Logging in..."
                btnLogin.BackColor = Color.GreenYellow
                btnClose.Hide()

                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If

                Dim cmd As New MySqlCommand("Select count(*) from tblLogin where Username = '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'", con)
                Dim count = Convert.ToInt32(cmd.ExecuteScalar())

                If count > 0 Then
                    frmMainForm.Show()
                    Me.Hide()
                    LoginShowValidator()
                Else
                    LoginShowValidator()
                    MsgBox("Incorrect Username or Password", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception
            LoginShowValidator()
            MsgBox("Could not connect to server. Please try again later.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoginShowValidator()
        btnLogin.Text = "Login"
        btnLogin.BackColor = Color.DodgerBlue
        btnClose.Show()
    End Sub
    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub
End Class
