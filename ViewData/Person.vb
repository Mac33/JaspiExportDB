Imports System.Collections.Generic

Public Class Person
    Public Property EVC As String = String.Empty
    Public Property Meno As String = String.Empty
    Private Property Priezvisko As String = String.Empty
    Private Property TitulPred As String = String.Empty
    Private Property TitulZa As String = String.Empty
    Public Property Odbory As New List(Of Department)
    Public Property Odvetvia As New List(Of Sections)
    Public Property DenZapisu As Date = Nothing
    Private paDenVyciarknutia As Date = Nothing
    Public Property DenVyciarknutia As Date
        Get
            If Me.paDenVyciarknutia.Year = 1 Then
                Me.paDenVyciarknutia = New Date(1800, 1, 1, 0, 0, 0)
            End If
            Return Me.paDenVyciarknutia
        End Get
        Set(value As Date)
            Me.paDenVyciarknutia = value
        End Set
    End Property
    Public Property Fax As String
    Public Property Tel As String
    Public Property Mobil As String
    Public Property Email As String
    Public Property Active As Boolean = True
    Public Property Adresa As String
    Public Property Internet As String = String.Empty


    Public ReadOnly Property Is370901 As Boolean
        Get
            For Each item As Sections In Me.Odvetvia
                If item.Number = "370901" Then
                    Return True
                End If
            Next
            Return False
        End Get
    End Property


    Public ReadOnly Property Is020000 As Boolean
        Get
            For Each item As Department In Me.Odbory
                If item.Number = "020000" Then
                    Return True
                End If
            Next
            Return False
        End Get
    End Property



    Public ReadOnly Property Is030000 As Boolean
        Get
            For Each item As Department In Me.Odbory
                If item.Number = "030000" Then
                    Return True
                End If
            Next
            Return False
        End Get
    End Property



    Public ReadOnly Property Is100000 As Boolean
        Get
            For Each item As Department In Me.Odbory
                If item.Number = "100000" Then
                    Return True
                End If
            Next
            Return False
        End Get
    End Property


    Public ReadOnly Property Is270000 As Boolean
        Get
            For Each item As Department In Me.Odbory
                If item.Number = "270000" Then
                    Return True
                End If
            Next
            Return False
        End Get
    End Property



    Public ReadOnly Property Is290000 As Boolean
        Get
            For Each item As Department In Me.Odbory
                If item.Number = "290000" Then
                    Return True
                End If
            Next
            Return False
        End Get
    End Property



    Public ReadOnly Property Is390000 As Boolean
        Get
            For Each item As Department In Me.Odbory
                If item.Number = "390000" Then
                    Return True
                End If
            Next
            Return False
        End Get
    End Property


    Public ReadOnly Property SuperSelect As Boolean
        Get
            If Me.Active AndAlso (Me.Is020000 OrElse Me.Is030000 OrElse Me.Is100000 OrElse Me.Is270000 OrElse Me.Is290000 OrElse Is390000) Then
                Return True
            End If
            Return False
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return String.Format("{0}, {1}, {2}, {3}", Me.Meno, Me.Adresa, Me.Tel, Me.Active)
    End Function

End Class


Public Class Department
    Public Property Name As String = String.Empty
    Public Property Number As String = String.Empty

    Public Overrides Function ToString() As String
        Return Number + " " + Name
    End Function
End Class

Public Class Sections
    Public Property Name As String = String.Empty
    Public Property Number As String = String.Empty

    Public Overrides Function ToString() As String
        Return Number + " " + Name
    End Function
End Class