#pragma checksum "C:\TFS\source\repos\PlayDotNet\CoreWeb\Views\Department\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61219adb48d626cea746b8056468b7b3f54d2fca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Index), @"mvc.1.0.view", @"/Views/Department/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Department/Index.cshtml", typeof(AspNetCore.Views_Department_Index))]
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
#line 1 "C:\TFS\source\repos\PlayDotNet\CoreWeb\Views\Department\Index.cshtml"
using CoreWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61219adb48d626cea746b8056468b7b3f54d2fca", @"/Views/Department/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ccaa0bb7c2237ad0e2193309f82bddc35d0c1ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DepartmentModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\TFS\source\repos\PlayDotNet\CoreWeb\Views\Department\Index.cshtml"
  
    ViewData["Title"] = "Department List";

#line default
#line hidden
            BeginContext(109, 47, true);
            WriteLiteral("\r\n<h2>Department List</h2>\r\n\r\n<div>\r\n    <ul>\r\n");
            EndContext();
#line 13 "C:\TFS\source\repos\PlayDotNet\CoreWeb\Views\Department\Index.cshtml"
         foreach (var department in Model)
        {
            

#line default
#line hidden
            BeginContext(321, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(338, 97, false);
#line 16 "C:\TFS\source\repos\PlayDotNet\CoreWeb\Views\Department\Index.cshtml"
           Write(Html.ActionLink(department.Name, $"Index", "Employee", new { departmentId = department.ID}, null));

#line default
#line hidden
            EndContext();
            BeginContext(435, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 17 "C:\TFS\source\repos\PlayDotNet\CoreWeb\Views\Department\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(453, 19, true);
            WriteLiteral("    </ul>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DepartmentModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
