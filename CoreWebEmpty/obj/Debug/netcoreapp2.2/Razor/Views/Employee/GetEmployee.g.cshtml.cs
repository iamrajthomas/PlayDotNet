#pragma checksum "C:\TFS\source\repos\PlayDotNet\CoreWebEmpty\Views\Employee\GetEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d7a0a4735d2ae4f2d9c33f7921461dc0e361393"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_GetEmployee), @"mvc.1.0.view", @"/Views/Employee/GetEmployee.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/GetEmployee.cshtml", typeof(AspNetCore.Views_Employee_GetEmployee))]
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
#line 1 "C:\TFS\source\repos\PlayDotNet\CoreWebEmpty\Views\_ViewImports.cshtml"
using CoreWebEmpty.ViewModels;

#line default
#line hidden
#line 2 "C:\TFS\source\repos\PlayDotNet\CoreWebEmpty\Views\_ViewImports.cshtml"
using CoreWebEmpty.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d7a0a4735d2ae4f2d9c33f7921461dc0e361393", @"/Views/Employee/GetEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c701f2cc4e24eefce42c518a90ecfbf65e4d9f17", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_GetEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(128, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(321, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "C:\TFS\source\repos\PlayDotNet\CoreWebEmpty\Views\Employee\GetEmployee.cshtml"
  
    ViewBag.Title = "Employee Details";

#line default
#line hidden
            BeginContext(371, 17, true);
            WriteLiteral("\r\n<div>\r\n    ID: ");
            EndContext();
            BeginContext(389, 8, false);
#line 18 "C:\TFS\source\repos\PlayDotNet\CoreWebEmpty\Views\Employee\GetEmployee.cshtml"
   Write(Model.ID);

#line default
#line hidden
            EndContext();
            BeginContext(397, 27, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Name: ");
            EndContext();
            BeginContext(425, 10, false);
#line 21 "C:\TFS\source\repos\PlayDotNet\CoreWebEmpty\Views\Employee\GetEmployee.cshtml"
     Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(435, 28, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Email: ");
            EndContext();
            BeginContext(464, 11, false);
#line 24 "C:\TFS\source\repos\PlayDotNet\CoreWebEmpty\Views\Employee\GetEmployee.cshtml"
      Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(475, 33, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Department: ");
            EndContext();
            BeginContext(509, 16, false);
#line 27 "C:\TFS\source\repos\PlayDotNet\CoreWebEmpty\Views\Employee\GetEmployee.cshtml"
           Write(Model.Department);

#line default
#line hidden
            EndContext();
            BeginContext(525, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
