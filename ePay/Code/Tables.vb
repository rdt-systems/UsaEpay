﻿Imports System.Xml.Serialization

<Serializable(), XmlRoot("tables")>
Public Class Tables
    <XmlElement("row")> Property Interfaces As New List(Of row)
End Class

<SerializableAttribute>
Public Class row
    Property xupc As String
    Property xunitprice As String
    Property xqty As String
End Class