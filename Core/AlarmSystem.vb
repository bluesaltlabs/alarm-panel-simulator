Public Class AlarmSystem

    Private ReadOnly _state As AlarmState

    '
    Public Sub New()
        Me.New(New AlarmState())
    End Sub

    '
    Public Sub New(state as AlarmState)
        Me._state = state
    End Sub


    ' Print the AlarmSystem status as a string
    Public Function GetStatus() As String
        Dim panelStatus = $"| Alarm Status: {Me._state.Status} |"

        Return panelStatus
    End Function

End Class
