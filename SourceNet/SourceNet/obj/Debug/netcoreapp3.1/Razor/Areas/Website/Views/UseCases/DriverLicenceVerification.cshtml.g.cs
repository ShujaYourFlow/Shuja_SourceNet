#pragma checksum "F:\YourFlow project\SourceNet\SourceNet\Areas\Website\Views\UseCases\DriverLicenceVerification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfdbac86e6eedf6949e40b48af7341e4ada5f782"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Website_Views_UseCases_DriverLicenceVerification), @"mvc.1.0.view", @"/Areas/Website/Views/UseCases/DriverLicenceVerification.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfdbac86e6eedf6949e40b48af7341e4ada5f782", @"/Areas/Website/Views/UseCases/DriverLicenceVerification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fa62c2c75ae027b87c7c093fc4ae3924b361205", @"/Areas/Website/Views/_ViewImports.cshtml")]
    public class Areas_Website_Views_UseCases_DriverLicenceVerification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<section class=""sectionWrapper bg_lightGray verification-sec"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5"">
                <div class=""verify-title"">
                    <p class=""mb-0"">
                        Please compare the document you have scanned to the<b>
                            original document
                        </b>prepared by the issuer below. You may download the original document for your copy, and
                        verify document through blockchain.
                    </p>
                </div>
                <div class=""text-center mt-4 mb-4"">
                    <button class=""btn btn-primary custom-btn verify-btn"" type=""submit"">
                        <i class=""far fa-link fa-rotate-90""></i> Verify on ethereum blockchain
                    </button>
                </div>
                <div class=""tableWrapper"">
                    <h5>Document Details</h5>
                    <div class=""table-resp");
            WriteLiteral(@"onsive"">
                        <table class=""table table-borderless table-striped"">
                            <tbody>
                                <tr>
                                    <td width=""160px"">License No</td>
                                    <td>112488956</td>
                                </tr>
                                <tr>
                                    <td>Name</td>
                                    <td>Jessica Yi-Ling Chen</td>
                                </tr>
                                <tr>
                                    <td>Address</td>
                                    <td>123 East Street, Brisbane, Queensland 4000</td>
                                </tr>
                                <tr>
                                    <td>Date of Birth</td>
                                    <td>16 June 1993</td>
                                </tr>
                                <tr>
                                    <td>Gender");
            WriteLiteral(@"</td>
                                    <td>Female</td>
                                </tr>
                                <tr>
                                    <td>Class</td>
                                    <td>C</td>
                                </tr>
                                <tr>
                                    <td>Type</td>
                                    <td>O</td>
                                </tr>
                                <tr>
                                    <td>Donor</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Conditions</td>
                                    <td>S</td>
                                </tr>
                                <tr>
                                    <td>Issue Date</td>
                                    <td>04 September 2016</td>
                                </tr>
               ");
            WriteLiteral(@"                 <tr>
                                    <td>Current Expiry Date</td>
                                    <td>04 September 2021</td>
                                </tr>
                                <tr>
                                    <td>Emergency Contact</td>
                                    <td>Jane Anderson ??? 0401 112 448</td>
                                </tr>
                                <tr>
                                    <td>CCP Insurance Status</td>
                                    <td>Current ??? RACQQ</td>
                                </tr>
                                <tr>
                                    <td>Policy No</td>
                                    <td>123244</td>
                                </tr>
                                <tr>
                                    <td>Additional Information</td>
                                    <td>0x8fab6aad848e6d0acd7de96b8e1defdeaaa5c75c6db67d2e5c581ba08093605a</td>
    ");
            WriteLiteral(@"                            </tr>
                                <tr>
                                    <td>Hash</td>
                                    <td>d20ebd1aa9f62e7d556515ba6895e443786b5cc6515a79d67a1d95642f988cbd</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <div class=""col-md-7"">
                <div class=""verify-iframe"">
                    <iframe src=""https://drive.google.com/file/d/1fGMLDNsIgwJVCmNZk8MT8X5K9gv4AVPw/preview""
                            type=""application/pdf"" width=""100%"" height=""700px""></iframe>
                </div>
                <div class=""text-left mt-3 mb-3"">
                    <button class=""btn btn-primary custom-btn verify-btn"" type=""submit"">
                        <i class=""fas fa-arrow-alt-down""></i> Download
                    </button>
                </div>
            </div>
        </div>");
            WriteLiteral("\r\n    </div>\r\n</section>\r\n");
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
