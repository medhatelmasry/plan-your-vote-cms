#pragma checksum "C:\projects\plan-your-vote-cms-develop\Web\Views\SocialMedias\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "467e78a3e500b3ae3b7866a923c737672d79c7d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SocialMedias_Delete), @"mvc.1.0.view", @"/Views/SocialMedias/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SocialMedias/Delete.cshtml", typeof(AspNetCore.Views_SocialMedias_Delete))]
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
#line 2 "C:\projects\plan-your-vote-cms-develop\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#line 3 "C:\projects\plan-your-vote-cms-develop\Web\Views\_ViewImports.cshtml"
using Web.CmsControllers;

#line default
#line hidden
#line 2 "C:\projects\plan-your-vote-cms-develop\Web\Views\SocialMedias\Delete.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 3 "C:\projects\plan-your-vote-cms-develop\Web\Views\SocialMedias\Delete.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#line 4 "C:\projects\plan-your-vote-cms-develop\Web\Views\SocialMedias\Delete.cshtml"
using Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"467e78a3e500b3ae3b7866a923c737672d79c7d0", @"/Views/SocialMedias/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94d61326fb64e86108578a76380a5f57f5fd475a", @"/Views/_ViewImports.cshtml")]
    public class Views_SocialMedias_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Models.SocialMedia>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(179, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 8 "C:\projects\plan-your-vote-cms-develop\Web\Views\SocialMedias\Delete.cshtml"
  
    ViewData["Title"] = @Localizer["socialMedia_delete_title"];

#line default
#line hidden
            BeginContext(250, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(256, 17, false);
#line 12 "C:\projects\plan-your-vote-cms-develop\Web\Views\SocialMedias\Delete.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(273, 11, true);
            WriteLiteral("</h1>\n\n<h3>");
            EndContext();
            BeginContext(285, 39, false);
#line 14 "C:\projects\plan-your-vote-cms-develop\Web\Views\SocialMedias\Delete.cshtml"
Write(Localizer["socialMedia_delete_warning"]);

#line default
#line hidden
            EndContext();
            BeginContext(324, 103, true);
            WriteLiteral("</h3>\n<div class=\"panel panel-default\">\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(428, 45, false);
#line 18 "C:\projects\plan-your-vote-cms-develop\Web\Views\SocialMedias\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MediaName));

#line default
#line hidden
            EndContext();
            BeginContext(473, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(532, 41, false);
#line 21 "C:\projects\plan-your-vote-cms-develop\Web\Views\SocialMedias\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MediaName));

#line default
#line hidden
            EndContext();
            BeginContext(573, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(631, 43, false);
#line 24 "C:\projects\plan-your-vote-cms-develop\Web\Views\SocialMedias\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Message));

#line default
#line hidden
            EndContext();
            BeginContext(674, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(733, 39, false);
#line 27 "C:\projects\plan-your-vote-cms-develop\Web\Views\SocialMedias\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Message));

#line default
#line hidden
            EndContext();
            BeginContext(772, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(830, 40, false);
#line 30 "C:\projects\plan-your-vote-cms-develop\Web\Views\SocialMedias\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Link));

#line default
#line hidden
            EndContext();
            BeginContext(870, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(929, 36, false);
#line 33 "C:\projects\plan-your-vote-cms-develop\Web\Views\SocialMedias\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Link));

#line default
#line hidden
            EndContext();
            BeginContext(965, 30, true);
            WriteLiteral("\n        </dd>\n    </dl>\n\n    ");
            EndContext();
            BeginContext(995, 251, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "467e78a3e500b3ae3b7866a923c737672d79c7d08827", async() => {
                BeginContext(1021, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1030, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "467e78a3e500b3ae3b7866a923c737672d79c7d09216", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 38 "C:\projects\plan-your-vote-cms-develop\Web\Views\SocialMedias\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

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
                BeginContext(1066, 29, true);
                WriteLiteral("\n        <input type=\"submit\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1095, "", 1128, 1);
#line 39 "C:\projects\plan-your-vote-cms-develop\Web\Views\SocialMedias\Delete.cshtml"
WriteAttributeValue("", 1102, Localizer["deleteButton"], 1102, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1128, 35, true);
                WriteLiteral(" class=\"btn btn-danger\" />\n        ");
                EndContext();
                BeginContext(1163, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "467e78a3e500b3ae3b7866a923c737672d79c7d011517", async() => {
                    BeginContext(1207, 23, false);
#line 40 "C:\projects\plan-your-vote-cms-develop\Web\Views\SocialMedias\Delete.cshtml"
                                              Write(Localizer["backButton"]);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1234, 5, true);
                WriteLiteral("\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1246, 8, true);
            WriteLiteral("\n</div>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<SharedResource> Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Models.SocialMedia> Html { get; private set; }
    }
}
#pragma warning restore 1591
