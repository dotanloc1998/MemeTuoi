#pragma checksum "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Views\Error\HandleErrorCode.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d7998b5fc7171e941e785ec476e0e9a2c7d705c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Error_HandleErrorCode), @"mvc.1.0.view", @"/Views/Error/HandleErrorCode.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Error/HandleErrorCode.cshtml", typeof(AspNetCore.Views_Error_HandleErrorCode))]
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
#line 1 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Views\_ViewImports.cshtml"
using MemeTuoi;

#line default
#line hidden
#line 2 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Views\_ViewImports.cshtml"
using MemeTuoi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d7998b5fc7171e941e785ec476e0e9a2c7d705c", @"/Views/Error/HandleErrorCode.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f65aec42172b1f4d18d526517cab3e06a5a4cbb", @"/Views/_ViewImports.cshtml")]
    public class Views_Error_HandleErrorCode : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<img class=\"img-fluid card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 35, "\"", 62, 1);
#line 1 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Views\Error\HandleErrorCode.cshtml"
WriteAttributeValue("", 41, ViewBag.ErrorMessage, 41, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(63, 1, true);
            WriteLiteral(">");
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
