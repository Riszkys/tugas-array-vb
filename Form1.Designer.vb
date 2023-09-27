<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        txtnama = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtNIM = New TextBox()
        TextBox1 = New TextBox()
        cbokelamin = New ComboBox()
        cboprodi = New ComboBox()
        btnproses = New Button()
        List1 = New ListView()
        btnhapus = New Button()
        btnedit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(42, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 15)
        Label1.TabIndex = 0
        Label1.Text = "NPM"
        ' 
        ' txtnama
        ' 
        txtnama.AutoSize = True
        txtnama.Location = New Point(42, 56)
        txtnama.Name = "txtnama"
        txtnama.Size = New Size(43, 15)
        txtnama.TabIndex = 1
        txtnama.Text = "NAMA"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(42, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 15)
        Label3.TabIndex = 2
        Label3.Text = "JENIS KELAMIN"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(42, 134)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 15)
        Label4.TabIndex = 3
        Label4.Text = "PROGRAM STUDI"
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(149, 19)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(325, 23)
        txtNIM.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(149, 48)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(325, 23)
        TextBox1.TabIndex = 5
        ' 
        ' cbokelamin
        ' 
        cbokelamin.FormattingEnabled = True
        cbokelamin.Location = New Point(149, 89)
        cbokelamin.Name = "cbokelamin"
        cbokelamin.Size = New Size(315, 23)
        cbokelamin.TabIndex = 6
        ' 
        ' cboprodi
        ' 
        cboprodi.FormattingEnabled = True
        cboprodi.Location = New Point(149, 126)
        cboprodi.Name = "cboprodi"
        cboprodi.Size = New Size(315, 23)
        cboprodi.TabIndex = 7
        ' 
        ' btnproses
        ' 
        btnproses.Location = New Point(583, 125)
        btnproses.Name = "btnproses"
        btnproses.Size = New Size(100, 32)
        btnproses.TabIndex = 8
        btnproses.Text = "Proses"
        btnproses.UseVisualStyleBackColor = True
        ' 
        ' List1
        ' 
        List1.Anchor = AnchorStyles.Bottom
        List1.Location = New Point(12, 182)
        List1.Name = "List1"
        List1.Size = New Size(779, 168)
        List1.TabIndex = 9
        List1.UseCompatibleStateImageBehavior = False
        ' 
        ' btnhapus
        ' 
        btnhapus.Location = New Point(498, 130)
        btnhapus.Name = "btnhapus"
        btnhapus.Size = New Size(79, 27)
        btnhapus.TabIndex = 10
        btnhapus.Text = "Hapus"
        btnhapus.UseVisualStyleBackColor = True
        ' 
        ' btnedit
        ' 
        btnedit.Location = New Point(703, 128)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(79, 27)
        btnedit.TabIndex = 10
        btnedit.Text = "edit"
        btnedit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnedit)
        Controls.Add(btnhapus)
        Controls.Add(List1)
        Controls.Add(btnproses)
        Controls.Add(cboprodi)
        Controls.Add(cbokelamin)
        Controls.Add(TextBox1)
        Controls.Add(txtNIM)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtnama)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Array Multidimensi"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtnama As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cbokelamin As ComboBox
    Friend WithEvents cboprodi As ComboBox
    Friend WithEvents btnproses As Button
    Friend WithEvents List1 As ListView
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnedit As Button
End Class
