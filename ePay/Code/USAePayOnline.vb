Imports System.Threading.Tasks


Public Class USAePayOnline
    Private usaepay As USAePayAPI.USAePay
    Private IsProcessed As Boolean = False
    Public Async Function ChargeCardAsync(ByVal request As ePayRequest, ByVal Values As POSData) As Task
        usaepay = New USAePayAPI.USAePay
        usaepay.SourceKey = Values.ApiKey
        usaepay.GatewayURL = Values.GatewayUrl

        With usaepay
            .Amount = request.Amount / 100
            .CardNumber = request.CreditCardNo
            .CardExp = request.ExpDate
            .AvsZip = request.ZipCode
            .Cvv2 = request.ccv2
        End With

        Dim someTask As Task = Await Task.Factory.StartNew(Function()
                                                               IsProcessed = usaepay.Sale()
                                                           End Function)

    End Function

    Public Function ChargeCard(ByVal request As ePayRequest, ByVal Values As POSData) As ePayResponse
        usaepay = New USAePayAPI.USAePay
        usaepay.SourceKey = Values.ApiKey
        usaepay.GatewayURL = Values.GatewayUrl

        With usaepay
            .Invoice = request.TranNumber
            .Amount = request.Amount / 100
            .CardNumber = request.CreditCardNo
            .CardExp = request.ExpDate
            .BillingLastName = request.NameOnCard
            .AvsZip = request.ZipCode
            .Cvv2 = request.ccv2
        End With

        If request.TranCode = "SALE" Then
            usaepay.Sale()
        ElseIf request.TranCode = "CREDIT" Then
            usaepay.Credit()
        End If

        Return HandleResponse()
    End Function


    Public Function HandleResponse() As ePayResponse
        If usaepay Is Nothing Then
            Dim errResult As New ePayResponse With {.ResultCode = "ERROR", .ResultMessage = "Canceled"}
            Return errResult
        End If

        Dim tranResult As New ePayResponse With {.ResultCode = usaepay.ResultCode, .ResultMessage = usaepay.Result}

        Select Case (usaepay.ResultCode)
            Case "A"
                tranResult.ResultCode = "CAPTURED"
                tranResult.RefNumber = usaepay.ResultRefNum

                Dim cardType As String = GetCardType(usaepay.CardNumber.Substring(0, 1))

                tranResult.CardNumber = usaepay.CardNumber.Substring(0, 6) & IIf(cardType = "AMEX", "*****", "******")
                tranResult.CardNumber += usaepay.CardNumber.Substring(usaepay.CardNumber.Length - 4)
                tranResult.ApprovedAmount = usaepay.Amount
                tranResult.IAD = cardType
                tranResult.ResultMessage = usaepay.Result
                tranResult.NameOnCard = usaepay.BillingLastName
                tranResult.InputMethod = "OnFile"
            Case "D"
                tranResult.ResultCode = "DECLINED"
                tranResult.ResultMessage = usaepay.Result & ", " & usaepay.ErrorMesg
            Case Else
                tranResult.ResultCode = "ERROR"
                tranResult.ResultMessage = usaepay.ErrorMesg
        End Select
        Return tranResult

    End Function

    Private Function GetCardType(firstDigit As String) As String
        Select Case firstDigit
            Case "3"
                Return "AMEX"
            Case "4"
                Return "VISA"
            Case "5"
                Return "MASTERCARD"
            Case "6"
                Return "DISCOVER"
        End Select
        Return ""
    End Function
End Class
