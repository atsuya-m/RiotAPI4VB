Public Class MatchDto
    Public Property gameId As Integer
    Public Property platformId As String
    Public Property gameCreation As Long
    Public Property gameDuration As Integer
    Public Property queueId As Integer
    Public Property mapId As Integer
    Public Property seasonId As Integer
    Public Property gameVersion As String
    Public Property gameMode As String
    Public Property gameType As String
    Public Property teams As Team()
    Public Property participants As List(Of Participant)
    Public Property participantIdentities As Participantidentity()

    Public Class Participant
        Public Property participantId As Integer
        Public Property teamId As Integer
        Public Property championId As Integer
        Public Property spell1Id As Integer
        Public Property spell2Id As Integer
        Public Property highestAchievedSeasonTier As String
        Public Property stats As Stats
        Public Property timeline As Timeline
    End Class
End Class

Public Class Team
    Public Property teamId As Integer
    Public Property win As String
    Public Property firstBlood As Boolean
    Public Property firstTower As Boolean
    Public Property firstInhibitor As Boolean
    Public Property firstBaron As Boolean
    Public Property firstDragon As Boolean
    Public Property firstRiftHerald As Boolean
    Public Property towerKills As Integer
    Public Property inhibitorKills As Integer
    Public Property baronKills As Integer
    Public Property dragonKills As Integer
    Public Property vilemawKills As Integer
    Public Property riftHeraldKills As Integer
    Public Property dominionVictoryScore As Integer
    Public Property bans As Ban()
End Class

Public Class Ban
    Public Property championId As Integer
    Public Property pickTurn As Integer
End Class

Public Class Stats
    Public Property participantId As Integer
    Public Property win As Boolean
    Public Property item0 As Integer
    Public Property item1 As Integer
    Public Property item2 As Integer
    Public Property item3 As Integer
    Public Property item4 As Integer
    Public Property item5 As Integer
    Public Property item6 As Integer
    Public Property kills As Integer
    Public Property deaths As Integer
    Public Property assists As Integer
    Public Property largestKillingSpree As Integer
    Public Property largestMultiKill As Integer
    Public Property killingSprees As Integer
    Public Property longestTimeSpentLiving As Integer
    Public Property doubleKills As Integer
    Public Property tripleKills As Integer
    Public Property quadraKills As Integer
    Public Property pentaKills As Integer
    Public Property unrealKills As Integer
    Public Property totalDamageDealt As Integer
    Public Property magicDamageDealt As Integer
    Public Property physicalDamageDealt As Integer
    Public Property trueDamageDealt As Integer
    Public Property largestCriticalStrike As Integer
    Public Property totalDamageDealtToChampions As Integer
    Public Property magicDamageDealtToChampions As Integer
    Public Property physicalDamageDealtToChampions As Integer
    Public Property trueDamageDealtToChampions As Integer
    Public Property totalHeal As Integer
    Public Property totalUnitsHealed As Integer
    Public Property damageSelfMitigated As Integer
    Public Property damageDealtToObjectives As Integer
    Public Property damageDealtToTurrets As Integer
    Public Property visionScore As Integer
    Public Property timeCCingOthers As Integer
    Public Property totalDamageTaken As Integer
    Public Property magicalDamageTaken As Integer
    Public Property physicalDamageTaken As Integer
    Public Property trueDamageTaken As Integer
    Public Property goldEarned As Integer
    Public Property goldSpent As Integer
    Public Property turretKills As Integer
    Public Property inhibitorKills As Integer
    Public Property totalMinionsKilled As Integer
    Public Property neutralMinionsKilled As Integer
    Public Property neutralMinionsKilledTeamJungle As Integer
    Public Property neutralMinionsKilledEnemyJungle As Integer
    Public Property totalTimeCrowdControlDealt As Integer
    Public Property champLevel As Integer
    Public Property visionWardsBoughtInGame As Integer
    Public Property sightWardsBoughtInGame As Integer
    Public Property wardsPlaced As Integer
    Public Property wardsKilled As Integer
    Public Property firstBloodKill As Boolean
    Public Property firstBloodAssist As Boolean
    Public Property firstTowerKill As Boolean
    Public Property firstTowerAssist As Boolean
    Public Property firstInhibitorKill As Boolean
    Public Property firstInhibitorAssist As Boolean
    Public Property combatPlayerScore As Integer
    Public Property objectivePlayerScore As Integer
    Public Property totalPlayerScore As Integer
    Public Property totalScoreRank As Integer
    Public Property playerScore0 As Integer
    Public Property playerScore1 As Integer
    Public Property playerScore2 As Integer
    Public Property playerScore3 As Integer
    Public Property playerScore4 As Integer
    Public Property playerScore5 As Integer
    Public Property playerScore6 As Integer
    Public Property playerScore7 As Integer
    Public Property playerScore8 As Integer
    Public Property playerScore9 As Integer
    Public Property perk0 As Integer
    Public Property perk0Var1 As Integer
    Public Property perk0Var2 As Integer
    Public Property perk0Var3 As Integer
    Public Property perk1 As Integer
    Public Property perk1Var1 As Integer
    Public Property perk1Var2 As Integer
    Public Property perk1Var3 As Integer
    Public Property perk2 As Integer
    Public Property perk2Var1 As Integer
    Public Property perk2Var2 As Integer
    Public Property perk2Var3 As Integer
    Public Property perk3 As Integer
    Public Property perk3Var1 As Integer
    Public Property perk3Var2 As Integer
    Public Property perk3Var3 As Integer
    Public Property perk4 As Integer
    Public Property perk4Var1 As Integer
    Public Property perk4Var2 As Integer
    Public Property perk4Var3 As Integer
    Public Property perk5 As Integer
    Public Property perk5Var1 As Integer
    Public Property perk5Var2 As Integer
    Public Property perk5Var3 As Integer
    Public Property perkPrimaryStyle As Integer
    Public Property perkSubStyle As Integer
    Public Property statPerk0 As Integer
    Public Property statPerk1 As Integer
    Public Property statPerk2 As Integer
End Class

Public Class Timeline
    Public Property participantId As Integer
    Public Property creepsPerMinDeltas As Creepspermindeltas
    Public Property xpPerMinDeltas As Xppermindeltas
    Public Property goldPerMinDeltas As Goldpermindeltas
    Public Property csDiffPerMinDeltas As Csdiffpermindeltas
    Public Property xpDiffPerMinDeltas As Xpdiffpermindeltas
    Public Property damageTakenPerMinDeltas As Damagetakenpermindeltas
    Public Property damageTakenDiffPerMinDeltas As Damagetakendiffpermindeltas
    Public Property role As String
    Public Property lane As String
End Class

Public Class Creepspermindeltas
    Public Property _1020 As Single
    Public Property _010 As Single
End Class

Public Class Xppermindeltas
    Public Property _1020 As Single
    Public Property _010 As Single
End Class

Public Class Goldpermindeltas
    Public Property _1020 As Single
    Public Property _010 As Single
End Class

Public Class Csdiffpermindeltas
    Public Property _1020 As Single
    Public Property _010 As Single
End Class

Public Class Xpdiffpermindeltas
    Public Property _1020 As Single
    Public Property _010 As Single
End Class

Public Class Damagetakenpermindeltas
    Public Property _1020 As Single
    Public Property _010 As Single
End Class

Public Class Damagetakendiffpermindeltas
    Public Property _1020 As Single
    Public Property _010 As Single
End Class

Public Class Participantidentity
    Public Property participantId As Integer
End Class


'timeline
Public Class MatchTimelineDto
    Public Property frames As Frame()
    Public Property frameInterval As Integer
End Class

Public Class Frame
    Public Property participantFrames As New Dictionary(Of String, MatchParticipantFrameDto)
    Public Property events As _Event()
    Public Property timestamp As Integer
End Class

Public Class MatchParticipantFrameDto
    Public Property participantId As Integer
    Public Property position As Position
    Public Property currentGold As Integer
    Public Property totalGold As Integer
    Public Property level As Integer
    Public Property xp As Integer
    Public Property minionsKilled As Integer
    Public Property jungleMinionsKilled As Integer
    Public Property dominionScore As Integer
    Public Property teamScore As Integer
End Class

Public Class Position
    Public Property x As Integer
    Public Property y As Integer
End Class

Public Class _Event
    Public Property type As String
    Public Property timestamp As Integer
    Public Property participantId As Integer
    Public Property itemId As Integer
    Public Property skillSlot As Integer
    Public Property levelUpType As String
    Public Property wardType As String
    Public Property creatorId As Integer
    Public Property position As Position
    Public Property killerId As Integer
    Public Property victimId As Integer
    Public Property assistingParticipantIds As Integer()
    Public Property afterId As Integer
    Public Property beforeId As Integer
    Public Property monsterType As String
    Public Property monsterSubType As String
    Public Property teamId As Integer
    Public Property buildingType As String
    Public Property laneType As String
    Public Property towerType As String
End Class

Partial Public Class Client
    Public Function GetMatches(matchId As String) As MatchDto
        Dim url = "/lol/match/v4/matches/"
        Dim param As String = matchId

        Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of MatchDto)(request(url + param))
    End Function

    Public Function MatchV4_timelines(matchId As String) As MatchTimelineDto
        Dim url = "/lol/match/v4/timelines/by-match/"
        Dim param As String = matchId

        Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of MatchTimelineDto)(request(url + param))
    End Function

End Class