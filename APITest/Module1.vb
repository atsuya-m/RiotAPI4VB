Module Module1

    Sub Main()
        Dim riot As RiotAPI.Client = New RiotAPI.Client("SET_YOUR_API_KEY")
        Console.WriteLine(riot.GetSummonersByName("Atsuya M").id)
    End Sub

End Module
