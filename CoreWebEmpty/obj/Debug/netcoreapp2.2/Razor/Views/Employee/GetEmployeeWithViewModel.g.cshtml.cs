#pragma checksum "C:\TFS\source\repos\PlayDotNet\CoreWebEmpty\Views\Employee\GetEmployeeWithViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fb1c33cdb22ccc9b29751baeef3ff0c3e99a1e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_GetEmployeeWithViewModel), @"mvc.1.0.view", @"/Views/Employee/GetEmployeeWithViewModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/GetEmployeeWithViewModel.cshtml", typeof(AspNetCore.Views_Employee_GetEmployeeWithViewModel))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fb1c33cdb22ccc9b29751baeef3ff0c3e99a1e6", @"/Views/Employee/GetEmployeeWithViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c701f2cc4e24eefce42c518a90ecfbf65e4d9f17", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_GetEmployeeWithViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeDetailsViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 47, true);
            WriteLiteral("\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            EndContext();
            BeginContext(80, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fb1c33cdb22ccc9b29751baeef3ff0c3e99a1e63527", async() => {
                BeginContext(86, 23, true);
                WriteLiteral("\r\n    <title></title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(116, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(118, 294, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fb1c33cdb22ccc9b29751baeef3ff0c3e99a1e64731", async() => {
                BeginContext(124, 10, true);
                WriteLiteral("\r\n    <h1>");
                EndContext();
                BeginContext(135, 15, false);
#line 8 "C:\TFS\source\repos\PlayDotNet\CoreWebEmpty\Views\Employee\GetEmployeeWithViewModel.cshtml"
   Write(Model.PageTitle);

#line default
#line hidden
                EndContext();
                BeginContext(150, 30, true);
                WriteLiteral("</h1>\r\n    <div>\r\n        ID: ");
                EndContext();
                BeginContext(181, 17, false);
#line 10 "C:\TFS\source\repos\PlayDotNet\CoreWebEmpty\Views\Employee\GetEmployeeWithViewModel.cshtml"
       Write(Model.Employee.ID);

#line default
#line hidden
                EndContext();
                BeginContext(198, 39, true);
                WriteLiteral("\r\n    </div>\r\n    <div>\r\n        Name: ");
                EndContext();
                BeginContext(238, 19, false);
#line 13 "C:\TFS\source\repos\PlayDotNet\CoreWebEmpty\Views\Employee\GetEmployeeWithViewModel.cshtml"
         Write(Model.Employee.Name);

#line default
#line hidden
                EndContext();
                BeginContext(257, 40, true);
                WriteLiteral("\r\n    </div>\r\n    <div>\r\n        Email: ");
                EndContext();
                BeginContext(298, 20, false);
#line 16 "C:\TFS\source\repos\PlayDotNet\CoreWebEmpty\Views\Employee\GetEmployeeWithViewModel.cshtml"
          Write(Model.Employee.Email);

#line default
#line hidden
                EndContext();
                BeginContext(318, 45, true);
                WriteLiteral("\r\n    </div>\r\n    <div>\r\n        Department: ");
                EndContext();
                BeginContext(364, 25, false);
#line 19 "C:\TFS\source\repos\PlayDotNet\CoreWebEmpty\Views\Employee\GetEmployeeWithViewModel.cshtml"
               Write(Model.Employee.Department);

#line default
#line hidden
                EndContext();
                BeginContext(389, 16, true);
                WriteLiteral("\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(412, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
