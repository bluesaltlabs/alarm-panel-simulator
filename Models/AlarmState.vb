Public Enum AlarmStatus
    Normal
    Triggered
    Silenced
End Enum


Public Class AlarmState

    ' Backing field for the Status property.
    Private _status As AlarmStatus

    ' Public, read-only property for AlarmState status (backed by the _status field)
    Public ReadOnly Property Status As AlarmStatus
        Get
            Return _status
        End Get
    End Property

    Public Sub New()
        Me._status = AlarmStatus.Normal
    End Sub

    ' Set the AlarmState status to Triggered
    Public Sub TriggerAlarm()
        Me._status = AlarmStatus.Triggered
    End Sub

    Public Sub SilenceAlarm()
        Me._status = AlarmStatus.Silenced
    End Sub

    Public Sub ResetAlarm()
        Me._status = AlarmStatus.Normal
    End Sub


End Class
