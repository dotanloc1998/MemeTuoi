#pragma checksum "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\Home\ViewMeme.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b841aca620ffeb502a287a3509ee4b94b1e344bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_ViewMeme), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/ViewMeme.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Home/ViewMeme.cshtml", typeof(AspNetCore.Areas_Admin_Views_Home_ViewMeme))]
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
#line 1 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\_ViewImports.cshtml"
using MemeTuoi;

#line default
#line hidden
#line 2 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\_ViewImports.cshtml"
using MemeTuoi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b841aca620ffeb502a287a3509ee4b94b1e344bf", @"/Areas/Admin/Views/Home/ViewMeme.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f65aec42172b1f4d18d526517cab3e06a5a4cbb", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_ViewMeme : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Meme>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\Home\ViewMeme.cshtml"
  
    ViewData["Title"] = "ViewMeme";

#line default
#line hidden
            BeginContext(70, 50, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h2>Số lượng Meme: ");
            EndContext();
            BeginContext(121, 13, false);
#line 7 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\Home\ViewMeme.cshtml"
                  Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(134, 317, true);
            WriteLiteral(@"</h2>
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Meme Name</th>
                <th>Meme Url</th>
                <th>Meme Category</th>
                <th>Meme Upvotes</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 19 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\Home\ViewMeme.cshtml"
             foreach (var item in @Model)
            {

#line default
#line hidden
            BeginContext(509, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(556, 11, false);
#line 22 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\Home\ViewMeme.cshtml"
                   Write(item.MemeID);

#line default
#line hidden
            EndContext();
            BeginContext(567, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(599, 13, false);
#line 23 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\Home\ViewMeme.cshtml"
                   Write(item.MemeName);

#line default
#line hidden
            EndContext();
            BeginContext(612, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(644, 15, false);
#line 24 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\Home\ViewMeme.cshtml"
                   Write(item.MemeImgUrl);

#line default
#line hidden
            EndContext();
            BeginContext(659, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(691, 17, false);
#line 25 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\Home\ViewMeme.cshtml"
                   Write(item.MemeCategory);

#line default
#line hidden
            EndContext();
            BeginContext(708, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(740, 16, false);
#line 26 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\Home\ViewMeme.cshtml"
                   Write(item.MemeUpvotes);

#line default
#line hidden
            EndContext();
            BeginContext(756, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 28 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\Home\ViewMeme.cshtml"
            }

#line default
#line hidden
            BeginContext(801, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Meme>> Html { get; private set; }
    }
}
#pragma warning restore 1591