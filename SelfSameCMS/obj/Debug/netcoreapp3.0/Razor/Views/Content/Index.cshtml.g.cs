#pragma checksum "F:\opennetcore\SelfSameCMS\Views\Content\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "851a44aa63521005430912a7a17d963034a50f35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Content_Index), @"mvc.1.0.view", @"/Views/Content/Index.cshtml")]
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
#line 1 "F:\opennetcore\SelfSameCMS\Views\_ViewImports.cshtml"
using SelfSameCMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\opennetcore\SelfSameCMS\Views\_ViewImports.cshtml"
using SelfSameCMS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\opennetcore\SelfSameCMS\Views\Content\Index.cshtml"
using Humanizer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"851a44aa63521005430912a7a17d963034a50f35", @"/Views/Content/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbc92132c72b431b2af64e94981e81b0fa27ed93", @"/Views/_ViewImports.cshtml")]
    public class Views_Content_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "F:\opennetcore\SelfSameCMS\Views\Content\Index.cshtml"
  
    ViewData["Title"] = "内容列表";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"panel panel-default todo-panel\">\r\n    <div class=\"panel-heading\">");
#nullable restore
#line 9 "F:\opennetcore\SelfSameCMS\Views\Content\Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

    <table class=""table table-hover"">
        <thead>
            <tr>
                <td> <input type=""checkbox"" class=""done-checkbox""></td>
                <td>序号</td>
                <td>标题</td>
                <td>内容</td>
                <td>添加时间</td>
            </tr>
        </thead>

");
#nullable restore
#line 22 "F:\opennetcore\SelfSameCMS\Views\Content\Index.cshtml"
         foreach (var item in Model.Contents)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <input type=\"checkbox\" class=\"done-checkbox\">\r\n                </td>\r\n                <td>");
#nullable restore
#line 28 "F:\opennetcore\SelfSameCMS\Views\Content\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "F:\opennetcore\SelfSameCMS\Views\Content\Index.cshtml"
               Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "F:\opennetcore\SelfSameCMS\Views\Content\Index.cshtml"
               Write(item.content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "F:\opennetcore\SelfSameCMS\Views\Content\Index.cshtml"
               Write(item.add_time.Humanize());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 34 "F:\opennetcore\SelfSameCMS\Views\Content\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
