#pragma checksum "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Views\Shared\MetatagsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38b7692baa8c1b07f62c0f0298feee56b4417d75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MetatagsPartial), @"mvc.1.0.view", @"/Views/Shared/MetatagsPartial.cshtml")]
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
#line 2 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Views\_ViewImports.cshtml"
using GlassRoomWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Views\_ViewImports.cshtml"
using GlassRoomWebApp.Models.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Views\_ViewImports.cshtml"
using GlassRoomWebApp.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Views\Shared\MetatagsPartial.cshtml"
using GlassRoomWebApp.Service;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38b7692baa8c1b07f62c0f0298feee56b4417d75", @"/Views/Shared/MetatagsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2973ce7072490036c84e0eb25e11e581debdf236", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MetatagsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<meta charset=\"utf-8\">\r\n<meta name=\"viewport\" content=\"width = device-width\">\r\n");
#nullable restore
#line 4 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Titele != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 6 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Views\Shared\MetatagsPartial.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 7 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Views\Shared\MetatagsPartial.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 10 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Views\Shared\MetatagsPartial.cshtml"
      Write(Config.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title> \r\n");
#nullable restore
#line 11 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Description != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"description\"");
            BeginWriteAttribute("content", " content=\"", 304, "\"", 334, 1);
#nullable restore
#line 15 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Views\Shared\MetatagsPartial.cshtml"
WriteAttributeValue("", 314, ViewBag.Description, 314, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 16 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 18 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Keywords != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"keywords\"");
            BeginWriteAttribute("content", " content=\"", 405, "\"", 432, 1);
#nullable restore
#line 20 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Views\Shared\MetatagsPartial.cshtml"
WriteAttributeValue("", 415, ViewBag.Keywords, 415, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 21 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
