#pragma checksum "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\AspNetCoremMvcDepartman\AspNetCoremMvcDepartman\Views\Depart\DepartmanGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "752e8b487bfb35df36ae37d09b70df305ea6945a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Depart_DepartmanGetir), @"mvc.1.0.view", @"/Views/Depart/DepartmanGetir.cshtml")]
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
#line 1 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\AspNetCoremMvcDepartman\AspNetCoremMvcDepartman\Views\_ViewImports.cshtml"
using AspNetCoremMvcDepartman;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\AspNetCoremMvcDepartman\AspNetCoremMvcDepartman\Views\_ViewImports.cshtml"
using AspNetCoremMvcDepartman.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"752e8b487bfb35df36ae37d09b70df305ea6945a", @"/Views/Depart/DepartmanGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2365a27ae87a43be6b03bf6797a9f42c0d8eb601", @"/Views/_ViewImports.cshtml")]
    public class Views_Depart_DepartmanGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspNetCoremMvcDepartman.Models.Departman>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\AspNetCoremMvcDepartman\AspNetCoremMvcDepartman\Views\Depart\DepartmanGetir.cshtml"
  
    ViewData["Title"] = "DepartmanGetir";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<!--Departmanguncelleyi çalışıtıran beginform-->\r\n");
#nullable restore
#line 11 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\AspNetCoremMvcDepartman\AspNetCoremMvcDepartman\Views\Depart\DepartmanGetir.cshtml"
 using (Html.BeginForm("DepartmanGuncelle", "Depart", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <b>Departman ID</b>\r\n        ");
#nullable restore
#line 15 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\AspNetCoremMvcDepartman\AspNetCoremMvcDepartman\Views\Depart\DepartmanGetir.cshtml"
   Write(Html.TextBoxFor(x => x.ID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        <b>Departman Adı</b>\r\n        ");
#nullable restore
#line 21 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\AspNetCoremMvcDepartman\AspNetCoremMvcDepartman\Views\Depart\DepartmanGetir.cshtml"
   Write(Html.TextBoxFor(x => x.DepartmanAd, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n");
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <button class=\"btn btn-info\" style=\"background-color:lightgreen\">Departmanı Güncelle</button>\r\n");
#nullable restore
#line 28 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\AspNetCoremMvcDepartman\AspNetCoremMvcDepartman\Views\Depart\DepartmanGetir.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetCoremMvcDepartman.Models.Departman> Html { get; private set; }
    }
}
#pragma warning restore 1591