﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18444
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Public Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Jailbreak_Assistant.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;root&gt;
        '''  &lt;Type
        '''    device=&quot;iPhone1,1&quot; name=&quot;iPhone 2G&quot; carrier=&quot;GSM&quot;
        '''  /&gt;
        '''
        '''  &lt;Type
        '''    device=&quot;iPhone1,2&quot; name=&quot;iPhone 3G&quot; carrier=&quot;GSM&quot;
        '''  /&gt;
        '''
        '''  &lt;Type
        '''    device=&quot;iPhone2,1&quot; name=&quot;iPhone 3GS&quot; carrier=&quot;GSM&quot;
        '''  /&gt;
        '''
        '''  &lt;Type
        '''    device=&quot;iPhone3,1&quot; name=&quot;iPhone 4&quot; carrier=&quot;GSM&quot;
        '''  /&gt;
        '''
        '''  &lt;Type
        '''    device=&quot;iPhone3,2&quot; name=&quot;iPhone 4&quot; carrier=&quot;GSM&quot;
        '''  /&gt;
        '''
        '''  &lt;Type
        '''    device=&quot;iPhone3,3&quot; name=&quot;iPhone 4&quot; carrier=&quot;CDMA&quot;
        '''  /&gt;
        '''
        '''  &lt;Type
        '''    device=&quot;iPhone4,1&quot; name=&quot;iPhone 4S&quot; carrier=&quot;Global&quot;
        '''  /&gt;
        ''' [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property devices() As String
            Get
                Return ResourceManager.GetString("devices", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property evasi0n() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("evasi0n", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;root&gt;
        '''&lt;device name=&quot;iPad 2&quot; version=&quot;6.0,6.0.1,6.1,6.1.2,6.1.3,7.0,7.0.2,7.0.3,7.0.4,7.0.6,7.1,7.1.1,7.1.2&quot;/&gt;
        '''&lt;device name=&quot;iPad 3&quot; version=&quot;6.0,6.0.1,6.1,6.1.2,6.1.3,7.0,7.0.2,7.0.3,7.0.4,7.0.6,7.1,7.1.1,7.1.2&quot;/&gt;
        '''&lt;device name=&quot;iPad 4&quot; version=&quot;6.0,6.0.1,6.1,6.1.2,6.1.3,7.0,7.0.2,7.0.3,7.0.4,7.0.6,7.1,7.1.1,7.1.2&quot;/&gt;
        '''&lt;device name=&quot;iPad Air&quot; version=&quot;7.0.3,7.0.4,7.0.6,7.1,7.1.1,7.1.2&quot;/&gt;
        '''&lt;device name=&quot;iPad Mini&quot; version=&quot;6.0,6.0.1,6.0.2,6.1,6.1.2,6.1.3,7.0,7.0.2,7.0.3,7.0.4,7.0.6,7.1,7.1.1,7.1.2&quot;/&gt;
        '''&lt;dev [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property ios() As String
            Get
                Return ResourceManager.GetString("ios", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;root&gt;
        '''&lt;jailbreak name=&quot;iPhone 3GS&quot; version=&quot;6.0,6.0.1,6.1,6.1.2&quot; tool=&quot;evasi0n&quot;/&gt;
        '''&lt;jailbreak name=&quot;iPhone 3GS&quot; version=&quot;6.1.3,6.1.6&quot; tool=&quot;p0sixspwn&quot;/&gt;
        '''
        '''&lt;jailbreak name=&quot;iPhone 4&quot; version=&quot;6.0,6.0.1,6.1,6.1.2&quot; tool=&quot;evasi0n&quot;/&gt;
        '''&lt;jailbreak name=&quot;iPhone 4&quot; version=&quot;6.1.3&quot; tool=&quot;p0sixspwn&quot;/&gt;
        '''&lt;jailbreak name=&quot;iPhone 4&quot; version=&quot;7.0,7.0.2,7.0.3,7.0.4,7.0.6&quot; tool=&quot;evasi0n7&quot;/&gt;
        '''&lt;jailbreak name=&quot;iPhone 4&quot; version=&quot;7.1,7.1.1,7.1.2&quot; tool=&quot;pangu&quot;/&gt;
        '''
        '''&lt;jailbreak name=&quot;iPhone 4S&quot; version=&quot;6.0,6.0.1,6.1,6.1.1,6.1. [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property jailbreak() As String
            Get
                Return ResourceManager.GetString("jailbreak", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to                      GNU GENERAL PUBLIC LICENSE
        '''                       Version 3, 29 June 2007
        '''
        ''' Copyright (C) 2007 Free Software Foundation, Inc. &lt;http://fsf.org/&gt;
        ''' Everyone is permitted to copy and distribute verbatim copies
        ''' of this license document, but changing it is not allowed.
        '''
        '''                            Preamble
        '''
        '''  The GNU General Public License is a free, copyleft license for
        '''software and other kinds of works.
        '''
        '''  The licenses for most software and other practical works are designed
        '''t [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property LICENSE() As String
            Get
                Return ResourceManager.GetString("LICENSE", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property p0sixpwn() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("p0sixpwn", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property pangu() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("pangu", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
