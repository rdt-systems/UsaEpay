<ComClass("F33B5DDD-A730-4A8C-9920-12B739501CDD")> _
Public Class ePayResponse
    Implements IePayResponse
    Dim _Error, _ErrorMessage, _IsDuplicate, _responsOrigin, _resultsCode, _resultsMessage, _CapturStatus, _RefrNumber, _Card_Number, _NameOn_Card, _RemainingBalan, _inputMethud, _ApproveAmount, _eWicExp, _eWicBalanc, _DevicSN, _SequencNo, _Invoice_No, _AID_, _TVR_, _IAD_, _TSI_, _Process_Data, _Record_No, _Auth, _CardType, _AVS As String

    Public Event ResultChanged(RespondsOrigion As String, cmdStatus As String, ReturnCode As String, Result As String)
    Public Property AID As String Implements IePayResponse.AID
        Get
            Return _AID_
        End Get
        Set(value As String)
            _AID_ = value
        End Set
    End Property
    Public Property ApprovedAmount As String Implements IePayResponse.ApprovedAmount
        Get
            Return _ApproveAmount
        End Get
        Set(value As String)
            _ApproveAmount = value
        End Set
    End Property

    Public Property CaptureStatus As String Implements IePayResponse.CaptureStatus
        Get
            Return _CapturStatus
        End Get
        Set(value As String)
            _CapturStatus = value
        End Set
    End Property
    Public Property CardNumber As String Implements IePayResponse.CardNumber
        Get
            Return _Card_Number
        End Get
        Set(value As String)
            _Card_Number = value
        End Set
    End Property
    Public Property DeviceSN As String Implements IePayResponse.DeviceSN
        Get
            Return _DevicSN
        End Get
        Set(value As String)
            _DevicSN = value
        End Set
    End Property

    Public Property eWicBalance As String Implements IePayResponse.eWicBalance
        Get
            Return _eWicBalanc
        End Get
        Set(value As String)
            _eWicBalanc = value
        End Set
    End Property

    Public Property eWicExpDate As String Implements IePayResponse.eWicExpDate
        Get
            Return _eWicExp
        End Get
        Set(value As String)
            _eWicExp = value
        End Set
    End Property

    Public Property IAD As String Implements IePayResponse.IAD
        Get
            Return _IAD_
        End Get
        Set(value As String)
            _AID_ = value
        End Set
    End Property

    Public Property InputMethod As String Implements IePayResponse.InputMethod
        Get
            Return _inputMethud
        End Get
        Set(value As String)
            _inputMethud = value
        End Set
    End Property

    Public Property InvoiceNo As String Implements IePayResponse.InvoiceNo
        Get
            Return _Invoice_No
        End Get
        Set(value As String)
            _Invoice_No = value
        End Set
    End Property

    Public Property NameOnCard As String Implements IePayResponse.NameOnCard
        Get
            Return _NameOn_Card
        End Get
        Set(value As String)
            _NameOn_Card = value
        End Set
    End Property

    Public Property ProcessData As String Implements IePayResponse.ProcessData
        Get
            Return _Process_Data
        End Get
        Set(value As String)
            _Process_Data = value
        End Set
    End Property

    Public Property RecordNo As String Implements IePayResponse.RecordNo
        Get
            Return _Record_No
        End Get
        Set(value As String)
            _Record_No = value
        End Set
    End Property

    Public Property RefNumber As String Implements IePayResponse.RefNumber
        Get
            Return _RefrNumber
        End Get
        Set(value As String)
            _RefrNumber = value
        End Set
    End Property

    Public Property RemainingBalance As String Implements IePayResponse.RemainingBalance
        Get
            Return _RemainingBalan
        End Get
        Set(value As String)
            _RemainingBalan = value
        End Set
    End Property

    Public Property ResponseOrigin As String Implements IePayResponse.ResponseOrigin
        Get
            Return _responsOrigin
        End Get
        Set(value As String)
            _responsOrigin = value
        End Set
    End Property

    Public Property ResultCode As String Implements IePayResponse.ResultCode
        Get
            Return _resultsCode
        End Get
        Set(value As String)
            _resultsCode = value
        End Set
    End Property

    Public Property ResultMessage As String Implements IePayResponse.ResultMessage
        Get
            Return _resultsMessage
        End Get
        Set(value As String)
            _resultsMessage = value
            RaiseEvent ResultChanged(_responsOrigin, _CapturStatus, _resultsCode, value)
        End Set
    End Property

    Public Property SequenceNo As String Implements IePayResponse.SequenceNo
        Get
            Return _SequencNo
        End Get
        Set(value As String)
            _SequencNo = value
        End Set
    End Property

    Public Property TSI As String Implements IePayResponse.TSI
        Get
            Return _TSI_
        End Get
        Set(value As String)
            _TSI_ = value
        End Set
    End Property

    Public Property TVR As String Implements IePayResponse.TVR
        Get
            Return _TVR_
        End Get
        Set(value As String)
            _TVR_ = value
        End Set
    End Property
    Public Property AuthCode As String Implements IePayResponse.AuthCode
        Get
            Return _Auth
        End Get
        Set(value As String)
            _Auth = value
        End Set
    End Property
    Public Property CardType As String Implements IePayResponse.CardType
        Get
            Return _CardType
        End Get
        Set(value As String)
            _CardType = value
        End Set
    End Property
    Public Property AVS As String Implements IePayResponse.AVS
        Get
            Return _AVS
        End Get
        Set(value As String)
            _AVS = value
        End Set
    End Property
    Public Property IsDuplicate As String Implements IePayResponse.IsDuplicate
        Get
            Return _IsDuplicate
        End Get
        Set(value As String)
            _IsDuplicate = value
        End Set
    End Property
    Public Property Err As String Implements IePayResponse.Err
        Get
            Return _Error
        End Get
        Set(value As String)
            _Error = value
        End Set
    End Property
    Public Property ErrorMessage As String Implements IePayResponse.ErrorMessage
        Get
            Return _ErrorMessage
        End Get
        Set(value As String)
            _ErrorMessage = value
        End Set
    End Property

End Class

