#pragma checksum "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\MemeCanDuyets\Fresh.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8b01e215380898cd2f23eb9e3f5784e0231155a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_MemeCanDuyets_Fresh), @"mvc.1.0.view", @"/Areas/Admin/Views/MemeCanDuyets/Fresh.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/MemeCanDuyets/Fresh.cshtml", typeof(AspNetCore.Areas_Admin_Views_MemeCanDuyets_Fresh))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8b01e215380898cd2f23eb9e3f5784e0231155a", @"/Areas/Admin/Views/MemeCanDuyets/Fresh.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f65aec42172b1f4d18d526517cab3e06a5a4cbb", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_MemeCanDuyets_Fresh : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MemeTuoi.Data.MemeCanDuyet>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Fresh", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 128, true);
            WriteLiteral("\r\n<h3>Are you sure you want to approve this?</h3>\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(164, 44, false);
#line 8 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\MemeCanDuyets\Fresh.cshtml"
       Write(Html.DisplayNameFor(model => model.MemeName));

#line default
#line hidden
            EndContext();
            BeginContext(208, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(252, 40, false);
#line 11 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\MemeCanDuyets\Fresh.cshtml"
       Write(Html.DisplayFor(model => model.MemeName));

#line default
#line hidden
            EndContext();
            BeginContext(292, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(336, 46, false);
#line 14 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\MemeCanDuyets\Fresh.cshtml"
       Write(Html.DisplayNameFor(model => model.MemeImgUrl));

#line default
#line hidden
            EndContext();
            BeginContext(382, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(426, 42, false);
#line 17 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\MemeCanDuyets\Fresh.cshtml"
       Write(Html.DisplayFor(model => model.MemeImgUrl));

#line default
#line hidden
            EndContext();
            BeginContext(468, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(512, 48, false);
#line 20 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\MemeCanDuyets\Fresh.cshtml"
       Write(Html.DisplayNameFor(model => model.MemeCategory));

#line default
#line hidden
            EndContext();
            BeginContext(560, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(604, 44, false);
#line 23 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\MemeCanDuyets\Fresh.cshtml"
       Write(Html.DisplayFor(model => model.MemeCategory));

#line default
#line hidden
            EndContext();
            BeginContext(648, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(692, 47, false);
#line 26 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\MemeCanDuyets\Fresh.cshtml"
       Write(Html.DisplayNameFor(model => model.MemeUpvotes));

#line default
#line hidden
            EndContext();
            BeginContext(739, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(783, 43, false);
#line 29 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\MemeCanDuyets\Fresh.cshtml"
       Write(Html.DisplayFor(model => model.MemeUpvotes));

#line default
#line hidden
            EndContext();
            BeginContext(826, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(870, 44, false);
#line 32 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\MemeCanDuyets\Fresh.cshtml"
       Write(Html.DisplayNameFor(model => model.Uploader));

#line default
#line hidden
            EndContext();
            BeginContext(914, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(958, 40, false);
#line 35 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\MemeCanDuyets\Fresh.cshtml"
       Write(Html.DisplayFor(model => model.Uploader));

#line default
#line hidden
            EndContext();
            BeginContext(998, 91, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Hình ảnh chi tiết\r\n        </dt>\r\n        <dd>\r\n");
            EndContext();
#line 41 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\MemeCanDuyets\Fresh.cshtml"
             if (@Model.MemeImgUrl.Substring(@Model.MemeImgUrl.Length - 4) == ".mp4" || @Model.MemeImgUrl.Substring(@Model.MemeImgUrl.Length - 5) == ".webm")
            {

#line default
#line hidden
            BeginContext(1263, 82, true);
            WriteLiteral("                <video style=\"width: 500px\" controls>\r\n                    <source");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1345, "\"", 1368, 1);
#line 44 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\MemeCanDuyets\Fresh.cshtml"
WriteAttributeValue("", 1351, Model.MemeImgUrl, 1351, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1369, 46, true);
            WriteLiteral(" type=\"video/mp4\">\r\n                </video>\r\n");
            EndContext();
#line 46 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\MemeCanDuyets\Fresh.cshtml"
            }
            else if (@Model.MemeImgUrl.Substring(12, 7) == "youtube")
            {

#line default
#line hidden
            BeginContext(1516, 91, true);
            WriteLiteral("                <iframe style=\"width: 700px\" allowfullscreen=\"allowfullscreen\" height=\"500\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1607, "\"", 1630, 1);
#line 49 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\MemeCanDuyets\Fresh.cshtml"
WriteAttributeValue("", 1613, Model.MemeImgUrl, 1613, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1631, 12, true);
            WriteLiteral("></iframe>\r\n");
            EndContext();
#line 50 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\MemeCanDuyets\Fresh.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1691, 72, true);
            WriteLiteral("                <img style=\"width: 700px\" class=\"img-fluid card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1763, "\"", 1786, 1);
#line 53 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\MemeCanDuyets\Fresh.cshtml"
WriteAttributeValue("", 1769, Model.MemeImgUrl, 1769, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1787, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 54 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\MemeCanDuyets\Fresh.cshtml"
            }

#line default
#line hidden
            BeginContext(1805, 36, true);
            WriteLiteral("        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1841, 217, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8b01e215380898cd2f23eb9e3f5784e0231155a11777", async() => {
                BeginContext(1866, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1876, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c8b01e215380898cd2f23eb9e3f5784e0231155a12170", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 59 "C:\Users\Loc Do\Desktop\MemeTuoi\MemeTuoi\Areas\Admin\Views\MemeCanDuyets\Fresh.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MemeCanDuyetID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1924, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Fresh\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2007, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8b01e215380898cd2f23eb9e3f5784e0231155a14095", async() => {
                    BeginContext(2029, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2045, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2058, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MemeTuoi.Data.MemeCanDuyet> Html { get; private set; }
    }
}
#pragma warning restore 1591
