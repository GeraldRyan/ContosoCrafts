#pragma checksum "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c88258b2647cd317d4fb2dea9bbf3325658c089c"
// <auto-generated/>
#pragma warning disable 1591
namespace CC.website.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
using CC.website.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
using CC.website.Services;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "namespace CC.website.Components\r\n{\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-columns");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 10 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
     foreach (var product in ProductService.GetProducts())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-img");
            __builder.AddAttribute(10, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 13 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
                                                                 product.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-body");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "h5");
            __builder.AddAttribute(16, "class", "card-title");
            __builder.AddContent(17, 
#nullable restore
#line 15 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
                                        product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "card-footer");
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "small");
            __builder.AddAttribute(25, "class", "text-muted");
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
                                  (e => SelectProduct(product.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "data-toggle", "modal");
            __builder.AddAttribute(30, "data-target", "#productModal");
            __builder.AddAttribute(31, "class", "btn btn-primary");
            __builder.AddMarkupContent(32, "\r\n                    More Info\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 26 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n}");
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
       
    Product selectProduct;
    string selectProductId;

    void SelectProduct(string productId)
    {
        selectProductId = productId;
        selectProduct = ProductService.GetProducts().First(x => x.Id == productId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CC.website.Services.JsonFileProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
