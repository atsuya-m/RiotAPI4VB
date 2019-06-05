Public Class SummonerDTO
    Public Property profileIconId As Integer
    Public Property name As String
    Public Property puuid As String
    Public Property summonerLevel As Integer
    Public Property accountId As String
    Public Property id As String
    Public Property revisionDate As Long
End Class

Partial Public Class Client
    Public Function GetSummonersByName(summonerName As String) As SummonerDTO
        Dim url = "/lol/summoner/v4/summoners/by-name/"
        Dim param As String = System.Uri.EscapeUriString(summonerName)

        Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of SummonerDTO)(request(url + param))
    End Function
End Class