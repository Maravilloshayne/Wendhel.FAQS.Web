#pragma checksum "C:\Users\Shayne Maravillo\source\repos\WendhelAton.FAQ\WendhelAton.FAQ.Web\Areas\Manage\Views\Faqs\UpdateQuestion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a89b9fa45d9b01b8cb8b9364e1b4817e943d1828"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Faqs_UpdateQuestion), @"mvc.1.0.view", @"/Areas/Manage/Views/Faqs/UpdateQuestion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/Faqs/UpdateQuestion.cshtml", typeof(AspNetCore.Areas_Manage_Views_Faqs_UpdateQuestion))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a89b9fa45d9b01b8cb8b9364e1b4817e943d1828", @"/Areas/Manage/Views/Faqs/UpdateQuestion.cshtml")]
    public class Areas_Manage_Views_Faqs_UpdateQuestion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WendhelAton.FAQ.Web.Areas.Manage.ViewModels.Faqs.UpdateQuestionViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/faqs/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/faqs/update-question"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Shayne Maravillo\source\repos\WendhelAton.FAQ\WendhelAton.FAQ.Web\Areas\Manage\Views\Faqs\UpdateQuestion.cshtml"
  
    ViewData["Title"] = "UpdateQuestion";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(178, 623, true);
            WriteLiteral(@"
<section id=""subintro"" style=""background-color:darkred"">
    <div class=""jumbotron subhead"" id=""overview"">
        <div class=""container"">
            <div class=""row"">
                <div class=""span12"">
                    <div class=""centered"">
                        <h3>College of Subic Montessori,Inc.</h3>
                        <p>
                           Update Title FAQS
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
            BeginContext(801, 1333, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0109be70b7574ffda6c5c67f0f4e4292", async() => {
                BeginContext(860, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(875, 24, false);
#line 29 "C:\Users\Shayne Maravillo\source\repos\WendhelAton.FAQ\WendhelAton.FAQ.Web\Areas\Manage\Views\Faqs\UpdateQuestion.cshtml"
       Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(899, 86, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 985, "\"", 1002, 1);
#line 31 "C:\Users\Shayne Maravillo\source\repos\WendhelAton.FAQ\WendhelAton.FAQ.Web\Areas\Manage\Views\Faqs\UpdateQuestion.cshtml"
WriteAttributeValue("", 993, Model.Id, 993, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1003, 141, true);
                WriteLiteral(" />\r\n                <label for=\"Title\">Title:</label>\r\n                <input id=\"question\" type=\"text\" class=\"form-control\" name=\"Question\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1144, "\"", 1167, 1);
#line 33 "C:\Users\Shayne Maravillo\source\repos\WendhelAton.FAQ\WendhelAton.FAQ.Web\Areas\Manage\Views\Faqs\UpdateQuestion.cshtml"
WriteAttributeValue("", 1152, Model.Question, 1152, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1168, 216, true);
                WriteLiteral(" />\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"Post Expiry\">Post Expiry:</label>\r\n                <input type=\"text\" class=\"form-control\" name=\"PostExpiry\" id=\"Post Expiry\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1384, "\"", 1409, 1);
#line 37 "C:\Users\Shayne Maravillo\source\repos\WendhelAton.FAQ\WendhelAton.FAQ.Web\Areas\Manage\Views\Faqs\UpdateQuestion.cshtml"
WriteAttributeValue("", 1392, Model.PostExpiry, 1392, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1410, 211, true);
                WriteLiteral(" />\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"Template\">Template:</label>\r\n                <select name=\"TemplateName\">\r\n\r\n                    <option value=\"post 1\" ");
                EndContext();
                BeginContext(1623, 48, false);
#line 43 "C:\Users\Shayne Maravillo\source\repos\WendhelAton.FAQ\WendhelAton.FAQ.Web\Areas\Manage\Views\Faqs\UpdateQuestion.cshtml"
                                       Write(Model.TemplateName == "post 1" ? "selected" : "");

#line default
#line hidden
                EndContext();
                BeginContext(1672, 61, true);
                WriteLiteral(">post 1</option>\r\n                    <option value=\"post 2\" ");
                EndContext();
                BeginContext(1735, 48, false);
#line 44 "C:\Users\Shayne Maravillo\source\repos\WendhelAton.FAQ\WendhelAton.FAQ.Web\Areas\Manage\Views\Faqs\UpdateQuestion.cshtml"
                                       Write(Model.TemplateName == "post 2" ? "selected" : "");

#line default
#line hidden
                EndContext();
                BeginContext(1784, 61, true);
                WriteLiteral(">post 2</option>\r\n                    <option value=\"post 3\" ");
                EndContext();
                BeginContext(1847, 48, false);
#line 45 "C:\Users\Shayne Maravillo\source\repos\WendhelAton.FAQ\WendhelAton.FAQ.Web\Areas\Manage\Views\Faqs\UpdateQuestion.cshtml"
                                       Write(Model.TemplateName == "post 3" ? "selected" : "");

#line default
#line hidden
                EndContext();
                BeginContext(1896, 158, true);
                WriteLiteral(">post 3</option>\r\n                </select>\r\n\r\n\r\n            </div>\r\n\r\n            <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n            ");
                EndContext();
                BeginContext(2054, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30b2895c532c4d0e82b371a3200c8832", async() => {
                    BeginContext(2107, 6, true);
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
                BeginContext(2117, 10, true);
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
            BeginContext(2134, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("pageScripts", async() => {
                BeginContext(2179, 139, true);
                WriteLiteral("\r\n    <script>\r\n        $(function () {\r\n            $(\"#PostExpiry\").datepicker({ dateFormat: \'dd/mm/yy\' });\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WendhelAton.FAQ.Web.Areas.Manage.ViewModels.Faqs.UpdateQuestionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
