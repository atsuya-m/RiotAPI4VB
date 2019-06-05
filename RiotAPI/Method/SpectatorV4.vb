Public Class CurrentGameInfo
    Public Property gameId As Integer
    Public Property mapId As Integer
    Public Property gameMode As String
    Public Property gameType As String
    Public Property gameQueueConfigId As Integer
    Public Property participants As List(Of Participant)
    Public Property observers As Observers
    Public Property platformId As String
    Public Property bannedChampions As List(Of Bannedchampion)
    Public Property gameStartTime As Long
    Public Property gameLength As Integer

    Public Class Participant
        Public Property teamId As Integer
        Public Property spell1Id As Integer
        Public Property spell2Id As Integer
        Public Property championId As Integer
        Public Property profileIconId As Integer
        Public Property summonerName As String
        Public Property bot As Boolean
        Public Property summonerId As String
        Public Property gameCustomizationObjects As Object()
        Public Property perks As Perks
    End Class
End Class

Public Class Observers
    Public Property encryptionKey As String
End Class

Public Class Perks
    Public Property perkIds As Integer()
    Public Property perkStyle As Integer
    Public Property perkSubStyle As Integer
End Class

Public Class Bannedchampion
    Public Property championId As Integer
    Public Property teamId As Integer
    Public Property pickTurn As Integer
End Class

Partial Public Class Client
    Public Function GetActiveGamesBySummoner(encryptedSummonerId As String) As CurrentGameInfo
        Dim url = "/lol/spectator/v4/active-games/by-summoner/"
        Dim param As String = System.Uri.EscapeUriString(encryptedSummonerId)

        Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of CurrentGameInfo)(request(url + param))
    End Function
End Class