#pragma checksum "C:\Users\Farid\Desktop\RabbitMQ\Part1\02_01 Begin\WebApp\ExploreCalifornia.WebApp\Pages\BookingCanceled.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f6590c68de64276e2e51629c2aaf5aca59ed7d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ExploreCalifornia.WebApp.Pages.Pages_BookingCanceled), @"mvc.1.0.razor-page", @"/Pages/BookingCanceled.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/BookingCanceled.cshtml", typeof(ExploreCalifornia.WebApp.Pages.Pages_BookingCanceled), null)]
namespace ExploreCalifornia.WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Farid\Desktop\RabbitMQ\Part1\02_01 Begin\WebApp\ExploreCalifornia.WebApp\Pages\_ViewImports.cshtml"
using ExploreCalifornia.WebApp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f6590c68de64276e2e51629c2aaf5aca59ed7d7", @"/Pages/BookingCanceled.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"889949180b08da63ba2a27ee60b067df1ebfab35", @"/Pages/_ViewImports.cshtml")]
    public class Pages_BookingCanceled : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Farid\Desktop\RabbitMQ\Part1\02_01 Begin\WebApp\ExploreCalifornia.WebApp\Pages\BookingCanceled.cshtml"
  
    ViewData["Title"] = "Booking Canceled";

#line default
#line hidden
            BeginContext(88, 135, true);
            WriteLiteral("<header id=\"contentHeader\" class=\"hasCrumbs\">\r\n    <h1>Booking Canceled</h1>\r\n</header>\r\n<article id=\"mainArticle\">\r\n    <h1>Canceled: ");
            EndContext();
            BeginContext(224, 14, false);
#line 10 "C:\Users\Farid\Desktop\RabbitMQ\Part1\02_01 Begin\WebApp\ExploreCalifornia.WebApp\Pages\BookingCanceled.cshtml"
             Write(Model.TourName);

#line default
#line hidden
            EndContext();
            BeginContext(238, 126, true);
            WriteLiteral("</h1>\r\n    <div>\r\n        <p>We\'re sorry you had to cancel the tour. We\'ll be contacting you soon.</p>\r\n    </div>\r\n</article>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookingCanceledModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookingCanceledModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookingCanceledModel>)PageContext?.ViewData;
        public BookingCanceledModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591