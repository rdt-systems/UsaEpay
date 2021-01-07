Public Class Result
    Public Property CmdResponse As XElement
    Public Property TranResponse As XElement

End Class

Public Class CmdResponse
    Public Property ResponseOrigin As String
    Public Property DSIXReturnCode As String
    Public Property CmdStatus As String
    Public Property TextResponse As String
    Public Property SequenceNo As String
    Public Property UserTrace As String
End Class

Public Class TranResponse
    Public Property MerchantID As String
    Public Property TerminalID As String
    Public Property AcctNo As String
    Public Property CardType As String
    Public Property TranCode As String
    Public Property AuthCode As String
    Public Property AVSResult As String
    Public Property CVVResult As String
    Public Property CaptureStatus As String
    Public Property RefNo As String
    Public Property InvoiceNo As String
    Public Property OperatorID As String
    Public Property Amount As XElement
    Public Property CardholderName As String
    Public Property AcqRefData As String
    Public Property PostProcess As String
    Public Property ProcessData As String
    Public Property EntryMethod As String
    Public Property RecordNo As String
    Public Property [Date] As String
    Public Property Time As String
    Public Property ApplicationLabel As String
    Public Property AID As String
    Public Property TVR As String
    Public Property IAD As String
    Public Property TSI As String
    Public Property CVM As String
End Class
Public Class Amount
    Public Property Purchase As String
    Public Property Authorize As String
    Public Property Cashback As String
    Public Property Gratuity As String
End Class