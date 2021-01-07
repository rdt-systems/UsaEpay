Friend Class Locker
    Implements ILocker
    '// Fields...

    Private _IsCanceled, _HasCardOnFile, _IsF2 As Boolean

    Public Property IsF2() As Boolean Implements ILocker.IsF2
        Get
            Return _IsF2
        End Get
        Set(ByVal value As Boolean)
            _IsF2 = value
        End Set
    End Property
    Public Property HasCardOnFile() As Boolean Implements ILocker.HasCardOnFile
        Get
            Return _HasCardOnFile
        End Get
        Set(ByVal value As Boolean)
            _HasCardOnFile = value
        End Set
    End Property
    Public Property IsCanceled() As Boolean Implements ILocker.IsCanceled
        Get
            Return _IsCanceled
        End Get
        Set(ByVal value As Boolean)
            _IsCanceled = value
        End Set
    End Property
    Public Sub New()
        _IsCanceled = False
        _HasCardOnFile = False
        _IsF2 = False
    End Sub
End Class