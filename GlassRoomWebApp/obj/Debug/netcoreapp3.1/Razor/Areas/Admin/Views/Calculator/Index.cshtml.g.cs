#pragma checksum "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d440b154322eb3090596fbce6e55d03a17d3899"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Calculator_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Calculator/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d440b154322eb3090596fbce6e55d03a17d3899", @"/Areas/Admin/Views/Calculator/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f034e4ea8ad505814bf912f72f3b2e6d96f7891", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Calculator_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserOrder>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline-block;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Calculator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
  
    //var count = @Model.Count();
    var DateVal = @DateTime.Today.Date;
    int CheckToday = 0;
    string Minute;

    string color;
    string shType = "Ошибка";

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
#line 25 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
        Write(DateVal.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(") :</h2>\r\n\r\n");
#nullable restore
#line 27 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
 if (Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n");
#nullable restore
#line 30 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
         foreach (UserOrder entity in Model.Reverse())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
             if (@entity.DateUPAdded.Date == DateVal)
            {
                CheckToday = CheckToday + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li style=\"cursor: pointer\">\r\n            <a style=\"font-size: 18px;\">\r\n");
#nullable restore
#line 37 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                 if (@entity.DateUPAdded.Minute < 10)
                    Minute = "0" + (@entity.DateUPAdded.Minute).ToString();
                else
                    Minute = (@entity.DateUPAdded.Minute).ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 42 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
           Write(entity.DateUPAdded.Hour);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 42 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                                    Write(Minute);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <i style=\"font-size: 14px;\"> ");
#nullable restore
#line 43 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                                        Write(entity.DateUPAdded.Date.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n            </a>\r\n            <a class=\"UserDate\">");
#nullable restore
#line 45 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                           Write(entity.UName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>");
#nullable restore
#line 45 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                                            Write(entity.ShPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &#8381;</p> <br />");
#nullable restore
#line 45 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                                                                              Write(entity.PhoneNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n");
#nullable restore
#line 47 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
             if (@entity.Checked == true)
                color = "#0ca926";
            else
                color = "#a3b6c5";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d440b154322eb3090596fbce6e55d03a17d38999229", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1797, "\"", 1815, 1);
#nullable restore
#line 53 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
WriteAttributeValue("", 1805, entity.Id, 1805, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"submit\" value=\"&#10003;\"");
                BeginWriteAttribute("style", " style=\"", 1872, "\"", 1898, 2);
                WriteAttributeValue("", 1880, "background:", 1880, 11, true);
#nullable restore
#line 54 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
WriteAttributeValue(" ", 1891, color, 1892, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ;");
                BeginWriteAttribute("onclick", " onclick=\"", 1901, "\"", 1953, 3);
                WriteAttributeValue("", 1911, "document.getElementById(\'form-", 1911, 30, true);
#nullable restore
#line 54 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
WriteAttributeValue("", 1941, entity.Id, 1941, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1951, "\')", 1951, 2, true);
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
#line 52 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
AddHtmlAttributeValue("", 1659, entity.Id, 1659, 10, false);

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
            BeginWriteAttribute("onclick", " onclick=\"", 2069, "\"", 2114, 5);
            WriteAttributeValue("", 2079, "myFunction(", 2079, 11, true);
#nullable restore
#line 57 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
WriteAttributeValue("", 2090, entity.PhoneNum, 2090, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2106, ",", 2106, 1, true);
            WriteAttributeValue(" ", 2107, "this)", 2108, 6, true);
            WriteAttributeValue(" ", 2113, "", 2114, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n            <div class=\"OrderDataSlider\"");
            BeginWriteAttribute("name", " name=\"", 2162, "\"", 2179, 1);
#nullable restore
#line 59 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
WriteAttributeValue("", 2169, entity.Id, 2169, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                <h2>Детали заказа:</h2>\r\n");
#nullable restore
#line 62 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                 if (@entity.ShType == "U")
                {
                    shType = "П-Образная душевая";
                }
                else if (@entity.ShType == "L")
                {
                    shType = "Угловая душевая";
                }
                else
                {
                    shType = "Душевая перегородка";
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <h3>");
#nullable restore
#line 75 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
               Write(shType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <div>\r\n                    <a>Длинна: ");
#nullable restore
#line 77 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                          Write(entity.WidthVal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" мм</a>\r\n                    <a>Ширина: ");
#nullable restore
#line 78 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                          Write(entity.LengthVal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" мм</a>\r\n                    <a>Высота: ");
#nullable restore
#line 79 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                          Write(entity.HeightVal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" мм</a>\r\n\r\n                    <a>Тип: ");
#nullable restore
#line 81 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                       Write(entity.GlassType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    <a>Толщина: ");
#nullable restore
#line 82 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                           Write(entity.GlassTh);

#line default
#line hidden
#nullable disable
            WriteLiteral(" мм</a>\r\n                    <a>Фурнитура: ");
#nullable restore
#line 83 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                             Write(entity.Fittings);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                </div>

                <textarea placeholder=""Детали заказа (заполняется администрацией)""
                          rows=""9"" cols=""40"" class=""areaInput""></textarea>

                <a class=""SliderCloser"" style=""color:rgb(103, 116, 255);
                        text-decoration:underline"">
                    Скрыть подробности
                </a>

            </div>

        </li>
");
#nullable restore
#line 97 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 101 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 104 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
 if (CheckToday == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Сегодня заказы не поступали :(</h1>\r\n");
#nullable restore
#line 107 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Ранее:</h2>\r\n\r\n");
#nullable restore
#line 111 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
 if (Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n");
#nullable restore
#line 114 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
         foreach (UserOrder entity in Model.Reverse())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
             if (@entity.DateUPAdded.Date != DateVal)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li style=\"cursor: pointer\">\r\n            <a style=\"font-size: 18px;\">\r\n\r\n");
#nullable restore
#line 121 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                 if (@entity.DateUPAdded.Minute < 10)
                    Minute = "0" + (@entity.DateUPAdded.Minute).ToString();
                else
                    Minute = (@entity.DateUPAdded.Minute).ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 126 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
           Write(entity.DateUPAdded.Hour);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 126 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                                    Write(Minute);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <i style=\"font-size: 14px;\"> ");
#nullable restore
#line 127 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                                        Write(entity.DateUPAdded.Date.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n            </a>\r\n            <a class=\"UserDate\">");
#nullable restore
#line 129 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                           Write(entity.UName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>");
#nullable restore
#line 129 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                                            Write(entity.ShPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &#8381;</p> <br />");
#nullable restore
#line 129 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                                                                              Write(entity.PhoneNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n");
#nullable restore
#line 131 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
             if (@entity.Checked == true)
                color = "#0ca926";
            else
                color = "#a3b6c5";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d440b154322eb3090596fbce6e55d03a17d389921883", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 4644, "\"", 4662, 1);
#nullable restore
#line 137 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
WriteAttributeValue("", 4652, entity.Id, 4652, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"submit\" value=\"&#10003;\"");
                BeginWriteAttribute("style", " style=\"", 4719, "\"", 4745, 2);
                WriteAttributeValue("", 4727, "background:", 4727, 11, true);
#nullable restore
#line 138 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
WriteAttributeValue(" ", 4738, color, 4739, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ;");
                BeginWriteAttribute("onclick", " onclick=\"", 4748, "\"", 4800, 3);
                WriteAttributeValue("", 4758, "document.getElementById(\'form-", 4758, 30, true);
#nullable restore
#line 138 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
WriteAttributeValue("", 4788, entity.Id, 4788, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4798, "\')", 4798, 2, true);
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
#line 136 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
AddHtmlAttributeValue("", 4506, entity.Id, 4506, 10, false);

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
            BeginWriteAttribute("onclick", " onclick=\"", 4916, "\"", 4960, 4);
            WriteAttributeValue("", 4926, "myFunction(", 4926, 11, true);
#nullable restore
#line 141 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
WriteAttributeValue("", 4937, entity.PhoneNum, 4937, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4953, ",", 4953, 1, true);
            WriteAttributeValue(" ", 4954, "this)", 4955, 6, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n            <div class=\"OrderDataSlider\"");
            BeginWriteAttribute("name", " name=\"", 5008, "\"", 5025, 1);
#nullable restore
#line 143 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
WriteAttributeValue("", 5015, entity.Id, 5015, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                <h2>Детали заказа:</h2>\r\n");
#nullable restore
#line 146 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                 if (@entity.ShType == "U")
                {
                    shType = "П-Образная душевая";
                }
                else if (@entity.ShType == "L")
                {
                    shType = "Угловая душевая";
                }
                else
                {
                    shType = "Душевая перегородка";
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <h3>");
#nullable restore
#line 159 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
               Write(shType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <div>\r\n                    <a>Длинна: ");
#nullable restore
#line 161 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                          Write(entity.WidthVal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" мм</a>\r\n                    <a>Ширина: ");
#nullable restore
#line 162 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                          Write(entity.LengthVal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" мм</a>\r\n                    <a>Высота: ");
#nullable restore
#line 163 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                          Write(entity.HeightVal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" мм</a>\r\n\r\n                    <a>Тип: ");
#nullable restore
#line 165 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                       Write(entity.GlassType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    <a>Толщина: ");
#nullable restore
#line 166 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                           Write(entity.GlassTh);

#line default
#line hidden
#nullable disable
            WriteLiteral(" мм</a>\r\n                    <a>Фурнитура: ");
#nullable restore
#line 167 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
                             Write(entity.Fittings);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                </div>

                <textarea placeholder=""Детали заказа (заполняется администрацией)""
                          rows=""9"" cols=""40"" class=""areaInput""></textarea>

                <a class=""SliderCloser"" style=""color:rgb(103, 116, 255);
                            text-decoration:underline"">
                    Скрыть подробности
                </a>

            </div>

        </li>
");
#nullable restore
#line 181 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 181 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
            WriteLiteral("    <style>\r\n\r\n    </style>\r\n");
#nullable restore
#line 188 "D:\GR_WEB\GlassRoom\GlassRoomWebApp\Areas\Admin\Views\Calculator\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserOrder>> Html { get; private set; }
    }
}
#pragma warning restore 1591
