Public Class ChampionInfo
    Public Property freeChampionIds As List(Of Integer)
    Public Property freeChampionIdsForNewPlayers As List(Of Integer)
    Public Property maxNewPlayerLevel As Integer
End Class

Partial Public Class Client
    Public Function GetChampionRotations() As ChampionInfo
        Dim url = "/lol/platform/v3/champion-rotations"
        Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of ChampionInfo)(request(url))
    End Function
End Class