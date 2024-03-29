#pragma checksum "H:\Hardware QC\WebAppEs\WebAppEs\Views\AddFaultsInfo\FullPreview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e6ee392bdb84f6a618182badd9bcec6ea66e3b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AddFaultsInfo_FullPreview), @"mvc.1.0.view", @"/Views/AddFaultsInfo/FullPreview.cshtml")]
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
#line 1 "H:\Hardware QC\WebAppEs\WebAppEs\Views\_ViewImports.cshtml"
using WebAppEs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Hardware QC\WebAppEs\WebAppEs\Views\_ViewImports.cshtml"
using WebAppEs.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e6ee392bdb84f6a618182badd9bcec6ea66e3b5", @"/Views/AddFaultsInfo/FullPreview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df22ec340b1f909b83f6693521f173f392f6d3ac", @"/Views/_ViewImports.cshtml")]
    public class Views_AddFaultsInfo_FullPreview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppEs.ViewModel.FaultsEntry.MobileRNDFaultsEntryViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "H:\Hardware QC\WebAppEs\WebAppEs\Views\AddFaultsInfo\FullPreview.cshtml"
   ViewData["Title"] = "Preview"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h4>Faults Preview</h4>
<div>
    <div class=""card-body"">
        <div class=""row"">
            <div style="" padding: 8px;"" class=""col-md-5"">
                <div style=""padding: 8px;"" class=""shadow-lg bg-white rounded"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <h5 class=""card-title text-uppercase text-muted mb-0"">Date</h5>
                        </div>
                        <div class=""col-md-6"">
                            <span style="" color: black;"" class=""h6 font-weight-bold mb-0"">");
#nullable restore
#line 14 "H:\Hardware QC\WebAppEs\WebAppEs\Views\AddFaultsInfo\FullPreview.cshtml"
                                                                                     Write(Model.DateString);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </div>
                    </div>
                    <hr class=""solid"" />
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <h5 class=""card-title text-uppercase text-muted mb-0"">Line</h5>
                        </div>
                        <div class=""col-md-6"">
                            <span style="" color: black;"" class=""h6 font-weight-bold mb-0"">");
#nullable restore
#line 23 "H:\Hardware QC\WebAppEs\WebAppEs\Views\AddFaultsInfo\FullPreview.cshtml"
                                                                                     Write(Model.Line);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </div>
                    </div>
                    <hr class=""solid"" />
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <h5 class=""card-title text-uppercase text-muted mb-0"">Model</h5>
                        </div>
                        <div class=""col-md-6"">
                            <span style="" color: black;"" class=""h6 font-weight-bold mb-0"">");
#nullable restore
#line 32 "H:\Hardware QC\WebAppEs\WebAppEs\Views\AddFaultsInfo\FullPreview.cshtml"
                                                                                     Write(Model.ModelName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </div>
                    </div>
                    <hr class=""solid"" />
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <h5 class=""card-title text-uppercase text-muted mb-0"">Order</h5>
                        </div>
                        <div class=""col-md-6"">
                            <span style="" color: black;"" class=""h6 font-weight-bold mb-0"">");
#nullable restore
#line 41 "H:\Hardware QC\WebAppEs\WebAppEs\Views\AddFaultsInfo\FullPreview.cshtml"
                                                                                     Write(Model.LotNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </div>
                    </div>
                </div>
            </div>
            <div style="" padding: 8px;"" class=""col-md-2 "">
                <div style=""padding: 8px;height:100%; text-align:center"" class=""shadow-lg bg-white rounded"">
                    <h5 class=""card-title text-uppercase text-muted mb-0"">Total Production</h5>
                    <br />
                    <span style=""padding-top:13px; color:darkblue"" class=""h4 font-weight-bold mb-0"">");
#nullable restore
#line 50 "H:\Hardware QC\WebAppEs\WebAppEs\Views\AddFaultsInfo\FullPreview.cshtml"
                                                                                               Write(Model.TotalCheckedQty);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </div>
            </div>
            <div style="" padding: 8px;"" class=""col-md-5 "">
                <div style=""padding: 8px;"" class=""shadow-lg bg-white rounded"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <h5 class=""card-title text-uppercase text-muted mb-0"">Shipment</h5>
                        </div>
                        <div class=""col-md-6"">
                            <span style="" color: black;"" class=""h6 font-weight-bold mb-0"">");
#nullable restore
#line 60 "H:\Hardware QC\WebAppEs\WebAppEs\Views\AddFaultsInfo\FullPreview.cshtml"
                                                                                     Write(Model.Shipment);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </div>
                    </div>
                    <hr class=""solid"" />
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <h5 class=""card-title text-uppercase text-muted mb-0"">Shift</h5>
                        </div>
                        <div class=""col-md-6"">
                            <span style="" color: black;"" class=""h6 font-weight-bold mb-0"">");
#nullable restore
#line 69 "H:\Hardware QC\WebAppEs\WebAppEs\Views\AddFaultsInfo\FullPreview.cshtml"
                                                                                     Write(Model.Shift);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </div>
                    </div>
                    <hr class=""solid"" />
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <h5 class=""card-title text-uppercase text-muted mb-0"">Type of Prod.</h5>
                        </div>
                        <div class=""col-md-6"">
                            <span style="" color: black;"" class=""h6 font-weight-bold mb-0"">");
#nullable restore
#line 78 "H:\Hardware QC\WebAppEs\WebAppEs\Views\AddFaultsInfo\FullPreview.cshtml"
                                                                                     Write(Model.TypeOfProduction);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </div>
                    </div>
                    <hr class=""solid"" />
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <h5 class=""card-title text-uppercase text-muted mb-0"">QC PASS</h5>
                        </div>
                        <div class=""col-md-6"">
                            <span style="" color: black;"" class=""h6 font-weight-bold mb-0"">");
#nullable restore
#line 87 "H:\Hardware QC\WebAppEs\WebAppEs\Views\AddFaultsInfo\FullPreview.cshtml"
                                                                                     Write(Model.QCPass);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div  class=""bg-white shadow-lg rounded"" style=""padding: 10px; width: 60%; margin: auto;"">
        <h5>Category And Sub Category wise Data Preview</h5>
        <table>
");
#nullable restore
#line 105 "H:\Hardware QC\WebAppEs\WebAppEs\Views\AddFaultsInfo\FullPreview.cshtml"
         foreach (var plan in Model.MobileRNDFaultDetailsViewModel.GroupBy(p => new { p.CategoryName }))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"cat\">\n            <th");
            BeginWriteAttribute("style", " style=\"", 5260, "\"", 5268, 0);
            EndWriteAttribute();
            WriteLiteral(" colspan=\"2\">");
#nullable restore
#line 108 "H:\Hardware QC\WebAppEs\WebAppEs\Views\AddFaultsInfo\FullPreview.cshtml"
                                Write(plan.Key.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n\n        </tr>\n");
#nullable restore
#line 111 "H:\Hardware QC\WebAppEs\WebAppEs\Views\AddFaultsInfo\FullPreview.cshtml"
         foreach (var plan1 in plan.GroupBy(p => new { p.FaultType }))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"grp\">\n            <th");
            BeginWriteAttribute("style", " style=\"", 5446, "\"", 5454, 0);
            EndWriteAttribute();
            WriteLiteral(" colspan=\"2\">");
#nullable restore
#line 114 "H:\Hardware QC\WebAppEs\WebAppEs\Views\AddFaultsInfo\FullPreview.cshtml"
                                Write(plan1.Key.FaultType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n        </tr>\n        <tbody>\n");
#nullable restore
#line 117 "H:\Hardware QC\WebAppEs\WebAppEs\Views\AddFaultsInfo\FullPreview.cshtml"
             foreach (var plan2 in plan1)
                { 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                \n                <td>");
#nullable restore
#line 121 "H:\Hardware QC\WebAppEs\WebAppEs\Views\AddFaultsInfo\FullPreview.cshtml"
               Write(plan2.SubCategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 122 "H:\Hardware QC\WebAppEs\WebAppEs\Views\AddFaultsInfo\FullPreview.cshtml"
               Write(plan2.FaultQty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 124 "H:\Hardware QC\WebAppEs\WebAppEs\Views\AddFaultsInfo\FullPreview.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \n        </tbody>\n");
#nullable restore
#line 127 "H:\Hardware QC\WebAppEs\WebAppEs\Views\AddFaultsInfo\FullPreview.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "H:\Hardware QC\WebAppEs\WebAppEs\Views\AddFaultsInfo\FullPreview.cshtml"
     
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
    </div>
</div>
<br /><br /><br /><br />



    

    <style>
        table {
            text-align: left;
            border-collapse: collapse;
            width: 100%;
            color:black;
        }

        td, th {
            border: 1px solid grey;
            padding: 0.3em;
        }

        tr.cat th {
            background: #A3DABE
        }

        tr.grp th {
            background: #B9D9E3;
            padding-left: 1em;
        }

        thead th {
            font-weight: normal;
        }

        tbody td {
            padding-left: 2em;
        }
        hr {
             margin-top: 0.25rem; 
             margin-bottom: 0.25rem; 
             border: 0; 
            border-top: 1px solid rgba(0,0,0,.1);
        }
        table {
            width: 100%;
            border-collapse: collapse;
        }
    </style>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppEs.ViewModel.FaultsEntry.MobileRNDFaultsEntryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
