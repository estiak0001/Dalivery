#pragma checksum "H:\Hardware QC\WebAppEs\WebAppEs\Views\Shared\Components\NavigationMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29ea7560f32c6fec4e824c562a4dd30ad2cccf09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_NavigationMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/NavigationMenu/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29ea7560f32c6fec4e824c562a4dd30ad2cccf09", @"/Views/Shared/Components/NavigationMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df22ec340b1f909b83f6693521f173f392f6d3ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_NavigationMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebAppEs.Models.NavigationMenuViewModel>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "H:\Hardware QC\WebAppEs\WebAppEs\Views\Shared\Components\NavigationMenu\Default.cshtml"
  
    ViewData["Title"] = "NavigationMenu";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"menu_section\">\r\n    <ul class=\"nav side-menu\">\r\n");
#nullable restore
#line 8 "H:\Hardware QC\WebAppEs\WebAppEs\Views\Shared\Components\NavigationMenu\Default.cshtml"
         foreach (var item in Model)
        {
            if (item.ParentMenuId == null) //Level one items will have null parent id
            {
                if (!string.IsNullOrWhiteSpace(item.ControllerName))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29ea7560f32c6fec4e824c562a4dd30ad2cccf093954", async() => {
                WriteLiteral("<i class=\"fa fa-angle-double-right\"></i> ");
#nullable restore
#line 15 "H:\Hardware QC\WebAppEs\WebAppEs\Views\Shared\Components\NavigationMenu\Default.cshtml"
                                                                                                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" dfghdf");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "H:\Hardware QC\WebAppEs\WebAppEs\Views\Shared\Components\NavigationMenu\Default.cshtml"
                         WriteLiteral(item.Area);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-area", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "H:\Hardware QC\WebAppEs\WebAppEs\Views\Shared\Components\NavigationMenu\Default.cshtml"
                                                     WriteLiteral(item.ControllerName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "H:\Hardware QC\WebAppEs\WebAppEs\Views\Shared\Components\NavigationMenu\Default.cshtml"
                                                                                       WriteLiteral(item.ActionName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 17 "H:\Hardware QC\WebAppEs\WebAppEs\Views\Shared\Components\NavigationMenu\Default.cshtml"
                }
                if (item.IsExternal && !string.IsNullOrWhiteSpace(item.ExternalUrl))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        <a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 832, "\"", 856, 1);
#nullable restore
#line 21 "H:\Hardware QC\WebAppEs\WebAppEs\Views\Shared\Components\NavigationMenu\Default.cshtml"
WriteAttributeValue("", 839, item.ExternalUrl, 839, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-circle\"></i> ");
#nullable restore
#line 21 "H:\Hardware QC\WebAppEs\WebAppEs\Views\Shared\Components\NavigationMenu\Default.cshtml"
                                                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </li>\r\n");
#nullable restore
#line 23 "H:\Hardware QC\WebAppEs\WebAppEs\Views\Shared\Components\NavigationMenu\Default.cshtml"
                }
                var children = Model.Where(x => x.ParentMenuId == item.Id && x.Visible).OrderBy(x => x.DisplayOrder).ToList();
                if (children != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n\r\n                        <a><i class=\"fa fa-angle-double-right\"></i> ");
#nullable restore
#line 29 "H:\Hardware QC\WebAppEs\WebAppEs\Views\Shared\Components\NavigationMenu\Default.cshtml"
                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"fa fa-chevron-down\"></span></a>\r\n                        <ul class=\"nav child_menu\">\r\n");
#nullable restore
#line 31 "H:\Hardware QC\WebAppEs\WebAppEs\Views\Shared\Components\NavigationMenu\Default.cshtml"
                             foreach (var itm in children)
                            {
                                if (itm.IsExternal && !string.IsNullOrWhiteSpace(itm.ExternalUrl))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1609, "\"", 1632, 1);
#nullable restore
#line 35 "H:\Hardware QC\WebAppEs\WebAppEs\Views\Shared\Components\NavigationMenu\Default.cshtml"
WriteAttributeValue("", 1616, itm.ExternalUrl, 1616, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 35 "H:\Hardware QC\WebAppEs\WebAppEs\Views\Shared\Components\NavigationMenu\Default.cshtml"
                                                              Write(itm.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 36 "H:\Hardware QC\WebAppEs\WebAppEs\Views\Shared\Components\NavigationMenu\Default.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29ea7560f32c6fec4e824c562a4dd30ad2cccf0910992", async() => {
#nullable restore
#line 39 "H:\Hardware QC\WebAppEs\WebAppEs\Views\Shared\Components\NavigationMenu\Default.cshtml"
                                                                                                                              Write(itm.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "H:\Hardware QC\WebAppEs\WebAppEs\Views\Shared\Components\NavigationMenu\Default.cshtml"
                                         WriteLiteral(item.Area);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-area", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "H:\Hardware QC\WebAppEs\WebAppEs\Views\Shared\Components\NavigationMenu\Default.cshtml"
                                                                     WriteLiteral(itm.ControllerName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "H:\Hardware QC\WebAppEs\WebAppEs\Views\Shared\Components\NavigationMenu\Default.cshtml"
                                                                                                      WriteLiteral(itm.ActionName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 40 "H:\Hardware QC\WebAppEs\WebAppEs\Views\Shared\Components\NavigationMenu\Default.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </li>\r\n");
#nullable restore
#line 44 "H:\Hardware QC\WebAppEs\WebAppEs\Views\Shared\Components\NavigationMenu\Default.cshtml"
                }
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebAppEs.Models.NavigationMenuViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
