﻿@ModelType LoginViewModel

@Code
    ViewBag.Title = "登录"
End Code

<h2>@ViewBag.Title。</h2>
<div class="row">
    <div class="col-md-8">
        <section id="loginForm">
            @Using Html.BeginForm("Login", "Account", New With { .ReturnUrl = ViewBag.ReturnUrl }, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
                @Html.AntiForgeryToken()
                @<text>
                <h4>使用本地帐户登录。</h4>
                <hr />
                @Html.ValidationSummary(True)
                <div class="form-group">
                    @Html.LabelFor(Function(m) m.UserName, New With {.class = "col-md-2 control-label"})
                    <div class="col-md-10">
                        @Html.TextBoxFor(Function(m) m.UserName, New With {.class = "form-control"})
                        @Html.ValidationMessageFor(Function(m) m.UserName)
                    </div>
                </div>
                <div class="form-group">
                    @Html.LabelFor(Function(m) m.Password, New With {.class = "col-md-2 control-label"})
                    <div class="col-md-10">
                        @Html.PasswordFor(Function(m) m.Password, New With {.class = "form-control"})
                        @Html.ValidationMessageFor(Function(m) m.Password)
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <div class="checkbox">
                            @Html.CheckBoxFor(Function(m) m.RememberMe)
                            @Html.LabelFor(Function(m) m.RememberMe)
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <input type="submit" value="登录" class="btn btn-default" />
                    </div>
                </div>
                <p>
                    @Html.ActionLink("注册", "Register")(如果你没有本地帐户)。
                </p>
                </text>
            End Using
        </section>
    </div>
    <div class="col-md-4">
        <section id="socialLoginForm">
            @Html.Partial("_ExternalLoginsListPartial", New With {.Action = "ExternalLogin", .ReturnUrl = ViewBag.ReturnUrl})
        </section>
    </div>
</div>
@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
