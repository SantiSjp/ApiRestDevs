#pragma checksum "D:\Santi\Desktop\apirestdevs2\ApiRestWebClient\Views\Devs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1eb6269e05864d6626df1664bfc6b27d42c03039"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Devs_Index), @"mvc.1.0.view", @"/Views/Devs/Index.cshtml")]
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
#line 1 "D:\Santi\Desktop\apirestdevs2\ApiRestWebClient\Views\_ViewImports.cshtml"
using ApiRestWebClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Santi\Desktop\apirestdevs2\ApiRestWebClient\Views\_ViewImports.cshtml"
using ApiRestWebClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1eb6269e05864d6626df1664bfc6b27d42c03039", @"/Views/Devs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a20b21659cbba9f8814b54bab62fe856c9b543ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Devs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApiRestWebClient.Models.ViewModels.DevsViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Santi\Desktop\apirestdevs2\ApiRestWebClient\Views\Devs\Index.cshtml"
  
    ViewData["Title"] = "DEVS";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "D:\Santi\Desktop\apirestdevs2\ApiRestWebClient\Views\Devs\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-sm-12\">\r\n        <table id=\"token\" name=\"token\" class=\"table table-responsive table-hover table-striped\">\r\n\r\n            <thead>\r\n                <tr>\r\n                    <th>");
#nullable restore
#line 15 "D:\Santi\Desktop\apirestdevs2\ApiRestWebClient\Views\Devs\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 16 "D:\Santi\Desktop\apirestdevs2\ApiRestWebClient\Views\Devs\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                </tr>\r\n            </thead>\r\n\r\n            <tbody>\r\n");
#nullable restore
#line 21 "D:\Santi\Desktop\apirestdevs2\ApiRestWebClient\Views\Devs\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 24 "D:\Santi\Desktop\apirestdevs2\ApiRestWebClient\Views\Devs\Index.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 25 "D:\Santi\Desktop\apirestdevs2\ApiRestWebClient\Views\Devs\Index.cshtml"
                       Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 27 "D:\Santi\Desktop\apirestdevs2\ApiRestWebClient\Views\Devs\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApiRestWebClient.Models.ViewModels.DevsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
