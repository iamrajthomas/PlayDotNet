#pragma checksum "C:\TFS\source\repos\PlayDotNet\CoreWeb\Views\Employee\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4548585e342de6cd92eb31d1219f20576fb69785"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Details), @"mvc.1.0.view", @"/Views/Employee/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Details.cshtml", typeof(AspNetCore.Views_Employee_Details))]
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
#line 1 "C:\TFS\source\repos\PlayDotNet\CoreWeb\Views\_ViewImports.cshtml"
using CoreWeb;

#line default
#line hidden
#line 2 "C:\TFS\source\repos\PlayDotNet\CoreWeb\Views\_ViewImports.cshtml"
using CoreWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4548585e342de6cd92eb31d1219f20576fb69785", @"/Views/Employee/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ccaa0bb7c2237ad0e2193309f82bddc35d0c1ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreWeb.Models.EmployeeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\TFS\source\repos\PlayDotNet\CoreWeb\Views\Employee\Details.cshtml"
  
    ViewData["Title"] = "Employee Details";

#line default
#line hidden
            BeginContext(91, 141, true);
            WriteLiteral("\r\n<h2>Employee Details</h2>\r\n\r\n<table style=\"font-family: Arial; border:solid\">\r\n    <tr>\r\n        <td><b>EmployeeId: </b></td>\r\n        <td>");
            EndContext();
            BeginContext(233, 16, false);
#line 12 "C:\TFS\source\repos\PlayDotNet\CoreWeb\Views\Employee\Details.cshtml"
       Write(Model.EmployeeId);

#line default
#line hidden
            EndContext();
            BeginContext(249, 72, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td><b>Name: </b></td>\r\n        <td>");
            EndContext();
            BeginContext(322, 10, false);
#line 16 "C:\TFS\source\repos\PlayDotNet\CoreWeb\Views\Employee\Details.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(332, 74, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td><b>Gender: </b></td>\r\n        <td>");
            EndContext();
            BeginContext(407, 12, false);
#line 20 "C:\TFS\source\repos\PlayDotNet\CoreWeb\Views\Employee\Details.cshtml"
       Write(Model.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(419, 72, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td><b>City: </b></td>\r\n        <td>");
            EndContext();
            BeginContext(492, 10, false);
#line 24 "C:\TFS\source\repos\PlayDotNet\CoreWeb\Views\Employee\Details.cshtml"
       Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(502, 43, true);
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n</table>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(546, 110, false);
#line 30 "C:\TFS\source\repos\PlayDotNet\CoreWeb\Views\Employee\Details.cshtml"
Write(Html.ActionLink("Back To Employee List", "Index", "Employee", new { departmentId = Model.DepartmentId }, null));

#line default
#line hidden
            EndContext();
            BeginContext(656, 9, true);
            WriteLiteral(";\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreWeb.Models.EmployeeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
