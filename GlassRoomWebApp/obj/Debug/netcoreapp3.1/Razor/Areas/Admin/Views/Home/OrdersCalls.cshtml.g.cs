#pragma checksum "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f08b0deb9e0e1ae3428f2a182177387effd51870"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_OrdersCalls), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/OrdersCalls.cshtml")]
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
#line 2 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\_ViewImports.cshtml"
using GlassRoomWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\_ViewImports.cshtml"
using GlassRoomWebApp.Domain.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f08b0deb9e0e1ae3428f2a182177387effd51870", @"/Areas/Admin/Views/Home/OrdersCalls.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f034e4ea8ad505814bf912f72f3b2e6d96f7891", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_OrdersCalls : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserPhone>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline-block;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "OrdersCalls", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Check", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
  
    var count = @Model.Count();
    var DateVal = @DateTime.Today.Date;
    int CheckToday = 0;
    string Minute;

    string color;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script>
    function myFunction(str, obj) {
        const el = document.createElement('textarea');
        el.value = str;
        document.body.appendChild(el);
        el.select();
        document.execCommand('copy');
        document.body.removeChild(el);
        $('.UsPhoneCopy').css('background', 'rgb(248, 99, 99)');
        $(obj).css('background', '#0ca926');
    }
</script>

<h2>Сегодня (");
#nullable restore
#line 25 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
        Write(DateVal.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(") :</h2>\r\n\r\n");
#nullable restore
#line 27 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
 if (Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n");
#nullable restore
#line 30 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
         foreach (UserPhone entity in Model.Reverse())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
             if (@entity.DateUPAdded.Date == DateVal)
            {
                CheckToday = CheckToday + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <a style=\"font-size: 18px;\">\r\n");
#nullable restore
#line 37 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
                 if (@entity.DateUPAdded.Minute < 10)
                    Minute = "0" + (@entity.DateUPAdded.Minute).ToString();
                else
                    Minute = (@entity.DateUPAdded.Minute).ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 42 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
           Write(entity.DateUPAdded.Hour);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 42 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
                                    Write(Minute);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <i style=\"font-size: 14px;\"> ");
#nullable restore
#line 43 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
                                        Write(entity.DateUPAdded.Date.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n            </a>\r\n            <a class=\"UserDate\">");
#nullable restore
#line 45 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
                           Write(entity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />");
#nullable restore
#line 45 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
                                             Write(entity.PhoneNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n");
#nullable restore
#line 47 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
             if(@entity.Checked == true)
                color = "#0ca926";
            else
                color = "#a3b6c5";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f08b0deb9e0e1ae3428f2a182177387effd518708863", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1709, "\"", 1727, 1);
#nullable restore
#line 53 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
WriteAttributeValue("", 1717, entity.Id, 1717, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"submit\" value=\"&#10003;\"");
                BeginWriteAttribute("style", " style=\"", 1784, "\"", 1810, 2);
                WriteAttributeValue("", 1792, "background:", 1792, 11, true);
#nullable restore
#line 54 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
WriteAttributeValue(" ", 1803, color, 1804, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(";");
                BeginWriteAttribute("onclick", " onclick=\"", 1812, "\"", 1864, 3);
                WriteAttributeValue("", 1822, "document.getElementById(\'form-", 1822, 30, true);
#nullable restore
#line 54 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
WriteAttributeValue("", 1852, entity.Id, 1852, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1862, "\')", 1862, 2, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 52 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
AddHtmlAttributeValue("", 1570, entity.Id, 1570, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            <input type=\"submit\" name=\"delButton\" value=\"&#128196;\" class=\"UsPhoneCopy\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1980, "\"", 2025, 5);
            WriteAttributeValue("", 1990, "myFunction(", 1990, 11, true);
#nullable restore
#line 57 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
WriteAttributeValue("", 2001, entity.PhoneNum, 2001, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2017, ",", 2017, 1, true);
            WriteAttributeValue(" ", 2018, "this)", 2019, 6, true);
            WriteAttributeValue(" ", 2024, "", 2025, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </li>\r\n");
#nullable restore
#line 59 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 62 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 65 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
 if (CheckToday == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Сегодня заказы на звонки не поступали :(</h1>\r\n");
#nullable restore
#line 68 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Ранее:</h2>\r\n\r\n");
#nullable restore
#line 72 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
 if (Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n");
#nullable restore
#line 75 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
         foreach (UserPhone entity in Model.Reverse())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
             if (@entity.DateUPAdded.Date != DateVal)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <a style=\"font-size: 18px;\">\r\n\r\n");
#nullable restore
#line 82 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
                 if (@entity.DateUPAdded.Minute < 10)
                    Minute = "0" + (@entity.DateUPAdded.Minute).ToString();
                else
                    Minute = (@entity.DateUPAdded.Minute).ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 87 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
           Write(entity.DateUPAdded.Hour);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 87 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
                                    Write(Minute);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <i style=\"font-size: 14px;\"> ");
#nullable restore
#line 88 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
                                        Write(entity.DateUPAdded.Date.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n            </a>\r\n            <a class=\"UserDate\">");
#nullable restore
#line 90 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
                           Write(entity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />");
#nullable restore
#line 90 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
                                             Write(entity.PhoneNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n");
#nullable restore
#line 92 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
             if (@entity.Checked == true)
                color = "#0ca926";
            else
                color = "#a3b6c5";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f08b0deb9e0e1ae3428f2a182177387effd5187017755", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 3222, "\"", 3240, 1);
#nullable restore
#line 98 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
WriteAttributeValue("", 3230, entity.Id, 3230, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"submit\" value=\"&#10003;\"");
                BeginWriteAttribute("style", " style=\"", 3297, "\"", 3323, 2);
                WriteAttributeValue("", 3305, "background:", 3305, 11, true);
#nullable restore
#line 99 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
WriteAttributeValue(" ", 3316, color, 3317, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ;");
                BeginWriteAttribute("onclick", " onclick=\"", 3326, "\"", 3378, 3);
                WriteAttributeValue("", 3336, "document.getElementById(\'form-", 3336, 30, true);
#nullable restore
#line 99 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
WriteAttributeValue("", 3366, entity.Id, 3366, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3376, "\')", 3376, 2, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 97 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
AddHtmlAttributeValue("", 3083, entity.Id, 3083, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            <input type=\"submit\" name=\"delButton\" value=\"&#128196;\" class=\"UsPhoneCopy\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3494, "\"", 3538, 4);
            WriteAttributeValue("", 3504, "myFunction(", 3504, 11, true);
#nullable restore
#line 102 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
WriteAttributeValue("", 3515, entity.PhoneNum, 3515, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3531, ",", 3531, 1, true);
            WriteAttributeValue(" ", 3532, "this)", 3533, 6, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </li>\r\n");
#nullable restore
#line 104 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 107 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Home\OrdersCalls.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserPhone>> Html { get; private set; }
    }
}
#pragma warning restore 1591
