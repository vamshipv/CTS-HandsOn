#pragma checksum "E:\0 Cognizant Hands-Ons\dotNet\EmployeeDetails\Views\Home\GetEmployeeList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51d62d62543662697f9619d3dd8de5568d60f965"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetEmployeeList), @"mvc.1.0.view", @"/Views/Home/GetEmployeeList.cshtml")]
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
#line 1 "E:\0 Cognizant Hands-Ons\dotNet\EmployeeDetails\Views\_ViewImports.cshtml"
using EmployeeDetails;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\0 Cognizant Hands-Ons\dotNet\EmployeeDetails\Views\_ViewImports.cshtml"
using EmployeeDetails.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51d62d62543662697f9619d3dd8de5568d60f965", @"/Views/Home/GetEmployeeList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"941b60d4ae348c736f599bb539de4b8bc93b8a29", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetEmployeeList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeDetails.Models.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "E:\0 Cognizant Hands-Ons\dotNet\EmployeeDetails\Views\Home\GetEmployeeList.cshtml"
Write(await Html.PartialAsync("PartialView", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeDetails.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
