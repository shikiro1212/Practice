Imports System.ComponentModel.DataAnnotations

Public Class ExternalLoginConfirmationViewModel
    <Required>
    <Display(Name:="用户名")>
    Public Property UserName As String
End Class

Public Class ManageUserViewModel
    <Required>
    <DataType(DataType.Password)>
    <Display(Name:="当前密码")>
    Public Property OldPassword As String

    <Required>
    <StringLength(100, ErrorMessage:="{0} 必须至少包含 {2} 个字符。", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="新密码")>
    Public Property NewPassword As String

    <DataType(DataType.Password)>
    <Display(Name:="确认新密码")>
    <Compare("NewPassword", ErrorMessage:="新密码和确认密码不匹配。")>
    Public Property ConfirmPassword As String
End Class

Public Class LoginViewModel
    <Required>
    <Display(Name:="用户名")>
    Public Property UserName As String

    <Required>
    <DataType(DataType.Password)>
    <Display(Name:="密码")>
    Public Property Password As String

    <Display(Name:="记住我?")>
    Public Property RememberMe As Boolean
End Class

Public Class RegisterViewModel
    <Required>
    <Display(Name:="用户名")>
    Public Property UserName As String

    <Required>
    <StringLength(100, ErrorMessage:="{0} 必须至少包含 {2} 个字符。", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="密码")>
    Public Property Password As String

    <DataType(DataType.Password)>
    <Display(Name:="确认密码")>
    <Compare("Password", ErrorMessage:="密码和确认密码不匹配。")>
    Public Property ConfirmPassword As String
End Class
