<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnOpslaan = New System.Windows.Forms.Button()
        Me.btnToon = New System.Windows.Forms.Button()
        Me.btnNaam = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNummer = New System.Windows.Forms.TextBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.txtGeboortedatum = New System.Windows.Forms.TextBox()
        Me.txtFamilienaam = New System.Windows.Forms.TextBox()
        Me.txtVoornaam = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnOpslaan
        '
        Me.btnOpslaan.Location = New System.Drawing.Point(40, 322)
        Me.btnOpslaan.Name = "btnOpslaan"
        Me.btnOpslaan.Size = New System.Drawing.Size(218, 27)
        Me.btnOpslaan.TabIndex = 0
        Me.btnOpslaan.Text = "Opslaan"
        Me.btnOpslaan.UseVisualStyleBackColor = True
        '
        'btnToon
        '
        Me.btnToon.Location = New System.Drawing.Point(40, 370)
        Me.btnToon.Name = "btnToon"
        Me.btnToon.Size = New System.Drawing.Size(218, 27)
        Me.btnToon.TabIndex = 1
        Me.btnToon.Text = "Gegevens"
        Me.btnToon.UseVisualStyleBackColor = True
        '
        'btnNaam
        '
        Me.btnNaam.Location = New System.Drawing.Point(40, 414)
        Me.btnNaam.Name = "btnNaam"
        Me.btnNaam.Size = New System.Drawing.Size(218, 27)
        Me.btnNaam.TabIndex = 2
        Me.btnNaam.Text = "Naam"
        Me.btnNaam.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Type: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nummer:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Voornaam: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Familienaam: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Geboortedatum: "
        '
        'txtNummer
        '
        Me.txtNummer.Location = New System.Drawing.Point(165, 99)
        Me.txtNummer.Name = "txtNummer"
        Me.txtNummer.Size = New System.Drawing.Size(167, 20)
        Me.txtNummer.TabIndex = 8
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"S", "P"})
        Me.cboType.Location = New System.Drawing.Point(165, 47)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(121, 21)
        Me.cboType.TabIndex = 9
        '
        'txtGeboortedatum
        '
        Me.txtGeboortedatum.Location = New System.Drawing.Point(165, 249)
        Me.txtGeboortedatum.Name = "txtGeboortedatum"
        Me.txtGeboortedatum.Size = New System.Drawing.Size(167, 20)
        Me.txtGeboortedatum.TabIndex = 10
        '
        'txtFamilienaam
        '
        Me.txtFamilienaam.Location = New System.Drawing.Point(165, 198)
        Me.txtFamilienaam.Name = "txtFamilienaam"
        Me.txtFamilienaam.Size = New System.Drawing.Size(167, 20)
        Me.txtFamilienaam.TabIndex = 11
        '
        'txtVoornaam
        '
        Me.txtVoornaam.Location = New System.Drawing.Point(165, 148)
        Me.txtVoornaam.Name = "txtVoornaam"
        Me.txtVoornaam.Size = New System.Drawing.Size(167, 20)
        Me.txtVoornaam.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 509)
        Me.Controls.Add(Me.txtVoornaam)
        Me.Controls.Add(Me.txtFamilienaam)
        Me.Controls.Add(Me.txtGeboortedatum)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.txtNummer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNaam)
        Me.Controls.Add(Me.btnToon)
        Me.Controls.Add(Me.btnOpslaan)
        Me.Name = "Form1"
        Me.Text = "Test klasse gebruiker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOpslaan As Button
    Friend WithEvents btnToon As Button
    Friend WithEvents btnNaam As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNummer As TextBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents txtGeboortedatum As TextBox
    Friend WithEvents txtFamilienaam As TextBox
    Friend WithEvents txtVoornaam As TextBox
End Class
