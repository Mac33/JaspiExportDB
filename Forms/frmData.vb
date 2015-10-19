Public Class frmData

    Public Property Parser As Parse


    Public Property DataSource As Object
        Get
            Return Me.GridControl1.DataSource
        End Get
        Set(value As Object)
            Me.GridControl1.DataSource = value
        End Set
    End Property

End Class