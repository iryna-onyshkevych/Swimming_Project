#pragma checksum "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\Training\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25e80fd9e23beddbfc25ea1b9111c3898d8b1b9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Training_Index), @"mvc.1.0.view", @"/Views/Training/Index.cshtml")]
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
#line 1 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\_ViewImports.cshtml"
using DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\_ViewImports.cshtml"
using DTO.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\Training\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\Training\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\Training\Index.cshtml"
using X.PagedList.Mvc.Core.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25e80fd9e23beddbfc25ea1b9111c3898d8b1b9e", @"/Views/Training/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e114ac2b4f1515a93ff42503b9aea6b041283ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Training_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\Training\Index.cshtml"
  
    ViewBag.Title = "Product Listing";
    var pagedList = (IPagedList)ViewBag.OnePageOfProducts;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link href=\"/Content/PagedList.css\" rel=\"stylesheet\" type=\"text/css\" />\r\n<div id=\"modDialog\" class=\"modal fade\">\r\n    <div id=\"dialogContent\" class=\"modal-dialog\"></div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25e80fd9e23beddbfc25ea1b9111c3898d8b1b9e5206", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25e80fd9e23beddbfc25ea1b9111c3898d8b1b9e6444", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n\r\n    <tr><td>Id</td><td>First Name</td><td>Last Name</td><td>Date</td><td>Style</td><td>Distance</td><td>Actions</td></tr>\r\n\r\n");
#nullable restore
#line 22 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\Training\Index.cshtml"
     foreach (var item in ViewBag.OnePageOfProducts)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\Training\Index.cshtml"
           Write(item.TrainingId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\Training\Index.cshtml"
           Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\Training\Index.cshtml"
           Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\Training\Index.cshtml"
           Write(item.TrainingDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\Training\Index.cshtml"
           Write(item.Style);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\Training\Index.cshtml"
           Write(item.Distance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\Training\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.TrainingId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 34 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\Training\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.TrainingId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 35 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\Training\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", "SwimmerTraining", new { id = item.TrainingId }, new { @class = "compItem" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\Training\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n");
#nullable restore
#line 43 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\Training\Index.cshtml"
Write(Html.PagedListPager((IPagedList)ViewBag.OnePageOfProducts, page => Url.Action("Index", new { page }), new PagedListRenderOptions
{
    LiElementClasses = new string[] { "page-item" },
    PageClasses = new string[] { "page-link" }
}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">

        $(function () {
            $.ajaxSetup({ cache: false });
            $("".compItem"").click(function (e) {

                e.preventDefault();
                $.get(this.href, function (data) {
                    $('#dialogContent').html(data);
                    $('#modDialog').modal('show');
                });
            });
        })
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
