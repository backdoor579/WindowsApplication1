<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlistSupplier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblKataKunci = New System.Windows.Forms.Label()
        Me.txtKataKunci = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbUrut = New System.Windows.Forms.ComboBox()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.dgvSupplier = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblKataKunci
        '
        Me.lblKataKunci.AutoSize = True
        Me.lblKataKunci.Location = New System.Drawing.Point(66, 80)
        Me.lblKataKunci.Name = "lblKataKunci"
        Me.lblKataKunci.Size = New System.Drawing.Size(65, 13)
        Me.lblKataKunci.TabIndex = 0
        Me.lblKataKunci.Text = "Kata Kunci :"
        '
        'txtKataKunci
        '
        Me.txtKataKunci.Location = New System.Drawing.Point(149, 76)
        Me.txtKataKunci.Name = "txtKataKunci"
        Me.txtKataKunci.Size = New System.Drawing.Size(452, 20)
        Me.txtKataKunci.TabIndex = 1
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(622, 76)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(39, 20)
        Me.btnCari.TabIndex = 2
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(670, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 20)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Urutkan Berdasarkan :"
        '
        'cmbUrut
        '
        Me.cmbUrut.FormattingEnabled = True
        Me.cmbUrut.Location = New System.Drawing.Point(149, 111)
        Me.cmbUrut.Name = "cmbUrut"
        Me.cmbUrut.Size = New System.Drawing.Size(125, 21)
        Me.cmbUrut.TabIndex = 6
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(282, 111)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(37, 21)
        Me.btnSort.TabIndex = 7
        Me.btnSort.Text = "Start"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'dgvSupplier
        '
        Me.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSupplier.Location = New System.Drawing.Point(26, 153)
        Me.dgvSupplier.Name = "dgvSupplier"
        Me.dgvSupplier.Size = New System.Drawing.Size(708, 223)
        Me.dgvSupplier.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(149, 382)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 21)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Tambah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(220, 382)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(41, 21)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(271, 382)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(49, 21)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Hapus"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(670, 382)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(49, 21)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "Tutup"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'frmlistSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgvSupplier)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.cmbUrut)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtKataKunci)
        Me.Controls.Add(Me.lblKataKunci)
        Me.Name = "frmlistSupplier"
        Me.Text = "Daftar Supplier"
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblKataKunci As Label
    Friend WithEvents txtKataKunci As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbUrut As ComboBox
    Friend WithEvents btnSort As Button
    Friend WithEvents dgvSupplier As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
