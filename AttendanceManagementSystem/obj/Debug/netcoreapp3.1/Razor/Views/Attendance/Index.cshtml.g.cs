#pragma checksum "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7855bd03b229113a6d4a55f135c6b25e52cae344"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Attendance_Index), @"mvc.1.0.view", @"/Views/Attendance/Index.cshtml")]
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
#line 1 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\_ViewImports.cshtml"
using AttendanceManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\_ViewImports.cshtml"
using AttendanceManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7855bd03b229113a6d4a55f135c6b25e52cae344", @"/Views/Attendance/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d2a5fc31bb86ba83581a6878c711348d9c2a84d", @"/Views/_ViewImports.cshtml")]
    public class Views_Attendance_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AttendanceManagementSystem.Core.ViewModels.AttendanceViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "subjectId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("attendanceForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Attendance", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_TeacherView";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Mark Attendance</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7855bd03b229113a6d4a55f135c6b25e52cae3445755", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7855bd03b229113a6d4a55f135c6b25e52cae3446017", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 8 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(Model.Subjects,"SubjectId","Name"));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <input type=\"submit\" value=\"Attendance Sheet\" class=\"form-control\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 12 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\Index.cshtml"
 using (Html.BeginForm("Create", "Attendance", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Mark Attendance\" class=\"form-control\" />\r\n");
            WriteLiteral("<table class=\"table table-light\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                \r\n                ");
#nullable restore
#line 24 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Student.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Student.RollNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Student.IsAbsent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Student.Reason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Student.TotalAbsents));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 43 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\Index.cshtml"
         for (var item = 0; item < Model.Students.Count(); item++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                ");
#nullable restore
#line 46 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\Index.cshtml"
           Write(Html.HiddenFor(x => x.Students[item].Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 47 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\Index.cshtml"
           Write(Html.HiddenFor(x => x.SubjectId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\Index.cshtml"
               Write(Html.DisplayFor(modelItem => Model.Students[item].RollNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 50 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\Index.cshtml"
               Write(Html.HiddenFor(x => x.Students[item].RollNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\Index.cshtml"
               Write(Html.DisplayFor(modelItem => Model.Students[item].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 54 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\Index.cshtml"
               Write(Html.HiddenFor(x => x.Students[item].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\Index.cshtml"
               Write(Html.RadioButtonFor(x => x.Students[item].IsAbsent, "false"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Present\r\n                    ");
#nullable restore
#line 58 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\Index.cshtml"
               Write(Html.RadioButtonFor(x => x.Students[item].IsAbsent, "true"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Absent\r\n                    \r\n                </td>\r\n                <td>\r\n                    \r\n");
            WriteLiteral("                    ");
#nullable restore
#line 64 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\Index.cshtml"
               Write(Html.DropDownListFor(x => x.Students[item].Reason, new List<SelectListItem> { new SelectListItem {Text= "Sick", Value = "sick" },
                                                                                                   new SelectListItem {Text = "Late", Value = "late" },
                                                                                                   new SelectListItem {Text = "Leave", Value = "leave" } }, "Select Reason", new { }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\Index.cshtml"
               Write(Html.DisplayFor(modelItem => Model.Students[item].TotalAbsents));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 70 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\Index.cshtml"
               Write(Html.HiddenFor(x => x.Students[item].TotalAbsents));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 73 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 76 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AttendanceManagementSystem.Core.ViewModels.AttendanceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591