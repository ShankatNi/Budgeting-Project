#pragma checksum "C:\Users\nites\Desktop\Github_Update\Currently Working\Budgeting\Budgeting\Pages\Records\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39a0d55a6b86122a1fdd37a683cdaf630feaff20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Budgeting.Pages.Records.Pages_Records_Details), @"mvc.1.0.razor-page", @"/Pages/Records/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Records/Details.cshtml", typeof(Budgeting.Pages.Records.Pages_Records_Details), null)]
namespace Budgeting.Pages.Records
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\nites\Desktop\Github_Update\Currently Working\Budgeting\Budgeting\Pages\_ViewImports.cshtml"
using Budgeting;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39a0d55a6b86122a1fdd37a683cdaf630feaff20", @"/Pages/Records/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d44ecc0e2b2519470a0722bd438d560d7b98da41", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Records_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\nites\Desktop\Github_Update\Currently Working\Budgeting\Budgeting\Pages\Records\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(97, 120, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Record</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(218, 51, false);
#line 15 "C:\Users\nites\Desktop\Github_Update\Currently Working\Budgeting\Budgeting\Pages\Records\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Record.Expenses));

#line default
#line hidden
            EndContext();
            BeginContext(269, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(313, 47, false);
#line 18 "C:\Users\nites\Desktop\Github_Update\Currently Working\Budgeting\Budgeting\Pages\Records\Details.cshtml"
       Write(Html.DisplayFor(model => model.Record.Expenses));

#line default
#line hidden
            EndContext();
            BeginContext(360, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(404, 55, false);
#line 21 "C:\Users\nites\Desktop\Github_Update\Currently Working\Budgeting\Budgeting\Pages\Records\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Record.ExpensesDate));

#line default
#line hidden
            EndContext();
            BeginContext(459, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(503, 51, false);
#line 24 "C:\Users\nites\Desktop\Github_Update\Currently Working\Budgeting\Budgeting\Pages\Records\Details.cshtml"
       Write(Html.DisplayFor(model => model.Record.ExpensesDate));

#line default
#line hidden
            EndContext();
            BeginContext(554, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(598, 49, false);
#line 27 "C:\Users\nites\Desktop\Github_Update\Currently Working\Budgeting\Budgeting\Pages\Records\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Record.Income));

#line default
#line hidden
            EndContext();
            BeginContext(647, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(691, 45, false);
#line 30 "C:\Users\nites\Desktop\Github_Update\Currently Working\Budgeting\Budgeting\Pages\Records\Details.cshtml"
       Write(Html.DisplayFor(model => model.Record.Income));

#line default
#line hidden
            EndContext();
            BeginContext(736, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(780, 53, false);
#line 33 "C:\Users\nites\Desktop\Github_Update\Currently Working\Budgeting\Budgeting\Pages\Records\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Record.IncomeDate));

#line default
#line hidden
            EndContext();
            BeginContext(833, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(877, 49, false);
#line 36 "C:\Users\nites\Desktop\Github_Update\Currently Working\Budgeting\Budgeting\Pages\Records\Details.cshtml"
       Write(Html.DisplayFor(model => model.Record.IncomeDate));

#line default
#line hidden
            EndContext();
            BeginContext(926, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(973, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06d3e4052e2a4c6c932bf7920f2168ec", async() => {
                BeginContext(1026, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "C:\Users\nites\Desktop\Github_Update\Currently Working\Budgeting\Budgeting\Pages\Records\Details.cshtml"
                           WriteLiteral(Model.Record.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1034, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1042, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68685a5f8b594c64836df81641afb172", async() => {
                BeginContext(1064, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1080, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Budgeting.Pages.Records.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Budgeting.Pages.Records.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Budgeting.Pages.Records.DetailsModel>)PageContext?.ViewData;
        public Budgeting.Pages.Records.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
