<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRecords
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvRecords = New System.Windows.Forms.DataGridView()
        Me.pnlDesign = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCreateNewRecord = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDesign.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvRecords
        '
        Me.dgvRecords.AllowUserToAddRows = False
        Me.dgvRecords.AllowUserToDeleteRows = False
        Me.dgvRecords.AllowUserToResizeColumns = False
        Me.dgvRecords.AllowUserToResizeRows = False
        Me.dgvRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRecords.BackgroundColor = System.Drawing.Color.LightCyan
        Me.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecords.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvRecords.GridColor = System.Drawing.Color.White
        Me.dgvRecords.Location = New System.Drawing.Point(0, 46)
        Me.dgvRecords.MultiSelect = False
        Me.dgvRecords.Name = "dgvRecords"
        Me.dgvRecords.ReadOnly = True
        Me.dgvRecords.RowHeadersVisible = False
        Me.dgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecords.Size = New System.Drawing.Size(1247, 553)
        Me.dgvRecords.TabIndex = 0
        '
        'pnlDesign
        '
        Me.pnlDesign.BackColor = System.Drawing.Color.White
        Me.pnlDesign.Controls.Add(Me.Label1)
        Me.pnlDesign.Controls.Add(Me.btnCreateNewRecord)
        Me.pnlDesign.Controls.Add(Me.ComboBox1)
        Me.pnlDesign.Controls.Add(Me.txtSearch)
        Me.pnlDesign.Location = New System.Drawing.Point(0, 0)
        Me.pnlDesign.Name = "pnlDesign"
        Me.pnlDesign.Size = New System.Drawing.Size(1247, 47)
        Me.pnlDesign.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(141, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SEARCH BY"
        '
        'btnCreateNewRecord
        '
        Me.btnCreateNewRecord.BackColor = System.Drawing.Color.LimeGreen
        Me.btnCreateNewRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCreateNewRecord.FlatAppearance.BorderSize = 0
        Me.btnCreateNewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateNewRecord.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateNewRecord.ForeColor = System.Drawing.Color.White
        Me.btnCreateNewRecord.Location = New System.Drawing.Point(12, 12)
        Me.btnCreateNewRecord.Name = "btnCreateNewRecord"
        Me.btnCreateNewRecord.Size = New System.Drawing.Size(93, 28)
        Me.btnCreateNewRecord.TabIndex = 3
        Me.btnCreateNewRecord.Text = "Create New"
        Me.btnCreateNewRecord.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(217, 18)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(137, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(372, 19)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(237, 21)
        Me.txtSearch.TabIndex = 0
        '
        'frmRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 599)
        Me.Controls.Add(Me.dgvRecords)
        Me.Controls.Add(Me.pnlDesign)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRecords"
        Me.Text = "frmRecords"
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDesign.ResumeLayout(False)
        Me.pnlDesign.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvRecords As DataGridView
    Friend WithEvents pnlDesign As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnCreateNewRecord As Button
End Class
