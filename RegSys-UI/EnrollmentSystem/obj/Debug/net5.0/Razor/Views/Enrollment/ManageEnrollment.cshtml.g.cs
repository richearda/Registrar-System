#pragma checksum "C:\Users\RICHE\Desktop\Riche Files\Source Codes\Registrar System\RegSys-UI\EnrollmentSystem\Views\Enrollment\ManageEnrollment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34e8e3f8c37f01e3d1904d2c5793eff6639fecb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Enrollment_ManageEnrollment), @"mvc.1.0.view", @"/Views/Enrollment/ManageEnrollment.cshtml")]
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
#line 1 "C:\Users\RICHE\Desktop\Riche Files\Source Codes\Registrar System\RegSys-UI\EnrollmentSystem\Views\_ViewImports.cshtml"
using EnrollmentSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RICHE\Desktop\Riche Files\Source Codes\Registrar System\RegSys-UI\EnrollmentSystem\Views\_ViewImports.cshtml"
using EnrollmentSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34e8e3f8c37f01e3d1904d2c5793eff6639fecb7", @"/Views/Enrollment/ManageEnrollment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ad39cc58f53fe6c7e239218454b18e434fd3dca", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Enrollment_ManageEnrollment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/enrollment/manageenrollment.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/mandaue_city_college_logo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Republic of the Philippines logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:80px; height:80px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34e8e3f8c37f01e3d1904d2c5793eff6639fecb75278", async() => {
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
            WriteLiteral(@"


<!-- Content Header (Page header) -->
<div class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h1 class=""m-0"">Enrollment</h1>
            </div><!-- /.col -->
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    <li class=""breadcrumb-item""><a href=""#"">Manage</a></li>
                    <li class=""breadcrumb-item active"">Enrollment</li>
                </ol>
            </div><!-- /.col -->
        </div><!-- /.row -->
    </div><!-- /.container-fluid -->
</div>
<!-- /.content-header -->

<div class=""content"">
    <div class=""container-fluid"">
        <div class=""card card-success card-outline"">
            <div class=""card-body"">              
                <!--Enrollees Table-->
                <table id=""enrolleesTable"" class=""dataTable data-table-width compact hover row-border stripe"">
");
            WriteLiteral(@"                </table>
            </div>
        </div>
    </div>

</div>

    <!--Modal Course Enrollment-->
 <div class=""modal fade"" id=""courseEnrollmentModal"" data-bs-backdrop=""static"" data-bs-keyboard=""false"">
        <div class=""modal-dialog modal-dialog-centered modal-xl"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""enrollmentModalLabel"">Enroll Student</h5>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                </div>
                <div class=""modal-body"">

                    <div class=""row justify-content-between enrollment-info"">
                        <input type=""hidden"" id=""activeTermId"" />
                        <input type=""hidden"" id=""activeSemId""/>
                        <div class=""col-md-5"">
                            <label class=""form-label"">Enrollment No.</label>
                            <div cl");
            WriteLiteral(@"ass=""input-group input-group-sm"">
                                <input type=""text"" class=""form-control"" id=""enrollmentNo"" aria-label=""Enrollment Number"" aria-describedby=""input-enrollment-number"">
                            </div>

                            <label class=""form-label"">Enrollment Date:</label>
                            <div class=""input-group input-group-sm"">
                                <input type=""text"" class=""form-control"" id=""enrollmentDate"" aria-label=""Enrollment Date"" aria-describedby=""input-enrollment-date"">
                            </div>

                            <label class=""form-label"">School Year:</label>
                            <div class=""input-group input-group-sm"">
                                <input type=""text"" class=""form-control"" id=""schoolYear"" aria-label=""Current School Year"" aria-describedby=""input-school-year"">
                            </div>

                            <label class=""form-label"">Semester:</label>
                ");
            WriteLiteral(@"            <div class=""input-group input-group-sm"">
                                <input type=""text"" class=""form-control"" id=""semester"" aria-label=""Current Semester"" aria-describedby=""input-semester"">
                            </div>
                            <label class=""form-label"">Block</label>
                            <select id=""blocks"" class=""form-select"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34e8e3f8c37f01e3d1904d2c5793eff6639fecb79988", async() => {
                WriteLiteral("Select a Block");
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
            WriteLiteral(@"
                            </select>
                        </div>

                        <div class=""col-md-5"">
                            <label class=""form-label"">Student Name</label>
                            <div class=""input-group input-group-sm"">
                                <input type=""text"" class=""form-control"" id=""studentName"" aria-label=""Student Name"" aria-describedby=""input-student-name"">
                            </div>

                            <input type=""hidden"" id=""studentId"" />
                            <label class=""form-label"">Student No.</label>
                            <div class=""input-group input-group-sm"">
                                <input type=""text"" class=""form-control"" id=""studentNo"" aria-label=""Student Number"" aria-describedby=""input-student-number"">
                            </div>


                            <label class=""form-label"">Program</label>
                            <div class=""input-group input-group-sm"">
           ");
            WriteLiteral(@"                     <input type=""text"" class=""form-control"" id=""program"" aria-label=""Program"" aria-describedby=""input-program"">
                            </div>

                            <label class=""form-label"">Major</label>
                            <div class=""input-group input-group-sm"">
                                <input type=""text"" class=""form-control"" id=""major"" aria-label=""Major"" aria-describedby=""input-major"">
                            </div>

                            <label class=""form-label"">Year Level</label>
                            <div class=""input-group input-group-sm"">
                                <input type=""text"" class=""form-control"" id=""yearLevel"" aria-label=""Year Level"" aria-describedby=""input-year-level"">
                            </div>
                        </div>
                    </div>

                <!--Table to display enrolled subjects-->
                <div class=""col-md-12 col-12"">
                    <div class=""row justify-co");
            WriteLiteral(@"ntent-center mt-5"">
                        <div class=""col-md-12 mt-1 enrolledCourseListTable"">
                            
                        </div>
                    </div>
                </div>

                <!--Table to display block courses-->
                    <div class=""col-md-12 col-12 courseTable""></div>                 
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-primary"" id=""enrollStudentButton"">Enroll Student</button>
                </div>
            </div>
        </div>
    </div>


    <!--Enrollment Info Modal-->
 <div class=""modal fade"" id=""studentEnrollmentInfoModal"" data-bs-backdrop=""static"" data-bs-keyboard=""false"">
        <div class=""modal-dialog modal-dialog-centered modal-xl"">
            <div class=""modal-content"">
                <div class=""modal-header"">
   ");
            WriteLiteral(@"                 <h5 class=""modal-title"" id=""enrollmentModalLabel"">Enrollment Info</h5>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                </div>
                <div class=""modal-body"">

                    <div class=""row justify-content-between enrollment-info"">

                        <div class=""col-md-4"">
                            <label class=""form-label"">Student Name</label>
                            <div class=""input-group input-group-sm"">
                                <input type=""text"" class=""form-control"" id=""studentName"" aria-label=""Student Name"" aria-describedby=""input-student-name"">
                            </div>

                            <input type=""hidden"" id=""studentId"" />
                            <label class=""form-label"">Student No.</label>
                            <div class=""input-group input-group-sm"">
                                <input type=""text"" class=""form-control"" ");
            WriteLiteral(@"id=""studentNo"" aria-label=""Student Number"" aria-describedby=""input-student-number"">
                            </div>

                            <label class=""form-label"">Program</label>
                            <div class=""input-group input-group-sm"">
                                <input type=""text"" class=""form-control"" id=""program"" aria-label=""Program"" aria-describedby=""input-program"">
                            </div>

                            <label class=""form-label"">Major</label>
                            <div class=""input-group input-group-sm"">
                                <input type=""text"" class=""form-control"" id=""major"" aria-label=""Major"" aria-describedby=""input-major"">
                            </div>

                            <label class=""form-label"">Year Level</label>
                            <div class=""input-group input-group-sm"">
                                <input type=""text"" class=""form-control"" id=""yearLevel"" aria-label=""Year Level"" aria-described");
            WriteLiteral(@"by=""input-year-level"">
                            </div>
                        </div>
                        <!--Table to display Enrollment History-->
                        <div class=""col-md-8"">
                            <table id=""enrollmentHistoryTableList"" class=""dataTable data-table-width compact hover row-border stripe"">
                            </table>
                        </div>
                    </div>

                    

                    <div class=""row justify-content-center mt-5"">                      
                        <div class=""col-md-12 mt-1 enrolledCourseList"">
                            <table id=""enrollmentCourseList"" class=""dataTable data-table-width compact hover row-border stripe"">
                            </table>
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close<");
            WriteLiteral(@"/button>
                </div>
            </div>
        </div>
    </div>


    <div class=""card d-none mt-2"">
        <div class=""card-header bg-black""></div>
        <div class=""card-body toprint"">
            <div class=""container"">
                <div class=""row justify-content-between"">
                    <div class=""col-8 col-sm-8 col-md-8"">
                          <div class=""row justify-content-center"">
                            <div class=""col-2 col-sm-2 col-md-2 col-lg-2 text-center my-auto"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "34e8e3f8c37f01e3d1904d2c5793eff6639fecb718404", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""col-6 col-sm-6 col-md-6 col-lg-6 my-auto"">
                                <h3 class=""text-uppercase mt-3"" style=""font-size: 1.5rem; font-family:'Times New Roman'; line-height:50%;"">MANDAUE CITY COLLEGE</h3>
                                <h5 class=""text-uppercase mt-3"" style=""font-size: 0.8rem; font-family:'Times New Roman'; line-height:50%;"">Mandaue City Cultural and Sports Complex</h5>
                                <h4 class=""text-uppercase mt-3"" style=""font-size: 0.8rem; font-family:'Times New Roman'; line-height:50%;"">Don Andres Soriano Ave., Centro, Mandaue City</h4>
                                <h3 class=""text-uppercase mt-3"" style=""font-size: 0.8rem; font-family:'Times New Roman'; line-height:50%;"">Telephone No.: (032)420-9228</h3>
                            </div>
                          </div>
                    </div>
                   

                <div class=""col-4 col-sm-4 col-md-4"">
         ");
            WriteLiteral(@"           <div class=""row"">
                        <div class=""col-12 col-xl-12"">
                            <label class=""d-inline"">Date: </label> <span class=""enrollmentDate""></span>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-12 col-xl-12"">
                            <label class=""d-inline"">SY Sem: </label> <span class=""schoolYear""></span>
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-12 col-xl-12"">
                            <label class=""d-inline"">Sem: </label> <span class=""semester""></span>
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-12 col-xl-12"">
                            <label class=""d-inline"">Enrollment No: </label> <span class=""enrollmentNo""></span>
                        </div>
                   ");
            WriteLiteral(@" </div>

                </div>

            </div>


                <div class=""row justify-content-between mt-5"">
                </div>

                <div class=""row"">
                    <div class=""col-12 col-xl-12 text-center"">
                        <label class=""fw-bold"">Study Load </label>
                    </div>
                    <div class=""col-6 col-xl-6"">
                        <label class=""d-inline"">Course: </label> <span class=""course""></span>
                    </div>
                    <div class=""col-6 col-xl-6"">
                        <label class=""d-inline"">Major: </label> <span class=""major""></span>
                    </div>
                    <div class=""col-6 col-xl-6"">
                        <label class=""d-inline"">Name: </label> <span class=""studentName""></span>
                    </div>
                    <div class=""col-6 col-xl-6"">
                        <label class=""d-inline"">Year: </label> <span class=""year""></span>
                 ");
            WriteLiteral(@"   </div>
                </div>

                <div class=""row"">
                    <table class=""table text-center"">
                        <thead>
                            <tr>
                                <th scope=""col"">EDP Code</th>
                                <th scope=""col"">Subject</th>
                                <th scope=""col"">Room</th>
                                <th scope=""col"">Day</th>
                                <th scope=""col"">Time Start</th>
                                <th scope=""col"">Time End</th>
                                <th scope=""col"">Units</th>
                                <th scope=""col"">Instructor Sign</th>
                            </tr>
                        </thead>
                        <tbody class=""courseData"">
                            
                        </tbody>
                        
                    </table>
                    <div class=""col-11 col-md-11 text-right""><label>Total Units: </label>");
            WriteLiteral(@"<span class=""ml-2"" id=""totalUnits""></span></div>
                </div>
                <div class=""row justify-content-center"">
                    <div class=""col-6"">
                    </div>
                </div>

            </div>
        </div>
        <div class=""col-12""><button type=""button"" class=""btn btn-success no-print"" id=""printButton"">Print</button></div>
    </div>
  
</div>

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591