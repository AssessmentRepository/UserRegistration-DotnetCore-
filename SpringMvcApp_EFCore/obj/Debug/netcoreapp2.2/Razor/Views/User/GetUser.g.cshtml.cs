#pragma checksum "C:\Users\Kavya H\Desktop\kavya\SpringMvcApp_EFCore\SpringMvcApp_EFCore\Views\User\GetUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4573a1a861a6aed9235e322dca9ffa461b0b0eb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_GetUser), @"mvc.1.0.view", @"/Views/User/GetUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/GetUser.cshtml", typeof(AspNetCore.Views_User_GetUser))]
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
#line 1 "C:\Users\Kavya H\Desktop\kavya\SpringMvcApp_EFCore\SpringMvcApp_EFCore\Views\_ViewImports.cshtml"
using SpringMvcApp_EFCore;

#line default
#line hidden
#line 2 "C:\Users\Kavya H\Desktop\kavya\SpringMvcApp_EFCore\SpringMvcApp_EFCore\Views\_ViewImports.cshtml"
using SpringMvcApp_EFCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4573a1a861a6aed9235e322dca9ffa461b0b0eb5", @"/Views/User/GetUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc45e42d5b695a48715e706112007d14707a96df", @"/Views/_ViewImports.cshtml")]
    public class Views_User_GetUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SpringMvcApp.Entities.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Kavya H\Desktop\kavya\SpringMvcApp_EFCore\SpringMvcApp_EFCore\Views\User\GetUser.cshtml"
  
    ViewData["Title"] = "GetUser";

#line default
#line hidden
            BeginContext(80, 127, true);
            WriteLiteral("\r\n<h1>GetUser</h1>\r\n\r\n<div>\r\n    <h4>User</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(208, 38, false);
#line 14 "C:\Users\Kavya H\Desktop\kavya\SpringMvcApp_EFCore\SpringMvcApp_EFCore\Views\User\GetUser.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(246, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(310, 34, false);
#line 17 "C:\Users\Kavya H\Desktop\kavya\SpringMvcApp_EFCore\SpringMvcApp_EFCore\Views\User\GetUser.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(344, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(407, 44, false);
#line 20 "C:\Users\Kavya H\Desktop\kavya\SpringMvcApp_EFCore\SpringMvcApp_EFCore\Views\User\GetUser.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(451, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(515, 40, false);
#line 23 "C:\Users\Kavya H\Desktop\kavya\SpringMvcApp_EFCore\SpringMvcApp_EFCore\Views\User\GetUser.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(555, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(618, 44, false);
#line 26 "C:\Users\Kavya H\Desktop\kavya\SpringMvcApp_EFCore\SpringMvcApp_EFCore\Views\User\GetUser.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(662, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(726, 40, false);
#line 29 "C:\Users\Kavya H\Desktop\kavya\SpringMvcApp_EFCore\SpringMvcApp_EFCore\Views\User\GetUser.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(766, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(829, 51, false);
#line 32 "C:\Users\Kavya H\Desktop\kavya\SpringMvcApp_EFCore\SpringMvcApp_EFCore\Views\User\GetUser.cshtml"
       Write(Html.DisplayNameFor(model => model.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(880, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(944, 47, false);
#line 35 "C:\Users\Kavya H\Desktop\kavya\SpringMvcApp_EFCore\SpringMvcApp_EFCore\Views\User\GetUser.cshtml"
       Write(Html.DisplayFor(model => model.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(991, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1054, 41, false);
#line 38 "C:\Users\Kavya H\Desktop\kavya\SpringMvcApp_EFCore\SpringMvcApp_EFCore\Views\User\GetUser.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1159, 37, false);
#line 41 "C:\Users\Kavya H\Desktop\kavya\SpringMvcApp_EFCore\SpringMvcApp_EFCore\Views\User\GetUser.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1196, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1259, 41, false);
#line 44 "C:\Users\Kavya H\Desktop\kavya\SpringMvcApp_EFCore\SpringMvcApp_EFCore\Views\User\GetUser.cshtml"
       Write(Html.DisplayNameFor(model => model.Photo));

#line default
#line hidden
            EndContext();
            BeginContext(1300, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1364, 37, false);
#line 47 "C:\Users\Kavya H\Desktop\kavya\SpringMvcApp_EFCore\SpringMvcApp_EFCore\Views\User\GetUser.cshtml"
       Write(Html.DisplayFor(model => model.Photo));

#line default
#line hidden
            EndContext();
            BeginContext(1401, 49, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1451, 68, false);
#line 53 "C:\Users\Kavya H\Desktop\kavya\SpringMvcApp_EFCore\SpringMvcApp_EFCore\Views\User\GetUser.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1519, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1527, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4573a1a861a6aed9235e322dca9ffa461b0b0eb59658", async() => {
                BeginContext(1549, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1565, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SpringMvcApp.Entities.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
