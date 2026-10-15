' Alarm Status Values
Public Enum AlarmStatus
    Normal
    Triggered
    Silenced
End Enum

' AlarmState class. Contains the state values of AlarmSystem
Public Class AlarmState

    ' Backing field for the Status property.
    Private _status As AlarmStatus

    ' Public, read-only property for AlarmState status (backed by the _status field)
    Public ReadOnly Property Status As AlarmStatus
        Get
            Return _status
        End Get
    End Property

    ' Constructor for AlarmState, initializes the status to Normal
    Public Sub New()
        Me._status = AlarmStatus.Normal
    End Sub

    ' Set the AlarmState status to Triggered
    Public Sub TriggerAlarm()
        Me._status = AlarmStatus.Triggered
    End Sub

    ' Set the AlarmState status to Silenced
    Public Sub SilenceAlarm()
        Me._status = AlarmStatus.Silenced
    End Sub

    ' Set the AlarmState status to Normal
    Public Sub ResetAlarm()
        Me._status = AlarmStatus.Normal
    End Sub


End Class
