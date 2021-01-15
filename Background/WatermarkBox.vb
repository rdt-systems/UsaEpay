Imports System
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.Drawing
Imports System.ComponentModel
Imports System.Data.Entity.Core
Imports System.Runtime.InteropServices
Public Class CueTextBox
    Inherits DevExpress.XtraEditors.TextEdit

    Protected Overrides Sub OnGotFocus(e As EventArgs)
        MyBase.OnGotFocus(e)
        If Me._usePrompt Then
            Me._usePrompt = False
            Me.MaskBox.SetEditValue(String.Empty, String.Empty, True)
        End If
    End Sub

    Protected Overrides Sub OnLostFocus(e As EventArgs)
        If Me.MaskBox.MaskBoxText.Length = 0 OrElse Me.MaskBox.MaskBoxText = Me._textPrompt Then
            Me._usePrompt = True
            Me.MaskBox.SetEditValue(Me._textPrompt, Me._textPrompt, True)
        End If
        MyBase.OnLostFocus(e)
    End Sub

    Private _textPrompt As String = "enter a Month"
    Public Property TextPrompt() As String
        Get
            Return _textPrompt
        End Get
        Set(value As String)
            _textPrompt = value
            If Me._usePrompt AndAlso Not String.IsNullOrEmpty(Me._textPrompt) Then
                Me.MaskBox.SetEditValue(value, value, True)
            End If
        End Set
    End Property

    Private _usePrompt As Boolean
    Private Property UsePrompt() As Boolean
        Get
            Return _usePrompt
        End Get
        Set(value As Boolean)
            _usePrompt = value
            If _usePrompt Then
                Me.Font = New Font(Me.Font.Name, Me.Font.Size, FontStyle.Italic)
                Me.ForeColor = Color.Gray
            Else
                ' TODO don't hardcode the user given values.
                Me.Font = New Font(Me.Font.Name, Me.Font.Size, FontStyle.Regular)
                Me.ForeColor = Color.Black
            End If
        End Set
    End Property

    Protected Overrides Sub OnParentChanged(e As EventArgs)
        If String.IsNullOrEmpty(Me.MaskBox.EditValue) Then
            Me._usePrompt = True
            Me.MaskBox.SetEditValue(Me._textPrompt, Me._textPrompt, True)
        End If
        MyBase.OnParentChanged(e)
    End Sub

    Public Overrides Property EditValue As Object
        Get
            If Me._usePrompt Then
                Return String.Empty
            End If
            Return MyBase.EditValue
        End Get
        Set(value As Object)
            If Me._usePrompt AndAlso (Not String.IsNullOrEmpty(value) AndAlso value <> Me._textPrompt) Then
                Me._usePrompt = False
            End If

            If String.IsNullOrEmpty(value) AndAlso Not Me.Focused AndAlso Not String.IsNullOrEmpty(Me._textPrompt) Then
                Me._usePrompt = True
                Me.MaskBox.SetEditValue(Me._textPrompt, Me._textPrompt, True)
                Return
            End If

            MyBase.EditValue = value
        End Set
    End Property

End Class

Public Class AddWatermark
    Public Class CueTextBox
        Inherits DevExpress.XtraEditors.TextEdit

        Private mCue As String
        Public Property Watermark() As String
            Get
                Return mCue
            End Get
            Set(value As String)
                mCue = value
                updateCue()
            End Set
        End Property
        Private Sub updateCue()
            If Me.IsHandleCreated AndAlso mCue <> Nothing Then
                SendMessage(Me.MaskBox.Handle, &H1501, CType(1, IntPtr), mCue)
            End If
        End Sub
        Protected Overrides Sub OnHandleCreated(e As EventArgs)
            MyBase.OnHandleCreated(e)
            updateCue()
        End Sub
        ' P/Invoke
        <DllImport("user32.dll", CharSet:=CharSet.Unicode)> _
        Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wp As IntPtr, lp As String) As IntPtr
        End Function
    End Class
End Class



Partial Public Class CueDateBox
    Inherits DevExpress.XtraEditors.DateEdit

    Protected Overrides Sub OnGotFocus(e As EventArgs)
        MyBase.OnGotFocus(e)
        If Me._usePrompt Then
            Me._usePrompt = False
            Me.MaskBox.SetEditValue(String.Empty, String.Empty, True)
        End If
    End Sub

    Protected Overrides Sub OnLostFocus(e As EventArgs)
        If Me.MaskBox.MaskBoxText.Length = 0 OrElse Me.MaskBox.MaskBoxText = Me._textPrompt Then
            Me._usePrompt = True
            Me.MaskBox.SetEditValue(Me._textPrompt, Me._textPrompt, True)
        End If
        MyBase.OnLostFocus(e)
    End Sub

    Private _textPrompt As String = "enter a Month"
    Public Property TextPrompt() As String
        Get
            Return _textPrompt
        End Get
        Set(value As String)
            _textPrompt = value
            If Me._usePrompt AndAlso Not String.IsNullOrEmpty(Me._textPrompt) Then
                Me.MaskBox.SetEditValue(value, value, True)
            End If
        End Set
    End Property

    Private _usePrompt As Boolean
    Private Property UsePrompt() As Boolean
        Get
            Return _usePrompt
        End Get
        Set(value As Boolean)
            _usePrompt = value
            If _usePrompt Then
                Me.Font = New Font(Me.Font.Name, Me.Font.Size, FontStyle.Italic)
                Me.ForeColor = Color.Gray
            Else
                ' TODO don't hardcode the user given values.
                Me.Font = New Font(Me.Font.Name, Me.Font.Size, FontStyle.Regular)
                Me.ForeColor = Color.Black
            End If
        End Set
    End Property

    Protected Overrides Sub OnParentChanged(e As EventArgs)
        If String.IsNullOrEmpty(Me.MaskBox.EditValue) Then
            Me._usePrompt = True
            Me.MaskBox.SetEditValue(Me._textPrompt, Me._textPrompt, True)
        End If
        MyBase.OnParentChanged(e)
    End Sub

    Public Overrides Property EditValue As Object
        Get
            If Me._usePrompt Then
                Return String.Empty
            End If
            Return MyBase.EditValue
        End Get
        Set(value As Object)
            If Me._usePrompt AndAlso (Not String.IsNullOrEmpty(value) AndAlso value <> Me._textPrompt) Then
                Me._usePrompt = False
            End If

            If String.IsNullOrEmpty(value) AndAlso Not Me.Focused AndAlso Not String.IsNullOrEmpty(Me._textPrompt) Then
                Me._usePrompt = True
                Me.MaskBox.SetEditValue(Me._textPrompt, Me._textPrompt, True)
                Return
            End If

            MyBase.EditValue = value
        End Set
    End Property

End Class

Public Class AddWatermarkDate
    Public Class CueDateBox
        Inherits DevExpress.XtraEditors.DateEdit

        Private mCue As String
        Public Property Watermark() As String
            Get
                Return mCue
            End Get
            Set(value As String)
                mCue = value
                updateCue()
            End Set
        End Property
        Private Sub updateCue()
            If Me.IsHandleCreated AndAlso mCue <> Nothing Then
                SendMessage(Me.MaskBox.Handle, &H1501, CType(1, IntPtr), mCue)
            End If
        End Sub
        Protected Overrides Sub OnHandleCreated(e As EventArgs)
            MyBase.OnHandleCreated(e)
            updateCue()
        End Sub
        ' P/Invoke
        <DllImport("user32.dll", CharSet:=CharSet.Unicode)> _
        Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wp As IntPtr, lp As String) As IntPtr
        End Function
    End Class
End Class