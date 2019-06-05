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


'featured games
Public Class FeaturedGames
    Public Property clientRefreshInterval As Integer
    Public Property gameList As List(Of Gamelist)
End Class

Public Class Gamelist
    Public Property gameId As Integer
    Public Property gameStartTime As Long
    Public Property platformId As String
    Public Property gameMode As String
    Public Property mapId As Integer
    Public Property gameType As String
    Public Property gameQueueConfigId As Integer
    Public Property observers As Observers
    Public Property participants As List(Of Participant)
    Public Property gameLength As Integer
    Public Property bannedChampions = New List(Of Integer)

    Public Class Participant
        Public Property profileIconId As Integer
        Public Property championId As Integer
        Public Property summonerName As String
        Public Property bot As Boolean
        Public Property spell2Id As Integer
        Public Property teamId As Integer
        Public Property spell1Id As Integer
    End Class
End Class


Partial Public Class Client
    Public Function GetActiveGamesBySummoner(encryptedSummonerId As String) As CurrentGameInfo
        Dim url = "/lol/spectator/v4/active-games/by-summoner/"
        Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of CurrentGameInfo)(request(url + encryptedSummonerId))
    End Function

    Public Function GetFeaturedGames() As FeaturedGames
        Dim url = "/lol/spectator/v4/featured-games"
        Dim settings = New Newtonsoft.Json.JsonSerializerSettings()
        settings.MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore
        settings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore
        Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of FeaturedGames)(request(url), settings)
    End Function

End Class