#pragma checksum "F:\YourFlow project\SourceNet\SourceNet\Areas\Website\Views\UseCases\DigitalDriverLicenceVerification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5b99c27debb7488481e4c39bb0de3a185289cf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Website_Views_UseCases_DigitalDriverLicenceVerification), @"mvc.1.0.view", @"/Areas/Website/Views/UseCases/DigitalDriverLicenceVerification.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5b99c27debb7488481e4c39bb0de3a185289cf5", @"/Areas/Website/Views/UseCases/DigitalDriverLicenceVerification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fa62c2c75ae027b87c7c093fc4ae3924b361205", @"/Areas/Website/Views/_ViewImports.cshtml")]
    public class Areas_Website_Views_UseCases_DigitalDriverLicenceVerification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
                    <div class=""table-respon");
            WriteLiteral(@"sive"">
                        <table class=""table table-borderless table-striped"">
                            <tbody>
                                <tr>
                                    <td width=""160px"">Name</td>
                                    <td>Jessica Chloe Campbell</td>
                                </tr>
                                <tr>
                                    <td>Licence Number</td>
                                    <td>2100824623</td>
                                </tr>
                                <tr>
                                    <td>Expiry Date</td>
                                    <td>01 October 2023</td>
                                </tr>
                                <tr>
                                    <td>DOB</td>
                                    <td>08 June 1982</td>
                                </tr>
                                <tr>
                                    <td>Class</td>
                      ");
            WriteLiteral(@"              <td>C</td>
                                </tr>
                                <tr>
                                    <td>Type</td>
                                    <td>A</td>
                                </tr>
                                <tr>
                                    <td>Donor</td>
                                    <td>O</td>
                                </tr>
                                <tr>
                                    <td>Conditions</td>
                                    <td>S</td>
                                </tr>
                                <tr>
                                    <td>Address</td>
                                    <td>3 Ellen Street, Johns Park, NSW 2176</td>
                                </tr>
                                <tr>
                                    <td>Registered</td>
                                    <td>29 September 2018, 2</td>
                                </tr>
         ");
            WriteLiteral(@"                       <tr>
                                    <td>Demerit points</td>
                                    <td>12</td>
                                </tr>
                                <tr>
                                    <td>Suspension Status</td>
                                    <td>Clear</td>
                                </tr>
                                <tr>
                                    <td>Additional Information</td>
                                    <td>0x8fab6aad848e6d0acd7de96b8e1defdeaaa5c75c6db67d2e5c581ba08093605a</td>
                                </tr>
                                <tr>
                                    <td>Hash</td>
                                    <td>d20ebd1aa9f62e7d556515ba6895e443786b5cc6515a79d67a1d95642f988cbd</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
           ");
            WriteLiteral(@" <div class=""col-md-7"">
                <div class=""verify-iframe"">
                    <iframe src=""https://drive.google.com/file/d/1VV11mm4Bd2_MXaNTSTdfpkkEiu49CnJ9/preview""
                            type=""application/pdf"" width=""100%"" height=""700px""></iframe>
                </div>
                <div class=""text-left mt-3 mb-3"">
                    <button class=""btn btn-primary custom-btn verify-btn"" type=""submit"">
                        <i class=""fas fa-arrow-alt-down""></i> Download
                    </button>
                </div>
            </div>
        </div>
    </div>
</section>");
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
