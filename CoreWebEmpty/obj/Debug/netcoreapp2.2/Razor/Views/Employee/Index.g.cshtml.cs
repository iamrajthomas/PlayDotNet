#pragma checksum "C:\TFS\source\repos\PlayDotNet\CoreWebEmpty\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f95e4df6e411ef40091d28144d939326290116a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Index.cshtml", typeof(AspNetCore.Views_Employee_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f95e4df6e411ef40091d28144d939326290116a", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c701f2cc4e24eefce42c518a90ecfbf65e4d9f17", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreWebEmpty.Models.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CustomScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(231, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\TFS\source\repos\PlayDotNet\CoreWebEmpty\Views\Employee\Index.cshtml"
  
    ViewBag.Title = "Employee List";

#line default
#line hidden
            BeginContext(278, 227, true);
            WriteLiteral("\r\n<h1>This is List Employee With View</h1>\r\n\r\n<div>\r\n    <table border=\"1\">\r\n        <tr>\r\n            <th>ID: </th>\r\n            <th>Name: </th>\r\n            <th>Email: </th>\r\n            <th>Department: </th>\r\n        </tr>\r\n");
            EndContext();
#line 22 "C:\TFS\source\repos\PlayDotNet\CoreWebEmpty\Views\Employee\Index.cshtml"
         foreach (var employee in Model)
        {

#line default
#line hidden
            BeginContext(558, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(597, 11, false);
#line 25 "C:\TFS\source\repos\PlayDotNet\CoreWebEmpty\Views\Employee\Index.cshtml"
               Write(employee.ID);

#line default
#line hidden
            EndContext();
            BeginContext(608, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(636, 13, false);
#line 26 "C:\TFS\source\repos\PlayDotNet\CoreWebEmpty\Views\Employee\Index.cshtml"
               Write(employee.Name);

#line default
#line hidden
            EndContext();
            BeginContext(649, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(677, 14, false);
#line 27 "C:\TFS\source\repos\PlayDotNet\CoreWebEmpty\Views\Employee\Index.cshtml"
               Write(employee.Email);

#line default
#line hidden
            EndContext();
            BeginContext(691, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(719, 19, false);
#line 28 "C:\TFS\source\repos\PlayDotNet\CoreWebEmpty\Views\Employee\Index.cshtml"
               Write(employee.Department);

#line default
#line hidden
            EndContext();
            BeginContext(738, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 30 "C:\TFS\source\repos\PlayDotNet\CoreWebEmpty\Views\Employee\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(775, 24, true);
            WriteLiteral("    </table>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(817, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(823, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f95e4df6e411ef40091d28144d939326290116a6366", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(867, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreWebEmpty.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
