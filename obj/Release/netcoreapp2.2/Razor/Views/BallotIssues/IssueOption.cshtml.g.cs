#pragma checksum "C:\projects\plan-your-vote-cms-develop\Web\Views\BallotIssues\IssueOption.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15d5207059438085edb34326644bf51ae8c412ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BallotIssues_IssueOption), @"mvc.1.0.view", @"/Views/BallotIssues/IssueOption.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BallotIssues/IssueOption.cshtml", typeof(AspNetCore.Views_BallotIssues_IssueOption))]
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
#line 2 "C:\projects\plan-your-vote-cms-develop\Web\Views\BallotIssues\IssueOption.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#line 3 "C:\projects\plan-your-vote-cms-develop\Web\Views\BallotIssues\IssueOption.cshtml"
using Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15d5207059438085edb34326644bf51ae8c412ee", @"/Views/BallotIssues/IssueOption.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94d61326fb64e86108578a76380a5f57f5fd475a", @"/Views/_ViewImports.cshtml")]
    public class Views_BallotIssues_IssueOption : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Models.BallotIssue>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(133, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 6 "C:\projects\plan-your-vote-cms-develop\Web\Views\BallotIssues\IssueOption.cshtml"
   
    var lastIndex = Model.BallotIssueOptions.Count - 1;

#line default
#line hidden
            BeginContext(196, 99, true);
            WriteLiteral("\n<div class=\"row option\">\n    <div class=\"col-md-10\">\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(296, 134, false);
#line 13 "C:\projects\plan-your-vote-cms-develop\Web\Views\BallotIssues\IssueOption.cshtml"
       Write(Html.TextAreaFor(model => model.BallotIssueOptions[lastIndex].IssueOptionInfo, new { @class = "form-control option-text", @rows = 2 }));

#line default
#line hidden
            EndContext();
            BeginContext(430, 162, true);
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"col-md-2 form-group\">\n        <button id=\"RemoveIssueOption\" type=\"button\" role=\"button\" class=\"btn btn-primary btn-sm\"");
            EndContext();
            BeginWriteAttribute("onClick", " onClick=\"", 592, "\"", 626, 3);
            WriteAttributeValue("", 602, "removeOption(", 602, 13, true);
#line 17 "C:\projects\plan-your-vote-cms-develop\Web\Views\BallotIssues\IssueOption.cshtml"
WriteAttributeValue("", 615, lastIndex, 615, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 625, ")", 625, 1, true);
            EndWriteAttribute();
            BeginContext(627, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(629, 44, false);
#line 17 "C:\projects\plan-your-vote-cms-develop\Web\Views\BallotIssues\IssueOption.cshtml"
                                                                                                                                Write(Localizer["ballotIssues_removeOptionButton"]);

#line default
#line hidden
            EndContext();
            BeginContext(673, 27, true);
            WriteLiteral("</button>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Models.BallotIssue> Html { get; private set; }
    }
}
#pragma warning restore 1591
