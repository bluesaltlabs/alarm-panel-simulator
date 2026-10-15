' The core AlarmSystem class, initiated at program start
Public Class AlarmSystem

    Private ReadOnly _state As AlarmState

    ' Constructor for AlarmSystem.
    Public Sub New()
        Me.New(New AlarmState())
    End Sub

    ' Constructor for AlarmSystem.
    ' Initiates a new AlarmSystem instance, passing in an existing AlarmState.
    Public Sub New(state as AlarmState)
        Me._state = state
    End Sub

    ' Print the AlarmSystem status as a string
    Public Function GetStatus() As String
        Dim panelStatus = $"| Alarm Status: {Me._state.Status} |"

        Return panelStatus
    End Function

End Class
