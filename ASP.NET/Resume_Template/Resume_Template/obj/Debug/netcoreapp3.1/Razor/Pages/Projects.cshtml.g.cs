#pragma checksum "/Users/shahriar/Desktop/C-Sharp-ASP.NET/ASP.NET/Resume_Template/Resume_Template/Pages/Projects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca73f0b99212ee82daa2e13d6a6d4937367913bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Resume_Template.Pages.Pages_Projects), @"mvc.1.0.razor-page", @"/Pages/Projects.cshtml")]
namespace Resume_Template.Pages
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
#line 1 "/Users/shahriar/Desktop/C-Sharp-ASP.NET/ASP.NET/Resume_Template/Resume_Template/Pages/_ViewImports.cshtml"
using Resume_Template;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca73f0b99212ee82daa2e13d6a6d4937367913bc", @"/Pages/Projects.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08f454e2ad70ac16d0213e8ac59d947927e164b0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Projects : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Links", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Projects.cshtml -->\n<!-- Add model directive below -->\n");
#nullable restore
#line 5 "/Users/shahriar/Desktop/C-Sharp-ASP.NET/ASP.NET/Resume_Template/Resume_Template/Pages/Projects.cshtml"
  
    // Add ViewData Title below
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/shahriar/Desktop/C-Sharp-ASP.NET/ASP.NET/Resume_Template/Resume_Template/Pages/Projects.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/shahriar/Desktop/C-Sharp-ASP.NET/ASP.NET/Resume_Template/Resume_Template/Pages/Projects.cshtml"
                       = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""jumbotron jumbotron-fluid jumbotron-container text-white project-jumbotron"">
    <div class=""container-fluid jumbotron-content"">
        <p class=""text-center mb-4 jumbotron-header"">Projects</p>
    </div>
</div>

<div class=""container"">
    <div class=""project-container"">
");
#nullable restore
#line 18 "/Users/shahriar/Desktop/C-Sharp-ASP.NET/ASP.NET/Resume_Template/Resume_Template/Pages/Projects.cshtml"
         foreach (var i_project in @Model.Projects)
        {
            if (@i_project.Year > 2017)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h4 class=\"project-title general-header\">\n                    <!--  Project Title -->\n                    ");
#nullable restore
#line 24 "/Users/shahriar/Desktop/C-Sharp-ASP.NET/ASP.NET/Resume_Template/Resume_Template/Pages/Projects.cshtml"
               Write(i_project.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </h4>\n                <p class=\"project-year general-header\">\n                    <!--  Project Year -->\n                    ");
#nullable restore
#line 28 "/Users/shahriar/Desktop/C-Sharp-ASP.NET/ASP.NET/Resume_Template/Resume_Template/Pages/Projects.cshtml"
               Write(i_project.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </p>\n                <p class=\"project-description general-content\">\n                    <!--  Project Description -->\n                    ");
#nullable restore
#line 32 "/Users/shahriar/Desktop/C-Sharp-ASP.NET/ASP.NET/Resume_Template/Resume_Template/Pages/Projects.cshtml"
               Write(i_project.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </p>\n");
#nullable restore
#line 34 "/Users/shahriar/Desktop/C-Sharp-ASP.NET/ASP.NET/Resume_Template/Resume_Template/Pages/Projects.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n\n    <br>\n    <h4 class=\"general-header\">Portfolio</h4>\n    <p class=\"general-content\">\n        <!-- Render partial for Link below -->\n        For more information regarding my projects, please refer to my ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ca73f0b99212ee82daa2e13d6a6d4937367913bc6184", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 42 "/Users/shahriar/Desktop/C-Sharp-ASP.NET/ASP.NET/Resume_Template/Resume_Template/Pages/Projects.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.GithubUsername);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </p>\n    <br>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProjectsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProjectsModel>)PageContext?.ViewData;
        public ProjectsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591