#pragma checksum "E:\0 Cognizant Hands-Ons\c#\OrganizationsAtHyderabad\Views\Home\ITOrganizations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61b760390451c06e46b2e4ef99b3eba5f6817791"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ITOrganizations), @"mvc.1.0.view", @"/Views/Home/ITOrganizations.cshtml")]
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
#line 1 "E:\0 Cognizant Hands-Ons\c#\OrganizationsAtHyderabad\Views\_ViewImports.cshtml"
using OrganizationsAtHyderabad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\0 Cognizant Hands-Ons\c#\OrganizationsAtHyderabad\Views\_ViewImports.cshtml"
using OrganizationsAtHyderabad.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61b760390451c06e46b2e4ef99b3eba5f6817791", @"/Views/Home/ITOrganizations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4b82fc00242e7b4306550218680bc65e76076ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ITOrganizations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "E:\0 Cognizant Hands-Ons\c#\OrganizationsAtHyderabad\Views\Home\ITOrganizations.cshtml"
  
    List<string> Organizations = new List<string>()
{
        "Microsoft-www.microsoft.com", "Google-www.google.com", "TCS-www.tcs.com", "Amazon-www.amazon.in", "CTS-www.cognizant.com"
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>\r\n    IT Organizations in India\r\n</h1>\r\n\r\n");
#nullable restore
#line 15 "E:\0 Cognizant Hands-Ons\c#\OrganizationsAtHyderabad\Views\Home\ITOrganizations.cshtml"
 foreach (var item in Organizations)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n");
#nullable restore
#line 18 "E:\0 Cognizant Hands-Ons\c#\OrganizationsAtHyderabad\Views\Home\ITOrganizations.cshtml"
         if (item.StartsWith("Amazon"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <b>");
#nullable restore
#line 20 "E:\0 Cognizant Hands-Ons\c#\OrganizationsAtHyderabad\Views\Home\ITOrganizations.cshtml"
          Write(item.Split('-')[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> <span><a");
            BeginWriteAttribute("href", " href=\"", 525, "\"", 551, 1);
#nullable restore
#line 20 "E:\0 Cognizant Hands-Ons\c#\OrganizationsAtHyderabad\Views\Home\ITOrganizations.cshtml"
WriteAttributeValue("", 532, item.Split('-')[1], 532, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "E:\0 Cognizant Hands-Ons\c#\OrganizationsAtHyderabad\Views\Home\ITOrganizations.cshtml"
                                                                      Write(item.Split('-')[1]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></span> <span>Amazon is the IT organization that has built its largest office at Hyderabad in 2019.</span>\r\n");
#nullable restore
#line 21 "E:\0 Cognizant Hands-Ons\c#\OrganizationsAtHyderabad\Views\Home\ITOrganizations.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <i>");
#nullable restore
#line 24 "E:\0 Cognizant Hands-Ons\c#\OrganizationsAtHyderabad\Views\Home\ITOrganizations.cshtml"
          Write(item.Split('-')[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i> <span><a");
            BeginWriteAttribute("href", " href=\"", 768, "\"", 794, 1);
#nullable restore
#line 24 "E:\0 Cognizant Hands-Ons\c#\OrganizationsAtHyderabad\Views\Home\ITOrganizations.cshtml"
WriteAttributeValue("", 775, item.Split('-')[1], 775, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "E:\0 Cognizant Hands-Ons\c#\OrganizationsAtHyderabad\Views\Home\ITOrganizations.cshtml"
                                                                      Write(item.Split('-')[1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n");
#nullable restore
#line 25 "E:\0 Cognizant Hands-Ons\c#\OrganizationsAtHyderabad\Views\Home\ITOrganizations.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 27 "E:\0 Cognizant Hands-Ons\c#\OrganizationsAtHyderabad\Views\Home\ITOrganizations.cshtml"
}

#line default
#line hidden
#nullable disable
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