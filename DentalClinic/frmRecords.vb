Imports MySql.Data.MySqlClient
Public Class frmRecords

    Dim con As New MySqlConnection("server=localhost;username=root;password=;database=dentalclinic")
    Private Sub btnAddNewRecord_Click(sender As Object, e As EventArgs) Handles btnCreateNewRecord.Click
        frmAddNewRecord.ShowDialog()
        loaddatagrid()
    End Sub


    Private Sub frmRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddatagrid()
        Dim dgvbtn As New DataGridViewButtonColumn()
        dgvRecords.Columns.Add(dgvbtn)
        With dgvbtn
            .HeaderText = ""
            .Text = "EDIT"
            .Name = "btnEdit"
            .UseColumnTextForButtonValue = True
            .Width = 50
            .FlatStyle = FlatStyle.Flat
        End With
    End Sub


    Public Sub loaddatagrid()
        Dim table As DataTable

        Try
            Dim msda As New MySqlDataAdapter("select * from tblrecords", con)
            table = New DataTable
            msda.Fill(table)
            dgvRecords.DataSource = table
            'con.Open()
            '  MsgBox("OK")
            Dim column As DataGridViewColumn = dgvRecords.Columns(0)

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try



    End Sub

    Private Sub dgvRecords_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecords.CellContentClick
        If e.ColumnIndex = 5 Then
            MsgBox(dgvRecords.CurrentRow.Cells(0).Value)
        End If
    End Sub
End Class