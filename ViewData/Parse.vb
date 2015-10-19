Imports System.Collections.Generic
Imports System.IO
Imports System
Imports System.Text


Public Class Parse
    Private paPersons As List(Of Person) = Nothing
    Private paFileName As String = String.Empty
    Private paTitul() As String = {"DSc.", "Th.D.", "DrSc.", "ThMgr.", "ThLic.", "ThDr.", "RTDr.", "RCDr.", "RSDr.", "PhMr.",
                              "PharmDr.", "MVDr.", "MUDr.", "MSDr.", "MDDr.", "ICDr.", "Ing. arch.", "MgA.", "BcA.",
                              "JUDr.", "PhDr.", "BSBA", "M.A.", "Doc.", "PaedDr.", "Dr.", "PhD.", "Mgr.", "Ing.", "Bc.",
                              "Prof.", "CSs.", "RNDr."}

    Const evc As String = "<b>Evidenčné číslo:</b><bezc>"
    Const endSection As String = "<b>Výpis zo dňa:</b>"
    Const name As String = "<b>Meno, priezvisko,    </b>"
    Const address As String = "<b>Trvalý/obdobný pobyt:</b><sid>"
    Const dayIn As String = "<b>Deň zápisu:</b>          <pravopl>"
    Const dayOut As String = "<b>Deň vyčiarknutia:</b>"
    Const deparment1 As String = "<b>Odbory a odvetvia:   </b>Odbor:"
    Const deparment2 As String = "                     Odbor:"
    Const depOut As String = "<b>Vyčiarknuté odbory a odvetvia:</b>"
    Const section As String = "                     Odvetvie:"
    Const mobil As String = "mobil:"
    Const mail As String = "mail:"
    Const tel As String = "tel.:"
    Const fax As String = "fax:"
    Const organization As String = "<b>Názov/obchodné meno: </b>"



    Public Sub New(ByVal file As String)
        Me.paFileName = file
        Me.paPersons = New List(Of Person)
    End Sub


    Public Property FilterSimilar As Boolean = False


    Public ReadOnly Property Persons As List(Of Person)
        Get
            Return Me.paPersons
        End Get
    End Property



    Public Function Parse() As List(Of Person)

        If String.IsNullOrEmpty(paFileName) Then
            Return Nothing
        End If
        Me.paPersons.Clear()
        Me.Parse(paFileName)
        Return Me.paPersons
    End Function



    Private Function ReadFile(ByVal filename As String) As List(Of String)

        Dim f As TextReader
        Dim lines As New List(Of String)
        Try

            Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("windows-1250")
            f = New StreamReader(filename, enc)

            Using f
                Dim line As String = f.ReadLine()
                While line IsNot Nothing
                    lines.Add(line)
                    line = f.ReadLine()
                End While
            End Using

        Catch ex As Exception
            Return Nothing
        End Try
        Return lines
    End Function



    Private Function ParseName(ByVal item As String) As String
        Const sEnd As String = "<!--  <obmen>"

        item = item.Replace(name, String.Empty)
        item = item.Substring(0, item.IndexOf(sEnd))

        Return item
    End Function



    Private Function ParseEVC(ByVal item As String) As String
        Const sEnd As String = "</bezc>"

        item = item.Replace(evc, String.Empty)
        item = item.Substring(0, item.IndexOf(sEnd))

        Return item.Trim()
    End Function

    Private Function ParseDayIn(ByVal item As String) As Date
        Const sEnd As String = "</pravopl>"

        item = item.Replace(dayIn, String.Empty)
        If item.IndexOf(sEnd) > -1 Then
            item = item.Substring(0, item.IndexOf(sEnd))
        End If
        Return CDate(item.Trim())
    End Function



    Private Function ParseDayOut(ByVal item As String) As Date

        item = item.Replace(dayOut, String.Empty)
        Return CDate(item.Trim())
    End Function



    Private Function ParseAddress(ByVal item As String) As String
        Const sEnd As String = "</sid>"

        item = item.Replace(address, String.Empty)
        If item.IndexOf(sEnd) > -1 Then
            item = item.Substring(0, item.IndexOf(sEnd))
        End If
        Return item.Trim()
    End Function



    Private Function ParseSection(ByVal item As String) As Sections

        item = item.Replace(section, String.Empty).Trim()

        Dim sec As New Sections

        sec.Number = item.Substring(0, 6)
        sec.Name = item.Substring(8).Trim()
        Return sec
    End Function



    Private Function ParseMobil(ByVal item As String) As String
        Dim s As String = mobil
        Dim ret As String = String.Empty
        ret = item.Substring(item.IndexOf(s) + s.Length)
        Return ret
    End Function



    Private Function ParseFax(ByVal item As String) As String
        Dim s As String = fax
        Dim ret As String = String.Empty
        ret = item.Substring(item.IndexOf(s) + s.Length)
        Return ret
    End Function



    Private Function ParseTel(ByVal item As String) As String
        Dim s As String = tel
        Dim ret As String = String.Empty
        ret = item.Substring(item.IndexOf(s) + s.Length)
        Return ret
    End Function



    Private Function ParseMail(ByVal item As String) As String
        Dim s As String = mail
        Dim ret As String = String.Empty
        ret = item.Substring(item.IndexOf(s) + s.Length)
        Return ret
    End Function



    Private Function ParseDepartment(ByVal item As String) As Department
        Const sEnd As String = "</sid>"

        item = item.Replace(deparment1, String.Empty)
        item = item.Replace(deparment2, String.Empty)

        If item.IndexOf(sEnd) > -1 Then
            item = item.Substring(0, item.IndexOf(sEnd))
        End If

        Dim deparmetn As New Department
        item = item.Trim()
        deparmetn.Number = item.Substring(0, 6)
        deparmetn.Name = item.Substring(8).Trim()
        Return deparmetn
    End Function



    Private Function Parse(filename As String) As Boolean

        Dim lines As New List(Of String)

        lines = Me.ReadFile(filename)

        If lines Is Nothing Then
            Return False
        End If

        Dim start As Boolean = False
        Dim person As Person = Nothing
        Dim parseAdress As Boolean = False
        Dim dpo As Boolean = False
        Dim lineNum As Int64 = 0
        Dim isOragnization As Boolean = False
        For Each line As String In lines

            lineNum += 1

            'EVC
            If line.Contains(evc) Then
                person = New Person()
                person.EVC = Me.ParseEVC(line)
                start = True
                isOragnization = False
            End If

            If line.Contains(organization) Then
                isOragnization = True
            End If

            ' Meno
            If line.Contains(name) Then
                person.Meno = Me.ParseName(line)
            End If

            ' Adresa
            If line.Contains(address) OrElse parseAdress Then
                If parseAdress Then
                    parseAdress = False
                Else
                    parseAdress = True
                End If
                If String.IsNullOrEmpty(person.Adresa) Then
                    person.Adresa = Me.ParseAddress(line)
                Else
                    person.Adresa = person.Adresa + ", " + Me.ParseAddress(line)
                End If
            End If


            ' Den zapisu 
            If line.Contains(dayIn) Then
                person.DenZapisu = Me.ParseDayIn(line)
            End If

            ' Odbor 
            If (line.Contains(deparment1) OrElse line.Contains(deparment2)) AndAlso Not dpo Then
                person.Odbory.Add(Me.ParseDepartment(line))
            End If

            ' Odvetvie
            If line.Contains(section) AndAlso Not dpo Then
                person.Odvetvia.Add(Me.ParseSection(line))
            End If

            ' Odbory Out 
            If line.Contains(depOut) Then
                dpo = True
            End If

            ' Mobil
            If line.Contains(mobil) Then
                person.Mobil = Me.ParseMobil(line)
            End If

            ' Tel
            If line.Contains(tel) Then
                person.Tel = Me.ParseTel(line)
            End If

            ' Fax
            If line.Contains(fax) Then
                person.Fax = Me.ParseFax(line)
            End If

            ' Mail
            If line.Contains(mail) Then
                person.Email = Me.ParseMail(line)
            End If

            ' Vyciarknutie
            If line.Contains(dayOut) Then
                person.Active = False
                person.DenVyciarknutia = Me.ParseDayOut(line)
            End If

            ' End 
            If line.Contains(endSection) Then

                If Not isOragnization Then

                    If Not Me.FilterSimilar Then
                        Me.Persons.Add(person)
                    Else
                        Dim find As Boolean = False
                        For Each item As Person In Me.Persons
                            If item.Adresa = person.Adresa AndAlso item.Meno = person.Meno Then
                                find = True
                                'Console.WriteLine(person)
                            End If
                        Next
                        If Not find Then
                            Me.Persons.Add(person)
                        End If

                        End If
                End If
                person = Nothing
                start = False
                dpo = False

            End If


        Next


        Return True
    End Function


End Class
