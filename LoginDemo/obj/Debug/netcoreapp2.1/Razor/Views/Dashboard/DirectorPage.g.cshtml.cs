#pragma checksum "E:\MyApps\LoginArticle\Part2\LoginDemo\LoginDemo\Views\Dashboard\DirectorPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17e1402083739c7c6ffe7d8b48dff4d31ee3e9d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_DirectorPage), @"mvc.1.0.view", @"/Views/Dashboard/DirectorPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/DirectorPage.cshtml", typeof(AspNetCore.Views_Dashboard_DirectorPage))]
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
#line 1 "E:\MyApps\LoginArticle\Part2\LoginDemo\LoginDemo\Views\_ViewImports.cshtml"
using LoginDemo;

#line default
#line hidden
#line 2 "E:\MyApps\LoginArticle\Part2\LoginDemo\LoginDemo\Views\_ViewImports.cshtml"
using LoginDemo.Models;

#line default
#line hidden
#line 4 "E:\MyApps\LoginArticle\Part2\LoginDemo\LoginDemo\Views\_ViewImports.cshtml"
using LoginDemo.CustomAttributes;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17e1402083739c7c6ffe7d8b48dff4d31ee3e9d3", @"/Views/Dashboard/DirectorPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea1c9f2e549218554a4188d9097e20f5262ce186", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_DirectorPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\MyApps\LoginArticle\Part2\LoginDemo\LoginDemo\Views\Dashboard\DirectorPage.cshtml"
  
    ViewData["Title"] = "DirectorPage";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(97, 207, true);
            WriteLiteral("\r\n<div style=\"padding-top:50px;\"></div>\r\n<h2>Director Page</h2>\r\n\r\n<div class=\"row\">\r\n    <div style=\"padding:50px;\">\r\n        <div style=\"font-size:large;\">Welcome Director <span style=\"color:forestgreen;\">");
            EndContext();
            BeginContext(305, 18, false);
#line 12 "E:\MyApps\LoginArticle\Part2\LoginDemo\LoginDemo\Views\Dashboard\DirectorPage.cshtml"
                                                                                   Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(323, 97, true);
            WriteLiteral("</span></div>\r\n    </div>\r\n    <div style=\"padding-top:10px;\">\r\n        <div style=\"color:gray;\">");
            EndContext();
            BeginContext(421, 15, false);
#line 15 "E:\MyApps\LoginArticle\Part2\LoginDemo\LoginDemo\Views\Dashboard\DirectorPage.cshtml"
                            Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(436, 30, true);
            WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
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
