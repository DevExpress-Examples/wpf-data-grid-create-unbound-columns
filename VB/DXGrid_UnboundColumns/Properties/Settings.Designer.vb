'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Namespace DXGrid_UnboundColumns.Properties

    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")>
    Friend NotInheritable Partial Class Settings
        Inherits Global.System.Configuration.ApplicationSettingsBase

        Private Shared defaultInstance As DXGrid_UnboundColumns.Properties.Settings = CType((Global.System.Configuration.ApplicationSettingsBase.Synchronized(New DXGrid_UnboundColumns.Properties.Settings())), DXGrid_UnboundColumns.Properties.Settings)

        Public Shared ReadOnly Property [Default] As Settings
            Get
                Return DXGrid_UnboundColumns.Properties.Settings.defaultInstance
            End Get
        End Property

        <Global.System.Configuration.ApplicationScopedSettingAttribute()>
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
        <Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString)>
        <Global.System.Configuration.DefaultSettingValueAttribute("Provider=(localdb)\v11.0;Data Source=|DataDirectory|\nwind.mdb;Persist Security I" & "nfo=True")>
        Public ReadOnly Property nwindConnectionString As String
            Get
                Return(CStr((Me("nwindConnectionString"))))
            End Get
        End Property

        <Global.System.Configuration.ApplicationScopedSettingAttribute()>
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
        <Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString)>
        <Global.System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\NORTHWND.MDF;Integra" & "ted Security=True")>
        Public ReadOnly Property NORTHWNDConnectionString As String
            Get
                Return(CStr((Me("NORTHWNDConnectionString"))))
            End Get
        End Property
    End Class
End Namespace
