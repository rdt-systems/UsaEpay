<ComClass("57FD957C-87F5-4AD5-B0D2-F349F3963000")> _
Public Class ePayRequest
    Implements IePayRequest

    Dim _GatewayUrl, _TransNumber, _xAmount, _TransCode, _CardNo, _Exp, _Zip, _ccv, _Name_OnCard, _APIKey, _ApiPIN, _DeviceID, _RefNum, _MagStrip As String
    Public Property Amount As String Implements IePayRequest.Amount
        Get
            Return _xAmount
        End Get
        Set(value As String)
            _xAmount = value
        End Set
    End Property
    Public Property ccv2 As String Implements IePayRequest.ccv2
        Get
            Return _ccv
        End Get
        Set(value As String)
            _ccv = value
        End Set
    End Property
    Public Property CreditCardNo As String Implements IePayRequest.CreditCardNo
        Get
            Return _CardNo
        End Get
        Set(value As String)
            _CardNo = value
        End Set
    End Property
    Public Property ExpDate As String Implements IePayRequest.ExpDate
        Get
            Return _Exp
        End Get
        Set(value As String)
            _Exp = value
        End Set
    End Property
    Public Property GatewayUrl As String Implements IePayRequest.GatewayUrl
        Get
            Return _GatewayUrl
        End Get
        Set(value As String)
            _GatewayUrl = value
        End Set
    End Property
    Public Property NameOnCard As String Implements IePayRequest.NameOnCard
        Get
            Return _Name_OnCard
        End Get
        Set(value As String)
            _Name_OnCard = value
        End Set
    End Property
    Public Property TranCode As String Implements IePayRequest.TranCode
        Get
            Return _TransCode
        End Get
        Set(value As String)
            _TransCode = value
        End Set
    End Property
    Public Property TranNumber As String Implements IePayRequest.TranNumber
        Get
            Return _TransNumber
        End Get
        Set(value As String)
            _TransNumber = value
        End Set
    End Property
    Public Property ZipCode As String Implements IePayRequest.ZipCode
        Get
            Return _Zip
        End Get
        Set(value As String)
            _Zip = value
        End Set
    End Property
    Public Property APIKey As String Implements IePayRequest.APIKey
        Get
            Return _APIKey
        End Get
        Set(value As String)
            _APIKey = value
        End Set
    End Property
    Public Property ApiPIN As String Implements IePayRequest.ApiPIN
        Get
            Return _ApiPIN
        End Get
        Set(value As String)
            _ApiPIN = value
        End Set
    End Property
    Public Property DeviceID As String Implements IePayRequest.DeviceID
        Get
            Return _DeviceID
        End Get
        Set(value As String)
            _DeviceID = value
        End Set
    End Property
    Property RefNum As String Implements IePayRequest.RefNum
        Get
            Return _RefNum
        End Get
        Set(value As String)
            _RefNum = value
        End Set
    End Property
    Property MagStrip As String Implements IePayRequest.MagStrip
        Get
            Return _MagStrip
        End Get
        Set(value As String)
            _MagStrip = value
        End Set
    End Property
End Class
