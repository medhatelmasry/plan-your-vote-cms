#pragma checksum "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af145f742b8e01c04172ca62c74d981937a6fdb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidates_Delete), @"mvc.1.0.view", @"/Views/Candidates/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Candidates/Delete.cshtml", typeof(AspNetCore.Views_Candidates_Delete))]
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
#line 2 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 3 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#line 4 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
using Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af145f742b8e01c04172ca62c74d981937a6fdb6", @"/Views/Candidates/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94d61326fb64e86108578a76380a5f57f5fd475a", @"/Views/_ViewImports.cshtml")]
    public class Views_Candidates_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Models.Candidate>
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
            BeginContext(177, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 7 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
  
    ViewData["Title"] = @Localizer["candidates_delete_title"];

#line default
#line hidden
            BeginContext(246, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(252, 17, false);
#line 11 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(269, 11, true);
            WriteLiteral("</h1>\n\n<h3>");
            EndContext();
            BeginContext(281, 26, false);
#line 13 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
Write(Localizer["deleteWarning"]);

#line default
#line hidden
            EndContext();
            BeginContext(307, 103, true);
            WriteLiteral("</h3>\n<div class=\"panel panel-default\">\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(411, 40, false);
#line 17 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(451, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(510, 36, false);
#line 20 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(546, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(604, 43, false);
#line 23 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Picture));

#line default
#line hidden
            EndContext();
            BeginContext(647, 46, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n");
            EndContext();
#line 26 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
              
                var url = "../../" + Model.Picture;

#line default
#line hidden
            BeginContext(760, 45, true);
            WriteLiteral("                <img width=\"150\" height=\"150\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 805, "\"", 815, 1);
#line 28 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
WriteAttributeValue("", 811, url, 811, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(816, 2, true);
            WriteLiteral(">\n");
            EndContext();
            BeginContext(832, 56, true);
            WriteLiteral("        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(889, 53, false);
#line 32 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Organization.Name));

#line default
#line hidden
            EndContext();
            BeginContext(942, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1001, 49, false);
#line 35 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Organization.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1050, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1108, 50, false);
#line 38 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CandidateRaces));

#line default
#line hidden
            EndContext();
            BeginContext(1158, 63, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            <ul>\n");
            EndContext();
#line 42 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
                 foreach (var candidateRace in Model.CandidateRaces)
                {
                    var races = (List<Race>)ViewBag.Races;
                    var race = races.Find(r => r.RaceId == candidateRace.RaceId);


#line default
#line hidden
            BeginContext(1450, 49, true);
            WriteLiteral("                    <li>\n                        ");
            EndContext();
            BeginContext(1500, 43, false);
#line 48 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
                   Write(Html.DisplayFor(model => race.PositionName));

#line default
#line hidden
            EndContext();
            BeginContext(1543, 27, true);
            WriteLiteral("\n                    </li>\n");
            EndContext();
#line 50 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
                }

#line default
#line hidden
            BeginContext(1588, 51, true);
            WriteLiteral("            </ul>\n        </dd>\n    </dl>\n\n    <h4>");
            EndContext();
            BeginContext(1640, 43, false);
#line 55 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
   Write(Html.DisplayNameFor(model => model.Details));

#line default
#line hidden
            EndContext();
            BeginContext(1683, 17, true);
            WriteLiteral("</h4>\n    <hr />\n");
            EndContext();
#line 57 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
     foreach (var detail in Model.Details)
    {

#line default
#line hidden
            BeginContext(1749, 75, true);
            WriteLiteral("        <dl class=\"row\">\n            <dt class=\"col-sm-2\">\n                ");
            EndContext();
            BeginContext(1825, 42, false);
#line 61 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
           Write(Html.DisplayNameFor(model => detail.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1867, 70, true);
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
            EndContext();
            BeginContext(1938, 38, false);
#line 64 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
           Write(Html.DisplayFor(model => detail.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1976, 69, true);
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
            EndContext();
            BeginContext(2046, 41, false);
#line 67 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
           Write(Html.DisplayNameFor(model => detail.Text));

#line default
#line hidden
            EndContext();
            BeginContext(2087, 54, true);
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n");
            EndContext();
#line 70 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
                 if (detail.Format == CandidateDetailFormat.List)
                {

#line default
#line hidden
            BeginContext(2225, 53, true);
            WriteLiteral("                    <ul>\n                        <li>");
            EndContext();
            BeginContext(2279, 37, false);
#line 73 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
                       Write(Html.DisplayFor(model => detail.Text));

#line default
#line hidden
            EndContext();
            BeginContext(2316, 32, true);
            WriteLiteral("</li>\n                    </ul>\n");
            EndContext();
#line 75 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
                }
                else if (detail.Format == CandidateDetailFormat.OrderedList)
                {

#line default
#line hidden
            BeginContext(2461, 53, true);
            WriteLiteral("                    <ol>\n                        <li>");
            EndContext();
            BeginContext(2515, 37, false);
#line 79 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
                       Write(Html.DisplayFor(model => detail.Text));

#line default
#line hidden
            EndContext();
            BeginContext(2552, 32, true);
            WriteLiteral("</li>\n                    </ol>\n");
            EndContext();
#line 81 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
                }
                else
                {
                    

#line default
#line hidden
            BeginContext(2662, 37, false);
#line 84 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
               Write(Html.DisplayFor(model => detail.Text));

#line default
#line hidden
            EndContext();
#line 84 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
                                                          
                }

#line default
#line hidden
            BeginContext(2718, 47, true);
            WriteLiteral("            </dd>\n        </dl>\n        <hr />\n");
            EndContext();
#line 89 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
    }

#line default
#line hidden
            BeginContext(2771, 9, true);
            WriteLiteral("\n    <h4>");
            EndContext();
            BeginContext(2781, 44, false);
#line 91 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
   Write(Html.DisplayNameFor(model => model.Contacts));

#line default
#line hidden
            EndContext();
            BeginContext(2825, 17, true);
            WriteLiteral("</h4>\n    <hr />\n");
            EndContext();
#line 93 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
     foreach (var contact in Model.Contacts)
    {

#line default
#line hidden
            BeginContext(2893, 75, true);
            WriteLiteral("        <dl class=\"row\">\n            <dt class=\"col-sm-2\">\n                ");
            EndContext();
            BeginContext(2969, 51, false);
#line 97 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
           Write(Html.DisplayNameFor(model => contact.ContactMethod));

#line default
#line hidden
            EndContext();
            BeginContext(3020, 70, true);
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
            EndContext();
            BeginContext(3091, 47, false);
#line 100 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
           Write(Html.DisplayFor(model => contact.ContactMethod));

#line default
#line hidden
            EndContext();
            BeginContext(3138, 69, true);
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
            EndContext();
            BeginContext(3208, 50, false);
#line 103 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
           Write(Html.DisplayNameFor(model => contact.ContactValue));

#line default
#line hidden
            EndContext();
            BeginContext(3258, 70, true);
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
            EndContext();
            BeginContext(3329, 46, false);
#line 106 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
           Write(Html.DisplayFor(Model => contact.ContactValue));

#line default
#line hidden
            EndContext();
            BeginContext(3375, 48, true);
            WriteLiteral("\n            </dd>\n        </dl>\n        <hr />\n");
            EndContext();
#line 110 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
    }

#line default
#line hidden
            BeginContext(3429, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(3434, 243, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af145f742b8e01c04172ca62c74d981937a6fdb618052", async() => {
                BeginContext(3460, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(3469, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "af145f742b8e01c04172ca62c74d981937a6fdb618442", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 113 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CandidateId);

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
                BeginContext(3514, 80, true);
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> \n        ");
                EndContext();
                BeginContext(3594, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af145f742b8e01c04172ca62c74d981937a6fdb620347", async() => {
                    BeginContext(3638, 23, false);
#line 115 "C:\projects\plan-your-vote-cms-develop\Web\Views\Candidates\Delete.cshtml"
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
                BeginContext(3665, 5, true);
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
            BeginContext(3677, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Models.Candidate> Html { get; private set; }
    }
}
#pragma warning restore 1591
