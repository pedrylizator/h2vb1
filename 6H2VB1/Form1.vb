Public Class Form1

    Dim g As New Gebruiker

    Private Sub btnOpslaan_Click(sender As Object, e As EventArgs) Handles btnOpslaan.Click
        g.Type = cboType.Text
        g.Nummer = CInt(txtNummer.Text)
        g.Voornaam = txtVoornaam.Text
        g.Familienaam = txtFamilienaam.Text
        g.Geboortedatum = CDate(txtGeboortedatum.Text)
    End Sub

    Private Sub btnToon_Click(sender As Object, e As EventArgs) Handles btnToon.Click
        Dim teken As String
        teken = InputBox("Geef een scheidingsteken in", "Scheidingsteken", "-")

        If teken = "" Then
            g.toonGegevens()
        Else
            g.toonGegevens(teken)
        End If

    End Sub

    Private Sub btnNaam_Click(sender As Object, e As EventArgs) Handles btnNaam.Click
        MessageBox.Show(g.Naam())
    End Sub
End Class
