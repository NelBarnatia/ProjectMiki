Imports MySql.Data.MySqlClient

Public Class frmAddNewRecord
    Dim con As New MySqlConnection("server=localhost;username=root;password=;database=dentalclinic")

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim cmd As New MySqlCommand("INSERT INTO `tblrecords`(`PatientName`, `Treatment`, `DateOfVisit`) VALUES ('" + txtNameOfPatient.Text + "', '" + txtTreatment.Text + "', '" + dtpDateOfVisit.Text + "')", con)

        If cmd.ExecuteNonQuery() = 1 Then
            MsgBox("Record added", MsgBoxStyle.Information, "Record")

            txtNameOfPatient.Text = ""
            txtPayment.Text = ""
            txtTreatment.Text = ""

            Me.Close()
        Else
            MsgBox("Database Error")
        End If

    End Sub

End Class