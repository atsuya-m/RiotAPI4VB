Public Class ChampionMasteryDTO
    Public Property championLevel As Integer
    Public Property chestGranted As Boolean
    Public Property championPoints As Integer
    Public Property championPointsSinceLastLevel As Integer
    Public Property championPointsUntilNextLevel As Integer
    Public Property summonerId As String
    Public Property tokensEarned As Integer
    Public Property championId As Integer
    Public Property lastPlayTime As Long
End Class


Partial Public Class Client
    Public Function GetChampionMasteryBySummoner(encryptedSummonerId As String) As List(Of ChampionMasteryDTO)
        Dim url = "/lol/champion-mastery/v4/champion-masteries/by-summoner/"
        Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of ChampionMasteryDTO))(request(url + encryptedSummonerId))
    End Function

    Public Function GetChampionMasteryBySummonerAndChampionId(encryptedSummonerId As String, championId As Integer) As ChampionMasteryDTO
        Dim url = "/lol/champion-mastery/v4/champion-masteries/by-summoner/" + encryptedSummonerId + "/by-champion/" + championId.ToString
        Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of ChampionMasteryDTO)(request(url))
    End Function

    Public Function GetScoresBySummoner(encryptedSummonerId As String) As Integer
        Dim url = "/lol/champion-mastery/v4/scores/by-summoner/" + encryptedSummonerId
        Return request(url)
    End Function

End Class