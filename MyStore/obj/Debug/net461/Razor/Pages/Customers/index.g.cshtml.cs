#pragma checksum "C:\Users\Sachintha\source\repos\MyStore\MyStore\Pages\Customers\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56cd6a10449cea5eb4400af9975e5eb979ad89cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyStore.Pages.Customers.Pages_Customers_index), @"mvc.1.0.razor-page", @"/Pages/Customers/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Customers/index.cshtml", typeof(MyStore.Pages.Customers.Pages_Customers_index), null)]
namespace MyStore.Pages.Customers
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Sachintha\source\repos\MyStore\MyStore\Pages\_ViewImports.cshtml"
using MyStore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56cd6a10449cea5eb4400af9975e5eb979ad89cc", @"/Pages/Customers/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1f20bcdfab133b6ecc62fd859baf09c01713465", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Customers_index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Sachintha\source\repos\MyStore\MyStore\Pages\Customers\index.cshtml"
  
    ViewData["Title"] = "Customers";

#line default
#line hidden
            BeginContext(95, 373, true);
            WriteLiteral(@"
<h2>List of Customers</h2>

<a class=""btn btn-primary btn-sm"" href=""/Customers/Create"">New Customer</a>

<table class=""table"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Email</th> 
            <th>Address</th>
            <th>Contact</th>
            <th>Action</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 23 "C:\Users\Sachintha\source\repos\MyStore\MyStore\Pages\Customers\index.cshtml"
         foreach(var c in Model.customerList)
        {

#line default
#line hidden
            BeginContext(526, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(557, 4, false);
#line 26 "C:\Users\Sachintha\source\repos\MyStore\MyStore\Pages\Customers\index.cshtml"
           Write(c.id);

#line default
#line hidden
            EndContext();
            BeginContext(561, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(585, 6, false);
#line 27 "C:\Users\Sachintha\source\repos\MyStore\MyStore\Pages\Customers\index.cshtml"
           Write(c.name);

#line default
#line hidden
            EndContext();
            BeginContext(591, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(615, 7, false);
#line 28 "C:\Users\Sachintha\source\repos\MyStore\MyStore\Pages\Customers\index.cshtml"
           Write(c.email);

#line default
#line hidden
            EndContext();
            BeginContext(622, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(646, 9, false);
#line 29 "C:\Users\Sachintha\source\repos\MyStore\MyStore\Pages\Customers\index.cshtml"
           Write(c.address);

#line default
#line hidden
            EndContext();
            BeginContext(655, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(679, 9, false);
#line 30 "C:\Users\Sachintha\source\repos\MyStore\MyStore\Pages\Customers\index.cshtml"
           Write(c.contaxt);

#line default
#line hidden
            EndContext();
            BeginContext(688, 232, true);
            WriteLiteral("</td>\r\n            <td>\r\n                <a class=\"btn btn-primary btn-sm\" href=\"/clients/edit?id=\">Edit</a>\r\n                <a class=\"btn btn-danger btn-sm\" href=\"/clients/delete?id=\">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 36 "C:\Users\Sachintha\source\repos\MyStore\MyStore\Pages\Customers\index.cshtml"
        }

#line default
#line hidden
            BeginContext(931, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyStore.Pages.Customers.indexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyStore.Pages.Customers.indexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyStore.Pages.Customers.indexModel>)PageContext?.ViewData;
        public MyStore.Pages.Customers.indexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
