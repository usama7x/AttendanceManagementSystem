#pragma checksum "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\CheckAttendance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6aab30a591f560312cac4965ecc2679f5986603f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Attendance_CheckAttendance), @"mvc.1.0.view", @"/Views/Attendance/CheckAttendance.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6aab30a591f560312cac4965ecc2679f5986603f", @"/Views/Attendance/CheckAttendance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d2a5fc31bb86ba83581a6878c711348d9c2a84d", @"/Views/_ViewImports.cshtml")]
    public class Views_Attendance_CheckAttendance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AttendanceManagementSystem.Core.ViewModels.StudentAttendanceViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\CheckAttendance.cshtml"
  
    ViewData["Title"] = "CheckAttendance";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Check Attendance</h1>\r\n\r\n<table class=\"table table-light\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\CheckAttendance.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\CheckAttendance.cshtml"
           Write(Html.DisplayNameFor(model => model.RollNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\CheckAttendance.cshtml"
           Write(Html.DisplayNameFor(model => model.IsAbsent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\CheckAttendance.cshtml"
           Write(Html.DisplayNameFor(model => model.Reason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\CheckAttendance.cshtml"
           Write(Html.DisplayNameFor(model => model.Stamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\CheckAttendance.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalAbsents));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\CheckAttendance.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\CheckAttendance.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\CheckAttendance.cshtml"
           Write(Html.DisplayFor(modelItem => item.RollNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\CheckAttendance.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsAbsent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\CheckAttendance.cshtml"
           Write(Html.DisplayFor(modelItem => item.Reason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\CheckAttendance.cshtml"
           Write(Html.DisplayFor(modelItem => item.Stamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\CheckAttendance.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalAbsents));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>           \r\n        </tr>\r\n");
#nullable restore
#line 55 "C:\Users\Usama\source\repos\AttendanceManagementSystemLive\AttendanceManagementSystem\Views\Attendance\CheckAttendance.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AttendanceManagementSystem.Core.ViewModels.StudentAttendanceViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
