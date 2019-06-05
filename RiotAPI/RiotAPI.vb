Imports System.Net
Imports System.Web
Imports System.IO
Imports System.Reflection

Public Class Client
    Private key As String
    Private endPoint As String = "https://jp1.api.riotgames.com"

    Public Sub New(key As String)
        Me.key = key
        AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf OnResolveAssembly
    End Sub

    Private Function request(url As String) As String
        Dim req As WebRequest = WebRequest.Create(endPoint & url)
        req.Headers.Add("X-Riot-Token", key)
        Dim res As System.Net.WebResponse = req.GetResponse()
        Using stream As System.IO.Stream = res.GetResponseStream()
            Dim sr As New System.IO.StreamReader(stream, Text.Encoding.GetEncoding("utf-8"))
            Dim r = sr.ReadToEnd()
            Return r
        End Using
    End Function

    'No need to have KEY.
    Public Shared Function getVersion() As List(Of String)
        Dim req As WebRequest = WebRequest.Create("https://ddragon.leagueoflegends.com/api/versions.json")
        Dim res As System.Net.WebResponse = req.GetResponse()
        Using stream As System.IO.Stream = res.GetResponseStream()
            Dim sr As New System.IO.StreamReader(stream, Text.Encoding.GetEncoding("utf-8"))
            Dim r As String = sr.ReadToEnd()
            Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of String))(r)
        End Using
    End Function

    Public Shared Function getChampions(patch As String) As Champions
        Dim req As WebRequest = WebRequest.Create("http://ddragon.leagueoflegends.com/cdn/" & patch & "/data/en_US/champion.json")
        Dim res As System.Net.WebResponse = req.GetResponse()
        Using stream As System.IO.Stream = res.GetResponseStream()
            Dim sr As New System.IO.StreamReader(stream, Text.Encoding.GetEncoding("utf-8"))
            Dim r As String = sr.ReadToEnd()
            Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of Champions)(r)
        End Using
    End Function



    Private Shared Function OnResolveAssembly(sender As Object, args As ResolveEventArgs) As Assembly
        Try
            'gets the main Assembly
            Dim parentAssembly = Assembly.GetExecutingAssembly()
            'args.Name will be something like this
            '[ MahApps.Metro, Version=1.1.3.81, Culture=en-US, PublicKeyToken=null ]
            'so we take the name of the Assembly (MahApps.Metro) then add (.dll) to it
            Dim finalname = args.Name.Substring(0, args.Name.IndexOf(","c)) & ".dll"
            'here we search the resources for our dll and get the first match
            Dim ResourcesList = parentAssembly.GetManifestResourceNames()
            Dim OurResourceName As String = Nothing
            '(you can replace this with a LINQ extension like [Find] or [First])
            For i As Integer = 0 To ResourcesList.Count - 1
                Dim name = ResourcesList(i)
                If name.EndsWith(finalname) Then
                    'Get the name then close the loop to get the first occuring value
                    OurResourceName = name
                    Exit For
                End If
            Next

            If Not String.IsNullOrWhiteSpace(OurResourceName) Then
                'get a stream representing our resource then load it as bytes
                Using stream As Stream = parentAssembly.GetManifestResourceStream(OurResourceName)
                    Dim block As Byte() = New Byte(stream.Length - 1) {}
                    stream.Read(block, 0, block.Length)
                    Return Assembly.Load(block)
                End Using
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
