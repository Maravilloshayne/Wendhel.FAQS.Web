#pragma checksum "C:\Users\Shayne Maravillo\source\repos\WendhelAton.FAQ\WendhelAton.FAQ.Web\Areas\Manage\Views\Threads\UpdateTitle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44d4fd7d8f5f6bbcf3892b56df2b366543d9796a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Threads_UpdateTitle), @"mvc.1.0.view", @"/Areas/Manage/Views/Threads/UpdateTitle.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/Threads/UpdateTitle.cshtml", typeof(AspNetCore.Areas_Manage_Views_Threads_UpdateTitle))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44d4fd7d8f5f6bbcf3892b56df2b366543d9796a", @"/Areas/Manage/Views/Threads/UpdateTitle.cshtml")]
    public class Areas_Manage_Views_Threads_UpdateTitle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WendhelAton.FAQ.Web.Areas.Manage.ViewModels.Threads.UpdateTitleViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/threads/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/threads/update-title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Shayne Maravillo\source\repos\WendhelAton.FAQ\WendhelAton.FAQ.Web\Areas\Manage\Views\Threads\UpdateTitle.cshtml"
  
    ViewData["Title"] = "UpdateTitle";
    Layout = "~/Views/Shared/_PublicLayout.cshtml";

#line default
#line hidden
            BeginContext(181, 631, true);
            WriteLiteral(@"
<section id=""subintro"" style=""background-color:darkred"">
    <div class=""jumbotron subhead"" id=""overview"">
        <div class=""container"">
            <div class=""row"">
                <div class=""span12"">
                    <div class=""centered"">
                        <h3>College of Subic Montessori,Inc.</h3>
                        <p>
                            Admin Threads Update Title
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<h2>Update Title</h2>

<div class=""row"">
    <div class=""col-md-6"">
        ");
            EndContext();
            BeginContext(812, 1627, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81882f47441a415cacc8c2e10d3b89ab", async() => {
                BeginContext(871, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(886, 24, false);
#line 28 "C:\Users\Shayne Maravillo\source\repos\WendhelAton.FAQ\WendhelAton.FAQ.Web\Areas\Manage\Views\Threads\UpdateTitle.cshtml"
       Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(910, 86, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 996, "\"", 1013, 1);
#line 30 "C:\Users\Shayne Maravillo\source\repos\WendhelAton.FAQ\WendhelAton.FAQ.Web\Areas\Manage\Views\Threads\UpdateTitle.cshtml"
WriteAttributeValue("", 1004, Model.Id, 1004, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1014, 135, true);
                WriteLiteral(" />\r\n                <label for=\"Title\">Title:</label>\r\n                <input type=\"text\" class=\"form-control\" name=\"Title\" id=\"title\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1149, "\"", 1169, 1);
#line 32 "C:\Users\Shayne Maravillo\source\repos\WendhelAton.FAQ\WendhelAton.FAQ.Web\Areas\Manage\Views\Threads\UpdateTitle.cshtml"
WriteAttributeValue("", 1157, Model.Title, 1157, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1170, 239, true);
                WriteLiteral(" />\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"Description\">Description</label>\r\n                <textarea class=\"form-control\" id=\"description\" rows=\"4\" name=\"Description\">\r\n                    ");
                EndContext();
                BeginContext(1410, 17, false);
#line 37 "C:\Users\Shayne Maravillo\source\repos\WendhelAton.FAQ\WendhelAton.FAQ.Web\Areas\Manage\Views\Threads\UpdateTitle.cshtml"
               Write(Model.Description);

#line default
#line hidden
                EndContext();
                BeginContext(1427, 238, true);
                WriteLiteral("\r\n                </textarea>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"Update At\">Post Expiry:</label>\r\n                <input type=\"text\" class=\"form-control\" name=\"UpdatedAt\" id=\"Updated At\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1665, "\"", 1689, 1);
#line 42 "C:\Users\Shayne Maravillo\source\repos\WendhelAton.FAQ\WendhelAton.FAQ.Web\Areas\Manage\Views\Threads\UpdateTitle.cshtml"
WriteAttributeValue("", 1673, Model.UpdatedAt, 1673, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1690, 233, true);
                WriteLiteral(" />\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"TemplateName\" id=\"templatename\">Template:</label>\r\n                <select name=\"TemplateName\">\r\n\r\n                    <option value=\"post 1\" ");
                EndContext();
                BeginContext(1925, 48, false);
#line 48 "C:\Users\Shayne Maravillo\source\repos\WendhelAton.FAQ\WendhelAton.FAQ.Web\Areas\Manage\Views\Threads\UpdateTitle.cshtml"
                                       Write(Model.TemplateName == "post 1" ? "selected" : "");

#line default
#line hidden
                EndContext();
                BeginContext(1974, 61, true);
                WriteLiteral(">post 1</option>\r\n                    <option value=\"post 2\" ");
                EndContext();
                BeginContext(2037, 48, false);
#line 49 "C:\Users\Shayne Maravillo\source\repos\WendhelAton.FAQ\WendhelAton.FAQ.Web\Areas\Manage\Views\Threads\UpdateTitle.cshtml"
                                       Write(Model.TemplateName == "post 2" ? "selected" : "");

#line default
#line hidden
                EndContext();
                BeginContext(2086, 61, true);
                WriteLiteral(">post 2</option>\r\n                    <option value=\"post 3\" ");
                EndContext();
                BeginContext(2149, 48, false);
#line 50 "C:\Users\Shayne Maravillo\source\repos\WendhelAton.FAQ\WendhelAton.FAQ.Web\Areas\Manage\Views\Threads\UpdateTitle.cshtml"
                                       Write(Model.TemplateName == "post 3" ? "selected" : "");

#line default
#line hidden
                EndContext();
                BeginContext(2198, 158, true);
                WriteLiteral(">post 3</option>\r\n                </select>\r\n\r\n\r\n            </div>\r\n\r\n            <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n            ");
                EndContext();
                BeginContext(2356, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb720e2c600941f2b36d61ac9f90e0a4", async() => {
                    BeginContext(2412, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2422, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2439, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("pageScripts", async() => {
                BeginContext(2484, 126, true);
                WriteLiteral("\r\n    <script>\r\n    $(function () {\r\n        $(\"#UpdatedAt\").datepicker({ dateFormat: \'dd/mm/yy\' });\r\n    });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WendhelAton.FAQ.Web.Areas.Manage.ViewModels.Threads.UpdateTitleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591