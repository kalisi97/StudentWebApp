#pragma checksum "C:\Users\Katarina\Desktop\repos\StudentApp\StudentApp\Views\Exams\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01643f8f4663e634a5b6bbea0d69fa717d3049b5"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01643f8f4663e634a5b6bbea0d69fa717d3049b5", @"/Views/Exams/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4e64af998c59de15caf7de6f57a9d9a85cff9ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Exams_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01643f8f4663e634a5b6bbea0d69fa717d3049b55133", async() => {
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
            WriteLiteral(@"
<link href=""https://cdn.datatables.net/1.10.22/css/jquery.dataTables.min.css"" rel=""stylesheet"" />
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.0/jquery.min.js""></script>
<script type=""text/javascript"" src=""https://cdn.datatables.net/1.10.22/js/jquery.dataTables.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.19.0/jquery.validate.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.26.0/moment.min.js""></script>
<script src=""https://cdn.datatables.net/plug-ins/1.10.21/dataRender/datetime.js""></script>


<br />
<br />

    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01643f8f4663e634a5b6bbea0d69fa717d3049b56886", async() => {
                WriteLiteral(@"
        <div class=""form-row"">

                <input type=""text"" id=""txtExamId"" style=""display:none;"" />
                <input type=""text"" id=""txtStudentId"" style=""display:none;"" />
                <input type=""text"" id=""txtSubjectId"" style=""display:none;"" />
            <div class=""col-xs-2"">
                <label>Student</label>
                <select id=""student"" style=""height:30px"" name=""student"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01643f8f4663e634a5b6bbea0d69fa717d3049b57609", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 28 "C:\Users\Katarina\Desktop\repos\StudentApp\StudentApp\Views\Exams\Index.cshtml"
                     foreach (var item in ViewBag.Students)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01643f8f4663e634a5b6bbea0d69fa717d3049b59204", async() => {
#nullable restore
#line 30 "C:\Users\Katarina\Desktop\repos\StudentApp\StudentApp\Views\Exams\Index.cshtml"
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
#line 30 "C:\Users\Katarina\Desktop\repos\StudentApp\StudentApp\Views\Exams\Index.cshtml"
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
#line 31 "C:\Users\Katarina\Desktop\repos\StudentApp\StudentApp\Views\Exams\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\"col-xs-2 col-half-offset\">\r\n                <label>Subject</label>\r\n                <select id=\"subject\" style=\"height:30px\" name=\"subject\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01643f8f4663e634a5b6bbea0d69fa717d3049b511559", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\Katarina\Desktop\repos\StudentApp\StudentApp\Views\Exams\Index.cshtml"
                     foreach (var item in ViewBag.Subjects)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01643f8f4663e634a5b6bbea0d69fa717d3049b513155", async() => {
#nullable restore
#line 40 "C:\Users\Katarina\Desktop\repos\StudentApp\StudentApp\Views\Exams\Index.cshtml"
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
#line 40 "C:\Users\Katarina\Desktop\repos\StudentApp\StudentApp\Views\Exams\Index.cshtml"
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
#line 41 "C:\Users\Katarina\Desktop\repos\StudentApp\StudentApp\Views\Exams\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </select>
            </div>
            <div class=""col-xs-2 col-half-offset"">
                <label>Grade</label>
                <input type=""number"" id=""txtGrade"" name=""grade"" min=""5"" max=""10"" placeholder=""Grade"" style=""margin-right:2px;"" />
            </div>
            <div class=""col-xs-2 col-half-offset"">
                <label>Date</label>
                <input type=""datetime-local"" name=""date"" id=""txtDate"" placeholder=""Date"" />
            </div>
            <div class=""col-xs-2 col-half-offset"">
                <br />
                <input id=""btnSave"" type=""submit"" value=""Save Changes"" class=""btn btn-success"" />
            </div>   
        </div>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01643f8f4663e634a5b6bbea0d69fa717d3049b517407", async() => {
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
                paging: true,
                pageLength: 10,
                lengthMenu: [10, 25, 50, 100],
                columns: [
                    { data: 'ExamId' },
                    { data: 'Subject' },
                    { data: 'Student' },
                    { data: 'Grade' },
                    { data: 'ExamDate', cellType: 'date' },
                    {
                        data: ""id"", render: function (data, typ, row, meta) {
                            return ""<button class='btn btn-primary' style='margin-right: 2px;' onclick='Edit("" + JSON.stringify(row) + "")'>Edit</button>"" +
                                ""<button class='btn btn-danger' style='margin-right: 2px;' onclick='Delete("" + JSON.stringify(row) + "")'>");
            WriteLiteral(@"Delete</button>"";
                        }
                    }
                ],
                columnDefs: [{
                    render: $.fn.dataTable.render.moment('YYYY-MM-DDTHH:mm:ss', 'MM/DD/YYYY HH:mm'),
                    targets: 4
                }]
            });

        $.validator.addMethod(""maxDate"", function (value) {
            var curDate = new Date();
            var inputDate = new Date(value);
            if (inputDate < curDate)
                return true;
            return false;
        }, ""Must be today date or less!"");
    });

    function Edit(oExam) {

        var validator = $(""#basic-form"").validate();
        validator.destroy();

        $(""#txtExamId"").val(oExam.ExamId);
        $(""#student"").val(oExam.Student);
        $(""#subject"").val(oExam.Subject);
        $(""#txtGrade"").val(oExam.Grade);
        $(""#txtDate"").val(oExam.ExamDate);

    }


    function Delete(oExam) {

        var result = confirm(""Are you sure you want to de");
            WriteLiteral(@"lete?"");
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
        $(""#txtExamId"").val(0);
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


    document.getElementById(""btnSave"").disabled = true;

    connection.on(""ReceiveMessage"", function () {

        alert(""New examination added!"");
        ReloadGrid();
        Reset();
    });

    connection.on(""ReceiveMessageUpdate"", function () {
        ReloadGrid();
     ");
            WriteLiteral(@"   Reset();
        alert(""Updated!"");
    });


    connection.on(""ReceiveMessageError"", function (data) {
        alert(data);
        Reset();
    });

    connection.start().then(function () {
        document.getElementById(""btnSave"").disabled = false;
    }).catch(function (err) {
        return console.error(err.toString());
    });


    document.getElementById(""btnSave"").addEventListener(""click"", function (event) {


        $(""#basic-form"").validate({
            rules: {
                grade: {
                    required: true,
                    number: true,
                    min: 5,
                    max: 10
                },
                date:
                {
                    required: true,
                    maxDate: true
                },
                student:
                {
                    required: true
                },
                subject:
                {
                    required: true
                }
    ");
            WriteLiteral(@"        },
            messages: {
                grade: {
                    required: ""Required!"",
                    number: true,
                    min: ""Grade cannot be less than 5!"",
                    max: ""Grade cannot be greather than 10!""
                },
                date: {
                    required: ""Required!""
                },
                student: {
                    required: ""Required!""
                },
                subject: {
                    required: ""Required!""
                }

            }
        });

        if ($('#basic-form').valid()) {

            var id = $.trim($(""#txtExamId"").val()) == """" ? ""0"" : $(""#txtExamId"").val();
            var grade = $(""#txtGrade"").val();
            var examDate = $(""#txtDate"").val();
            var subject = $(""#subject option:selected"").val();
            var student = $(""#student option:selected"").val();

            if (id !== ""0"") {

                var exam = {

                  ");
            WriteLiteral(@"  ExamId: id,
                    Student: student,
                    Subject: subject,
                    Grade: grade,
                    ExamDate: examDate
                };

                event.preventDefault();

                $.ajax({
                    type: ""POST"",
                    url: ""/Exams/Edit"",
                    data: JSON.stringify(exam),
                    contentType: ""application/json; charset=utf-8"",
                    dataType: ""json"",
                    success: function (data) {
                        Reset();
                        ReloadGrid();
                        alert(data);
                    }
                });


            } else {

                connection.invoke(""SendMessage"", id, grade, examDate, student, subject).catch(function (err) {
                    return console.error(err.toString());
                });
                event.preventDefault();
            }

        }

    });

</script>
");
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
