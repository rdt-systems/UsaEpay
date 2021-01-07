<ComClass("57FD957C-87F5-4AD5-B0D2-F349F3963000")> _
Public Class ePayRequest
    Implements IePayRequest

    Dim _Lane_ID, _GatewayUrl, _Merchant__ID, _Terminal_ID, _Operator_ID, _User_Trace, _TransNumber, _xAmount, _Device, _Com_Port, _TransCode, _Sequence_No, _PinPadIp, _PinPadPort, _RequestSignatur, _CardNo, _Exp, _Zip, _ccv, _Name_OnCard, _Record_No, _APIKey, _ApiPIN, _DeviceID As String
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
    Public Property ComPort As String Implements IePayRequest.ComPort
        Get
            Return _Com_Port
        End Get
        Set(value As String)
            _Com_Port = value
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
    Public Property Device As String Implements IePayRequest.Device
        Get
            Return _Device
        End Get
        Set(value As String)
            _Device = value
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
    Public Property LaneID As String Implements IePayRequest.LaneID
        Get
            Return _Lane_ID
        End Get
        Set(value As String)
            _Lane_ID = value
        End Set
    End Property
    Public Property MerchantID As String Implements IePayRequest.MerchantID
        Get
            Return _Merchant__ID
        End Get
        Set(value As String)
            _Merchant__ID = value
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
    Public Property OperatorID As String Implements IePayRequest.OperatorID
        Get
            Return _Operator_ID
        End Get
        Set(value As String)
            _Operator_ID = value
        End Set
    End Property
    Public Property PinPadIpAddress As String Implements IePayRequest.PinPadIpAddress
        Get
            Return _PinPadIp
        End Get
        Set(value As String)
            _PinPadIp = value
        End Set
    End Property
    Public Property PinPadIpPort As String Implements IePayRequest.PinPadIpPort
        Get
            Return _PinPadPort
        End Get
        Set(value As String)
            _PinPadPort = value
        End Set
    End Property
    Public Property RecordNo As String Implements IePayRequest.RecordNo
        Get
            Return _Record_No
        End Get
        Set(value As String)
            _Record_No = value
        End Set
    End Property
    Public Property RequestSignature As Boolean Implements IePayRequest.RequestSignature
        Get
            Return _RequestSignatur
        End Get
        Set(value As Boolean)
            _RequestSignatur = value
        End Set
    End Property
    Public Property SequenceNo As String Implements IePayRequest.SequenceNo
        Get
            Return _Sequence_No
        End Get
        Set(value As String)
            _Sequence_No = value
        End Set
    End Property
    Public Property TerminalID As String Implements IePayRequest.TerminalID
        Get
            Return _Terminal_ID
        End Get
        Set(value As String)
            _Terminal_ID = value
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
    Public Property UserTrace As String Implements IePayRequest.UserTrace
        Get
            Return _User_Trace
        End Get
        Set(value As String)
            _User_Trace = value
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
End Class
