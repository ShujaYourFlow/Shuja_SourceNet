#pragma checksum "F:\YourFlow project\SourceNet\SourceNet\Areas\Website\Views\UseCases\MonthlyTimeSheetVerification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d1cb167302e1ad3be6f151df7938bf81f6c6a55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Website_Views_UseCases_MonthlyTimeSheetVerification), @"mvc.1.0.view", @"/Areas/Website/Views/UseCases/MonthlyTimeSheetVerification.cshtml")]
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
#line 1 "F:\YourFlow project\SourceNet\SourceNet\Areas\Website\Views\_ViewImports.cshtml"
using SourceNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\YourFlow project\SourceNet\SourceNet\Areas\Website\Views\_ViewImports.cshtml"
using MyApp.Entity.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d1cb167302e1ad3be6f151df7938bf81f6c6a55", @"/Areas/Website/Views/UseCases/MonthlyTimeSheetVerification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fa62c2c75ae027b87c7c093fc4ae3924b361205", @"/Areas/Website/Views/_ViewImports.cshtml")]
    public class Areas_Website_Views_UseCases_MonthlyTimeSheetVerification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""sectionWrapper bg_lightGray verification-sec"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5"">
                <div class=""verify-title"">
                    <p class=""mb-0"">Please compare the document you have scanned to the<b> original document </b>prepared by the issuer below. You may download the original document for your copy, and verify document through blockchain.</p>
                </div>
                <div class=""text-center mt-4 mb-4"">
                    <button class=""btn btn-primary custom-btn verify-btn"" type=""submit""><i class=""far fa-link fa-rotate-90""></i> Verify on ethereum blockchain</button>
                </div>
                <div class=""tableWrapper"">
                    <h5>Document Details</h5>
                    <div class=""table-responsive"">
                        <table class=""table table-borderless table-striped"">
                            <tbody>
                                <tr>
                                ");
            WriteLiteral(@"    <td width=""160px"">Employee ID</td>
                                    <td>EMP423412</td>
                                </tr>
                                <tr>
                                    <td>First Name</td>
                                    <td>John</td>
                                </tr>
                                <tr>
                                    <td>Last Name</td>
                                    <td>Smith</td>
                                </tr>
                                <tr>
                                    <td>Position</td>
                                    <td>Test Analyst</td>
                                </tr>
                                <tr>
                                    <td>Date of Joining</td>
                                    <td>09/09/2019</td>
                                </tr>
                                <tr>
                                    <td>Company</td>
                                    <td>Verified Company</td>");
            WriteLiteral(@"
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <div class=""col-md-7"">
                <div class=""verify-iframe"">
                    <iframe src=""https://drive.google.com/file/d/1myNoFRxAvN0ADGD_pAD38FSH8LGiu5Qh/preview"" type=""application/pdf"" width=""100%"" height=""510px""></iframe>
                </div>
                <div class=""text-left mt-3 mb-3"">
                    <button class=""btn btn-primary custom-btn verify-btn"" type=""submit""><i class=""fas fa-arrow-alt-down""></i> Download</button>
                </div>
            </div>
        </div>
        <br>
        <div class=""tableWrapper"">
            <h5>Events</h5>
            <div class=""table-responsive p-0 bg-transparent"">
                <table class=""table table-bordered table-striped mb-0"">
                    <thead>
                        <tr>
                            <th>Timesheet period</th>
   ");
            WriteLiteral(@"                         <th>Timesheet PDF Hash</th>
                            <th>Pdf</th>
                            <th>Verify</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>30/09/2019 - 06/10/2019</td>
                            <td>556be579bc3af6019af1b716b5f27caceb9592b62e1cc9e23f001ac877cd4b48</td>
                            <td><button class=""btn btn-primary custom-btn verify-btn"" type=""submit""><i class=""fas fa-arrow-alt-down""></i> Download</button></td>
                            <td><button class=""btn btn-primary custom-btn verify-btn"" type=""submit""><i class=""far fa-link fa-rotate-90""></i> Verify</button></td>
                        </tr>
                        <tr>
                            <td>30/09/2019 - 06/10/2019</td>
                            <td>556be579bc3af6019af1b716b5f27caceb9592b62e1cc9e23f001ac877cd4b48</td>
                            <td><button class=""btn btn-primary");
            WriteLiteral(@" custom-btn verify-btn"" type=""submit""><i class=""fas fa-arrow-alt-down""></i> Download</button></td>
                            <td><button class=""btn btn-primary custom-btn verify-btn"" type=""submit""><i class=""far fa-link fa-rotate-90""></i> Verify</button></td>
                        </tr>
                        <tr>
                            <td>30/09/2019 - 06/10/2019</td>
                            <td>556be579bc3af6019af1b716b5f27caceb9592b62e1cc9e23f001ac877cd4b48</td>
                            <td><button class=""btn btn-primary custom-btn verify-btn"" type=""submit""><i class=""fas fa-arrow-alt-down""></i> Download</button></td>
                            <td><button class=""btn btn-primary custom-btn verify-btn"" type=""submit""><i class=""far fa-link fa-rotate-90""></i> Verify</button></td>
                        </tr>
                        <tr>
                            <td>30/09/2019 - 06/10/2019</td>
                            <td>556be579bc3af6019af1b716b5f27caceb9592b62e1cc9e23f001ac877cd4b48</");
            WriteLiteral(@"td>
                            <td><button class=""btn btn-primary custom-btn verify-btn"" type=""submit""><i class=""fas fa-arrow-alt-down""></i> Download</button></td>
                            <td><button class=""btn btn-primary custom-btn verify-btn"" type=""submit""><i class=""far fa-link fa-rotate-90""></i> Verify</button></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</section>
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
