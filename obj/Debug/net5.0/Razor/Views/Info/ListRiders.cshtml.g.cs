#pragma checksum "C:\Users\david\source\repos\www\MotoGP\MotoGP\Views\Info\ListRiders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e32b2332671689b128035f8f00316ac1c514b9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Info_ListRiders), @"mvc.1.0.view", @"/Views/Info/ListRiders.cshtml")]
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
#line 1 "C:\Users\david\source\repos\www\MotoGP\MotoGP\Views\_ViewImports.cshtml"
using MotoGP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\david\source\repos\www\MotoGP\MotoGP\Views\_ViewImports.cshtml"
using MotoGP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e32b2332671689b128035f8f00316ac1c514b9e", @"/Views/Info/ListRiders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28c11a21fd0de2028889f3b1a931d0560cbec79e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Info_ListRiders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Rider>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<<<<<<< HEAD

<style>
    .card-list{
        display: grid;
        grid-template-columns: repeat(3, minmax(100px, 293px));
        justify-content: center;
        gap: 28px;
    }
    .card{
        padding:5%;
        background-color:darkgray;
        cursor: pointer;
        position: relative;
        display: block;
    }
    .card-img{
        width: 90%;
        margin-inline: 5%;
        vertical-align: top;
    }
    .card-title{
        padding-right:5%;
        padding-left:5%;
        display: grid;
        grid-template-columns: repeat(2, 1fr);
        gap: 70%;
        justify-content: center;
        align-items:center;
    }
    .card-title div{
        margin:0;
        text-align:right;
    }
    .card-body{
        padding-right:5%;
        padding-left:5%;
        font-size:1rem;
        color:gainsboro;
    }
</style>

<div class=""card-list"" >
");
#nullable restore
#line 48 "C:\Users\david\source\repos\www\MotoGP\MotoGP\Views\Info\ListRiders.cshtml"
     foreach (var item in Model)
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <div class=\"card\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2e32b2332671689b128035f8f00316ac1c514b9e5404", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1172, "~/images/riders/", 1172, 16, true);
#nullable restore
#line 51 "C:\Users\david\source\repos\www\MotoGP\MotoGP\Views\Info\ListRiders.cshtml"
AddHtmlAttributeValue("", 1188, item.Number, 1188, 14, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1202, ".jpg", 1202, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <br>\r\n            <div class=\"card-title\">\r\n                <div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2e32b2332671689b128035f8f00316ac1c514b9e7146", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1321, "~/images/flags/", 1321, 15, true);
#nullable restore
#line 55 "C:\Users\david\source\repos\www\MotoGP\MotoGP\Views\Info\ListRiders.cshtml"
AddHtmlAttributeValue("", 1336, @item.CountryID, 1336, 18, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1354, ".png", 1354, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    <h2>\r\n                        ");
#nullable restore
#line 59 "C:\Users\david\source\repos\www\MotoGP\MotoGP\Views\Info\ListRiders.cshtml"
                    Write(Html.DisplayFor(modelItem => @item.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h2>\r\n                </div>\r\n            </div>\r\n            <p class=\"card-body\">\r\n                ");
#nullable restore
#line 64 "C:\Users\david\source\repos\www\MotoGP\MotoGP\Views\Info\ListRiders.cshtml"
            Write(Html.DisplayFor(modelItem => @item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                ");
#nullable restore
#line 65 "C:\Users\david\source\repos\www\MotoGP\MotoGP\Views\Info\ListRiders.cshtml"
            Write(Html.DisplayFor(modelItem => @item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n       </div>\r\n");
#nullable restore
#line 73 "C:\Users\david\source\repos\www\MotoGP\MotoGP\Views\Info\ListRiders.cshtml"
              
   }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
=======
<p>
    Please fill out following fields:
</p>
>>>>>>> b77b88c6eaa70a34f4981440aeb98d1613b7d0bb

<style>
    .card-list{
        display: grid;
        grid-template-columns: repeat(3, minmax(100px, 293px));
        justify-content: center;
        gap: 28px;
    }
    .card{
        padding:5%;
        background-color:darkgray;
        cursor: pointer;
        position: relative;
        display: block;
    }
    .card-img{
        width: 90%;
        margin-inline: 5%;
        vertical-align: top;
    }
    .card-title{
        padding-right:5%;
        padding-left:5%;
        display: grid;
        grid-template-columns: repeat(2, 1fr);
        gap: 70%;
        justify-content: center;
        align-items:center;
    }
    .card-title div{
        margin:0;
        text-align:right;
    }
    .card-body{
        padding-right:5%;
        padding-left:5%;
        font-size:1rem;
        color:gainsboro;
    }
</style>

<div class=""card-list"" >");
            WriteLiteral("\r\n");
#nullable restore
#line 123 "C:\Users\david\source\repos\www\MotoGP\MotoGP\Views\Info\ListRiders.cshtml"
     foreach (var item in Model)
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <div class=\"card\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2e32b2332671689b128035f8f00316ac1c514b9e11310", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3096, "~/images/riders/", 3096, 16, true);
#nullable restore
#line 126 "C:\Users\david\source\repos\www\MotoGP\MotoGP\Views\Info\ListRiders.cshtml"
AddHtmlAttributeValue("", 3112, item.Number, 3112, 14, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3126, ".jpg", 3126, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <br>\r\n            <div class=\"card-title\">\r\n                <div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2e32b2332671689b128035f8f00316ac1c514b9e13054", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3245, "~/images/flags/", 3245, 15, true);
#nullable restore
#line 130 "C:\Users\david\source\repos\www\MotoGP\MotoGP\Views\Info\ListRiders.cshtml"
AddHtmlAttributeValue("", 3260, @item.CountryID, 3260, 18, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3278, ".png", 3278, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    <h2>\r\n                        ");
#nullable restore
#line 134 "C:\Users\david\source\repos\www\MotoGP\MotoGP\Views\Info\ListRiders.cshtml"
                    Write(Html.DisplayFor(modelItem => @item.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h2>\r\n                </div>\r\n            </div>\r\n            <p class=\"card-body\">\r\n                ");
#nullable restore
#line 139 "C:\Users\david\source\repos\www\MotoGP\MotoGP\Views\Info\ListRiders.cshtml"
            Write(Html.DisplayFor(modelItem => @item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                ");
#nullable restore
#line 140 "C:\Users\david\source\repos\www\MotoGP\MotoGP\Views\Info\ListRiders.cshtml"
            Write(Html.DisplayFor(modelItem => @item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n       </div>\r\n");
#nullable restore
#line 148 "C:\Users\david\source\repos\www\MotoGP\MotoGP\Views\Info\ListRiders.cshtml"
              
   }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e32b2332671689b128035f8f00316ac1c514b9e15905", async() => {
                WriteLiteral("\r\n    Back\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Rider>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
