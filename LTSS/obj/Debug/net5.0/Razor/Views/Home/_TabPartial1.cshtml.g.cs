#pragma checksum "C:\Users\sshen\source\repos\LTSS\LTSS\Views\Home\_TabPartial1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "580d7b62ca216ff386e72942140d3116f70ab81f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__TabPartial1), @"mvc.1.0.view", @"/Views/Home/_TabPartial1.cshtml")]
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
#line 1 "C:\Users\sshen\source\repos\LTSS\LTSS\Views\_ViewImports.cshtml"
using LTSS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sshen\source\repos\LTSS\LTSS\Views\_ViewImports.cshtml"
using LTSS_Model.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sshen\source\repos\LTSS\LTSS\Views\_ViewImports.cshtml"
using LTSS_Model.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"580d7b62ca216ff386e72942140d3116f70ab81f", @"/Views/Home/_TabPartial1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59113931e70cd315e10cd925873465cb29f78611", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__TabPartial1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<LTSS_Model.Models.Option>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>Some Testing Partial View Content 1</p>\r\n<table>\r\n");
#nullable restore
#line 7 "C:\Users\sshen\source\repos\LTSS\LTSS\Views\Home\_TabPartial1.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 11 "C:\Users\sshen\source\repos\LTSS\LTSS\Views\Home\_TabPartial1.cshtml"
       Write(Html.DisplayFor(modelItem => item.OptionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 12 "C:\Users\sshen\source\repos\LTSS\LTSS\Views\Home\_TabPartial1.cshtml"
       Write(Html.DisplayFor(modelItem => item.OptionCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 13 "C:\Users\sshen\source\repos\LTSS\LTSS\Views\Home\_TabPartial1.cshtml"
       Write(Html.EditorFor(modelItem => item.OptionDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 14 "C:\Users\sshen\source\repos\LTSS\LTSS\Views\Home\_TabPartial1.cshtml"
       Write(Html.DisplayFor(modelItem => item.OptionClassId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 15 "C:\Users\sshen\source\repos\LTSS\LTSS\Views\Home\_TabPartial1.cshtml"
       Write(Html.DisplayFor(modelItem => item.SortOrder));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        <td>");
#nullable restore
#line 17 "C:\Users\sshen\source\repos\LTSS\LTSS\Views\Home\_TabPartial1.cshtml"
       Write(Html.EditorFor(modelItem => item.SuggestionMsg));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 18 "C:\Users\sshen\source\repos\LTSS\LTSS\Views\Home\_TabPartial1.cshtml"
       Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 19 "C:\Users\sshen\source\repos\LTSS\LTSS\Views\Home\_TabPartial1.cshtml"
       Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n\r\n    </tr>\r\n");
#nullable restore
#line 24 "C:\Users\sshen\source\repos\LTSS\LTSS\Views\Home\_TabPartial1.cshtml"


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LTSS_Model.Models.Option>> Html { get; private set; }
    }
}
#pragma warning restore 1591