'Imports MobileDevice
Imports System.Xml
Module PublicMod
    'Public iphone As New MobileDevice.iPhone
    Public dots, mode, device, carrier, ios, model, tool, chosentool As String
    Public document As XmlReader
    Public details, manual, utility As New Dictionary(Of String, List(Of String))
    Public jailbreak As New Dictionary(Of String, String)
    Public devices As New List(Of String)
    Public listo As List(Of String)
    Public cancelled, ok As Boolean
    Public program_version As String = "0.1-alpha"
End Module
