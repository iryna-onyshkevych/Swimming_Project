#pragma checksum "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\Swimmer\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4edf303cc6d02ce2bd5e523c86a9831be4a1cf83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Swimmer_Details), @"mvc.1.0.view", @"/Views/Swimmer/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4edf303cc6d02ce2bd5e523c86a9831be4a1cf83", @"/Views/Swimmer/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e114ac2b4f1515a93ff42503b9aea6b041283ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Swimmer_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DTO.Models.SwimmerDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\Swimmer\Details.cshtml"
  
    ViewBag.Title = Model.FirstName;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Swimmer ");
#nullable restore
#line 5 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\Swimmer\Details.cshtml"
       Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 5 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\Swimmer\Details.cshtml"
                        Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>Id</dt>\r\n        <dd>");
#nullable restore
#line 9 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\Swimmer\Details.cshtml"
       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt>Work Experience</dt>\r\n        <dd>");
#nullable restore
#line 12 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\Swimmer\Details.cshtml"
       Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt>Coach Id</dt>\r\n        <dd>");
#nullable restore
#line 15 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingApp\Swimming\SwimmingWebApp\Views\Swimmer\Details.cshtml"
       Write(Model.CoachId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </dl>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DTO.Models.SwimmerDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
