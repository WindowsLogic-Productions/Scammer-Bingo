﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property ScamReset() As String
            Get
                Return CType(Me("ScamReset"),String)
            End Get
            Set
                Me("ScamReset") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("This is looking like a scam, if you don't believe it, keep going.")>  _
        Public Property MsgBox1() As String
            Get
                Return CType(Me("MsgBox1"),String)
            End Get
            Set
                Me("MsgBox1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("This is a scam, get out of there while you can, remember to say he's a scammer!")>  _
        Public Property MsgBox2() As String
            Get
                Return CType(Me("MsgBox2"),String)
            End Get
            Set
                Me("MsgBox2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("DodgerBlue")>  _
        Public Property CustomColour() As Global.System.Drawing.Color
            Get
                Return CType(Me("CustomColour"),Global.System.Drawing.Color)
            End Get
            Set
                Me("CustomColour") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0 ")>  _
        Public Property CCE() As String
            Get
                Return CType(Me("CCE"),String)
            End Get
            Set
                Me("CCE") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("C:\Users\ceo\Google Drive\Tim\My Pictures\Desktop Wallpaper\Windows 7 Legacy.png")>  _
        Public Property CB1() As String
            Get
                Return CType(Me("CB1"),String)
            End Get
            Set
                Me("CB1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property HubSounds() As String
            Get
                Return CType(Me("HubSounds"),String)
            End Get
            Set
                Me("HubSounds") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property DHBHUC() As String
            Get
                Return CType(Me("DHBHUC"),String)
            End Get
            Set
                Me("DHBHUC") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property MsgBox() As String
            Get
                Return CType(Me("MsgBox"),String)
            End Get
            Set
                Me("MsgBox") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property Updates() As String
            Get
                Return CType(Me("Updates"),String)
            End Get
            Set
                Me("Updates") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Fake English Name")>  _
        Public Property BingoSlot1() As String
            Get
                Return CType(Me("BingoSlot1"),String)
            End Get
            Set
                Me("BingoSlot1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Windows Key + R")>  _
        Public Property BingoSlot2() As String
            Get
                Return CType(Me("BingoSlot2"),String)
            End Get
            Set
                Me("BingoSlot2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Do One Thing")>  _
        Public Property BingoSlot3() As String
            Get
                Return CType(Me("BingoSlot3"),String)
            End Get
            Set
                Me("BingoSlot3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("One Time Charge")>  _
        Public Property BingoSlot4() As String
            Get
                Return CType(Me("BingoSlot4"),String)
            End Get
            Set
                Me("BingoSlot4") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Six Digit Code")>  _
        Public Property BingoSlot5() As String
            Get
                Return CType(Me("BingoSlot5"),String)
            End Get
            Set
                Me("BingoSlot5") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Wiruses")>  _
        Public Property BingoSlot6() As String
            Get
                Return CType(Me("BingoSlot6"),String)
            End Get
            Set
                Me("BingoSlot6") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Network Security")>  _
        Public Property BingoSlot7() As String
            Get
                Return CType(Me("BingoSlot7"),String)
            End Get
            Set
                Me("BingoSlot7") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Command Prompt")>  _
        Public Property BingoSlot8() As String
            Get
                Return CType(Me("BingoSlot8"),String)
            End Get
            Set
                Me("BingoSlot8") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Each and Everything")>  _
        Public Property BingoSlot9() As String
            Get
                Return CType(Me("BingoSlot9"),String)
            End Get
            Set
                Me("BingoSlot9") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Dablu Dablu Dablu")>  _
        Public Property BingoSlot10() As String
            Get
                Return CType(Me("BingoSlot10"),String)
            End Get
            Set
                Me("BingoSlot10") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Secure Server")>  _
        Public Property BingoSlot11() As String
            Get
                Return CType(Me("BingoSlot11"),String)
            End Get
            Set
                Me("BingoSlot11") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Stopped Services")>  _
        Public Property BingoSlot12() As String
            Get
                Return CType(Me("BingoSlot12"),String)
            End Get
            Set
                Me("BingoSlot12") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property BingoSlotHandler() As String
            Get
                Return CType(Me("BingoSlotHandler"),String)
            End Get
            Set
                Me("BingoSlotHandler") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property MessageBoxHandler() As String
            Get
                Return CType(Me("MessageBoxHandler"),String)
            End Get
            Set
                Me("MessageBoxHandler") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property AdhocHandler() As String
            Get
                Return CType(Me("AdhocHandler"),String)
            End Get
            Set
                Me("AdhocHandler") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.SCAMbingo1.My.MySettings
            Get
                Return Global.SCAMbingo1.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
