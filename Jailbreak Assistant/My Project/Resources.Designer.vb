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
        '''  Looks up a localized string similar to &lt;root&gt;
        '''&lt;device name=&quot;iPhone 2G&quot; version=&quot;3.1.3&quot;/&gt;
        '''&lt;device name=&quot;iPhone 3G&quot; version=&quot;3.1.3,4.0,4.0.1,4.0.2,4.1,4.2.1&quot;/&gt;
        '''&lt;device name=&quot;iPhone 3GS&quot; version=&quot;3.1.3,4.0,4.0.1,4.0.2,4.1,4.2.1,4.3,4.3.1,4.3.2,4.3.3,4.3.4,4.3.5,5.0,5.0.1,5.1,5.1.1,6.0,6.0.1,6.1,6.1.2,6.1.3,6.1.6&quot;/&gt;
        '''&lt;device name=&quot;iPhone 4&quot; version=&quot;4.0,4.0.1,4.0.2,4.1,4.2.1,4.3,4.3.1,4.3.2,4.3.3,4.3.4,4.3.5,5.0,5.0.1,5.1,5.1.1,6.0,6.0.1,6.1,6.1.2,6.1.3,7.0,7.0.1,7.0.2,7.0.3,7.0.4,7.0.6&quot;/&gt;
        '''&lt;device name=&quot;iPhone 4S&quot; version=&quot;5.0,5.0.1,5.1,5.1.1,6. [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property ios() As String
            Get
                Return ResourceManager.GetString("ios", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Public ReadOnly Property LICENSE() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("LICENSE", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
    End Module
End Namespace
