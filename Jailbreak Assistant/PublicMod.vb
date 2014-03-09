Imports MobileDevice
Imports System.Xml
Module PublicMod
    Public iphone As New MobileDevice.iPhone
    Public dots, mode, device, carrier, ios, model As String
    Public document As XmlReader
    Public details, manual As New Dictionary(Of String, List(Of String))
    Public devices As New List(Of String)
    Public listo As List(Of String)
    Public cancelled, ok As Boolean
End Module
