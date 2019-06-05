Public Class Champions
    Public Property type As String
    Public Property format As String
    Public Property version As String
    Public Property data As New Dictionary(Of String, Champion)
End Class

Public Class Champion
    Public Property version As String
    Public Property id As String
    Public Property key As String
    Public Property name As String
    Public Property title As String
    Public Property blurb As String
    Public Property info As Info
    Public Property image As Image
    Public Property tags As String()
    Public Property partype As String
    Public Property stats As Statss
End Class

Public Class Info
    Public Property attack As Integer
    Public Property defense As Integer
    Public Property magic As Integer
    Public Property difficulty As Integer
End Class

Public Class Image
    Public Property full As String
    Public Property sprite As String
    Public Property group As String
    Public Property x As Integer
    Public Property y As Integer
    Public Property w As Integer
    Public Property h As Integer
End Class

Public Class Statss
    Public Property hp As Single
    Public Property hpperlevel As Single
    Public Property mp As Single
    Public Property mpperlevel As Single
    Public Property movespeed As Single
    Public Property armor As Single
    Public Property armorperlevel As Single
    Public Property spellblock As Single
    Public Property spellblockperlevel As Single
    Public Property attackrange As Single
    Public Property hpregen As Single
    Public Property hpregenperlevel As Single
    Public Property mpregen As Single
    Public Property mpregenperlevel As Single
    Public Property crit As Single
    Public Property critperlevel As Single
    Public Property attackdamage As Single
    Public Property attackdamageperlevel As Single
    Public Property attackspeedoffset As Single
    Public Property attackspeedperlevel As Single
End Class