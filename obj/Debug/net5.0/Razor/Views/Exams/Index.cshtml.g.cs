#pragma checksum "C:\Users\Katarina\Desktop\repos\StudentApp\StudentApp\Views\Exams\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b61c7a42ba7d37f063f8c40a339d860b851fe3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exams_Index), @"mvc.1.0.view", @"/Views/Exams/Index.cshtml")]
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
#line 1 "C:\Users\Katarina\Desktop\repos\StudentApp\StudentApp\Views\_ViewImports.cshtml"
using StudentApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Katarina\Desktop\repos\StudentApp\StudentApp\Views\_ViewImports.cshtml"
using StudentApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b61c7a42ba7d37f063f8c40a339d860b851fe3a", @"/Views/Exams/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4e64af998c59de15caf7de6f57a9d9a85cff9ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Exams_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("basic-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Katarina\Desktop\repos\StudentApp\StudentApp\Views\Exams\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<link href=\"https://cdn.datatables.net/1.10.22/css/jquery.dataTables.min.css\" rel=\"stylesheet\" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b61c7a42ba7d37f063f8c40a339d860b851fe3a5260", async() => {
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
            WriteLiteral("\r\n<script type=\"text/javascript\" src=\"https://cdn.datatables.net/1.10.22/js/jquery.dataTables.min.js\"></script>\r\n\r\n<br />\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b61c7a42ba7d37f063f8c40a339d860b851fe3a6523", async() => {
                WriteLiteral("\r\n    <input type=\"text\" id=\"txtExamId\" style=\"display:none;\" />\r\n    <input type=\"text\" id=\"txtStudentId\" style=\"display:none;\" />\r\n    <input type=\"text\" id=\"txtSubjectId\" style=\"display:none;\" />\r\n    <select id=\"student\" style=\"height:30px\">\r\n");
#nullable restore
#line 17 "C:\Users\Katarina\Desktop\repos\StudentApp\StudentApp\Views\Exams\Index.cshtml"
         foreach (var item in ViewBag.Students)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b61c7a42ba7d37f063f8c40a339d860b851fe3a7323", async() => {
#nullable restore
#line 19 "C:\Users\Katarina\Desktop\repos\StudentApp\StudentApp\Views\Exams\Index.cshtml"
                                         Write(item.IndexNumber);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\Katarina\Desktop\repos\StudentApp\StudentApp\Views\Exams\Index.cshtml"
               WriteLiteral(item.IndexNumber);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\Katarina\Desktop\repos\StudentApp\StudentApp\Views\Exams\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </select>\r\n    <select id=\"subject\" style=\"height:30px\">\r\n");
#nullable restore
#line 23 "C:\Users\Katarina\Desktop\repos\StudentApp\StudentApp\Views\Exams\Index.cshtml"
         foreach (var item in ViewBag.Subjects)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b61c7a42ba7d37f063f8c40a339d860b851fe3a9728", async() => {
#nullable restore
#line 25 "C:\Users\Katarina\Desktop\repos\StudentApp\StudentApp\Views\Exams\Index.cshtml"
                                   Write(item.Title);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\Katarina\Desktop\repos\StudentApp\StudentApp\Views\Exams\Index.cshtml"
               WriteLiteral(item.Title);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\Katarina\Desktop\repos\StudentApp\StudentApp\Views\Exams\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </select>
    <input type=""number"" id=""txtGrade"" min=""5"" max=""10"" placeholder=""Grade"" style=""margin-right:2px;"" />
    <input type=""datetime-local"" id=""txtDate"" placeholder=""Date"" style=""margin-right:2px;"" />

    <input id=""btnSave"" type=""submit"" value=""Save"" class=""btn btn-success"" style=""margin-right:5px;"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<br />
<br />

<table id=""tblExams"" class=""table table-striped table-bordered"">
    <thead>
        <tr>
            <th>Exam Id</th>
            <th>Student</th>
            <th>Subject</th>
            <th>Grade</th>
            <th>Exam Date</th>
            <th>Actions</th>
        </tr>
    </thead>
    <tbody>
    </tbody>
</table>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b61c7a42ba7d37f063f8c40a339d860b851fe3a13552", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script type=""text/javascript"">

    $(document).ready(function () {
        var table =
            $('#tblExams').DataTable({
                ajax: {
                    url: '/Exams/GetExams',
                    dataSrc: ''
                },
                columns: [
                    { data: 'ExamId' },
                    { data: 'Subject' },
                    { data: 'Student' },
                    { data: 'Grade' },
                    { data: 'ExamDate' },
                    {
                        data: ""id"", render: function (data, typ, row, meta) {
                            return ""<button class='btn btn-primary' style='margin-right: 2px;' onclick='Edit("" + JSON.stringify(row) + "")'>Edit</button>"" +
                                ""<button class='btn btn-danger' style='margin-right: 2px;' onclick='Delete("" + JSON.stringify(row) + "")'>Delete</button>"";
                        }
                    }
                ]
            });

        $(""#basic-form"").su");
            WriteLiteral(@"bmit(function (event) {

            event.preventDefault();


        });

    });

    function Edit(oStudent) {

   
    }


    function Delete(oExam) {

        var result = confirm(""Are you sure you want to delete?"");
        if (result) {
            $.post(""/Exams/Delete"", { id: oExam.ExamId },
                function (data) {
                    ReloadGrid();
                    alert(data);
                });
        }
    }
    function Reset() {
     
        $(""#txtStudentId"").val(0);
        $(""#txtStudentId"").val(0);
        $(""#txtSubjectId"").val(0);
        $(""#txtGrade"").val("""");
        $(""#txtDate"").val("""");
        $(""#student"").val("""");
        $(""#subject"").val("""");
    }
    function ReloadGrid() {
        $('#tblExams').DataTable().clear();
        $('#tblExams').DataTable().ajax.reload();
    }


    var connection = new signalR.HubConnectionBuilder().withUrl(""/examsHub"").build();


    document.getElementById(""btnSave"").disabled = true;");
            WriteLiteral(@"

    connection.on(""ReceiveMessage"", function () {
    
        alert(""New examiation added!"");
        ReloadGrid();
        Reset();
    });

    connection.on(""ReceiveMessageUpdate"", function () {
        ReloadGrid();
        Reset();
        alert(""Updated!"");
    });


    connection.on(""ReceiveMessageError"", function (data) {
        alert(data);
    });

    connection.start().then(function () {
        document.getElementById(""btnSave"").disabled = false;
    }).catch(function (err) {
        return console.error(err.toString());
    });

    document.getElementById(""btnSave"").addEventListener(""click"", function (event) {

        var id = ""0"";
        var grade = $(""#txtGrade"").val();
        var examDate = $(""#txtDate"").val();
        var subject = $(""#subject option:selected"").val();
        var student = $(""#student option:selected"").val();
        connection.invoke(""SendMessage"",  id,  grade, examDate,  student, subject).catch(function (err) {
            return ");
            WriteLiteral("console.error(err.toString());\r\n        });\r\n        event.preventDefault();\r\n    });\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591