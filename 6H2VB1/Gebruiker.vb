Public Class Gebruiker
    'Declaratie van de instantievariabelen
    Private mType As Char
    Private mNummer As Integer
    Private mVoornaam, mFamilienaam As String
    Private mGeboortedatum As Date

    Public Sub New(ByVal type As Char, ByVal nummer As Integer, ByVal voornaam As String, ByVal familienaam As String, ByVal geboortedatum As Date)
        Me.Type = type
        Me.Nummer = nummer
        Me.Voornaam = voornaam
        Me.Familienaam = familienaam
        Me.Geboortedatum = geboortedatum

    End Sub

    Public Sub New()
        Me.Type = ""
        Me.Nummer = 0
        Me.Voornaam = ""
        Me.Familienaam = ""
        Me.Geboortedatum = Nothing

    End Sub

    Public Property Type() As Char
        Get
            Return mType
        End Get
        Set(value As Char)
            mType = value
        End Set
    End Property

    Public Property Nummer() As Integer
        Set(value As Integer)
            mNummer = value
        End Set
        Get
            Return mNummer
        End Get
    End Property

    Public Property Voornaam() As String
        Get
            Return mVoornaam
        End Get
        Set(value As String)
            mVoornaam = value
        End Set
    End Property

    Public Property Familienaam() As String
        Get
            Return mFamilienaam
        End Get
        Set(value As String)
            mFamilienaam = value
        End Set
    End Property

    Public Property Geboortedatum() As Date
        Get
            Return mGeboortedatum
        End Get
        Set(value As Date)
            mGeboortedatum = value
        End Set
    End Property

    Public Sub toonGegevens(ByVal teken As String)
        Dim uitvoer As String
        uitvoer = mType.ToString & teken & mNummer.ToString & teken & mVoornaam & teken & mFamilienaam & teken & mGeboortedatum.ToString

        MessageBox.Show(uitvoer, "Gegevens", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub toonGegevens()
        Dim uitvoer As String
        uitvoer = mType.ToString & "-" & mNummer.ToString & "-" & mVoornaam & "-" & mFamilienaam & "-" & mGeboortedatum.ToString

        MessageBox.Show(uitvoer, "Gegevens", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Function Naam() As String
        Return mVoornaam & " " & mFamilienaam
    End Function



End Class
