#pragma checksum "D:\GlassRoom\GlassRoomWebApp\Views\Shared\CallPopUpShared.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb96fb5cc81e4ef6fc73d981360d7e0e7f06a718"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_CallPopUpShared), @"mvc.1.0.view", @"/Views/Shared/CallPopUpShared.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "D:\GlassRoom\GlassRoomWebApp\Views\_ViewImports.cshtml"
using GlassRoomWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GlassRoom\GlassRoomWebApp\Views\_ViewImports.cshtml"
using GlassRoomWebApp.Models.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GlassRoom\GlassRoomWebApp\Views\_ViewImports.cshtml"
using GlassRoomWebApp.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GlassRoom\GlassRoomWebApp\Views\_ViewImports.cshtml"
using GlassRoomWebApp.Domain.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb96fb5cc81e4ef6fc73d981360d7e0e7f06a718", @"/Views/Shared/CallPopUpShared.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2973ce7072490036c84e0eb25e11e581debdf236", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_CallPopUpShared : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!--
<img src=""~/images/close.svg"" class=""close_svg"" width=""13px"">
<center><a>Оставь номер тут, а мы<br>перезвоним!</a></center>
<form asp-area=""Home"" asp-controller=""UserPhone"" asp-action=""UserPhoneEdit"" method=""post"" enctype=""multipart/form-data"">
    <div class=""input"">
        <div asp-validation-summary=""All""></div>
        <div class=""pop_input"">
            <input type=""text"" asp-for=""Name"" placeholder=""Имя:""></input>
            <span asp-validation-for=""Name""></span>
        </div>

        <div class=""pop_input"">
            <input type=""phone"" asp-for=""PhoneNum"" placeholder=""Телефон:""></input>
            <span asp-validation-for=""PhoneNum""></span>
        </div>

        <div class=""pop_input"">
            <input type=""submit""></input>
        </div>
    </div>
</form>
<div class=""mail_lb"">
    <a>Также можно написать нам на почту:</a>
    <a id=""mail_copy"" href=""mailto:steklopro23@mail.ru"">steklopro23@mail.ru</a>
</div>
   -->
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
