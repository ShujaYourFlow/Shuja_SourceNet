#pragma checksum "F:\YourFlow project\SourceNet\SourceNet\Areas\Website\Views\UseCases\ArtisanLoafVerification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "893322ea7bfaddeb75d23f786491d9d1b2b1ddbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Website_Views_UseCases_ArtisanLoafVerification), @"mvc.1.0.view", @"/Areas/Website/Views/UseCases/ArtisanLoafVerification.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"893322ea7bfaddeb75d23f786491d9d1b2b1ddbe", @"/Areas/Website/Views/UseCases/ArtisanLoafVerification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fa62c2c75ae027b87c7c093fc4ae3924b361205", @"/Areas/Website/Views/_ViewImports.cshtml")]
    public class Areas_Website_Views_UseCases_ArtisanLoafVerification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""sectionWrapper bg_lightGray"">
    <div class=""container"">
        <div class=""progress-verification-sec"">
            <h4>Document Verification</h4>
            <div class=""progressWrapper"">
                <ul class=""stepProgress"">
                    <li class=""stepProgress-item is-done"">
                        <h5>Step 1</h5>
                        <p>Retrieving document from client’s server.</p>
                    </li>
                    <li class=""stepProgress-item is-done"">
                        <h5>Step 2</h5>
                        <p>Retrieving unique hash value from document.</p>
                    </li>
                    <li class=""stepProgress-item is-done"">
                        <h5>Step 3</h5>
                        <p>Retrieving unique hash value from VeriDoc Global’s server.</p>
                    </li>
                    <li class=""stepProgress-item is-done"">
                        <h5>Step 4</h5>
                        <p>Retrieving uni");
            WriteLiteral(@"que hash value from blockchain.</p>
                    </li>
                    <li class=""stepProgress-item is-done"">
                        <h5>Step 5</h5>
                        <p>
                            Unique hash values match. Please compare the document you have scanned to the original
                            document prepared by the issuer on the next screen
                        </p>
                    </li>
                </ul>
                <div class=""text-center"">
                    <button class=""btn btn-primary custom-btn click-poc"" type=""submit"">Continue</button>
                </div>
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
