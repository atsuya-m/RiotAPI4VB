Public Class ShardStatus
    Public Property name As String
    Public Property region_tag As String
    Public Property hostname As String
    Public Property services As List(Of Service)
    Public Property slug As String
    Public Property locales As List(Of String)
End Class

Public Class Service
    Public Property status As String
    Public Property incidents As List(Of Incident)
    Public Property name As String
    Public Property slug As String
End Class

Public Class Incident
    Public Property active As Boolean
    Public Property created_at As Date
    Public Property id As Integer
    Public Property updates As List(Of Update)
End Class

Public Class Update
    Public Property severity As String
    Public Property author As String
    Public Property created_at As Date
    Public Property translations As List(Of Object)
    Public Property updated_at As Date
    Public Property content As String
    Public Property id As String
End Class


Partial Public Class Client
    Public Function GetShardData() As ShardStatus
        Dim url = "/lol/status/v3/shard-data"
        Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of ShardStatus)(request(url))
    End Function

End Class