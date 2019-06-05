Module Module1

    Sub Main()
        Dim client = New RiotAPI.Client("SET_YOUR_API_KEY")
        Console.WriteLine(client.GetSummonersByName("SUMMONER_NAME").id)

        Console.ReadLine()
    End Sub

End Module
