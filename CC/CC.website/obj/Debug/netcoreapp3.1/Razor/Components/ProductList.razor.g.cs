#pragma checksum "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd6fa87e9d52e2ec5e19acb5481c92a03b5ea39a"
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
using CC.website.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
using CC.website.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 8 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
     foreach (var product in ProductService.GetProducts())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-img");
            __builder.AddAttribute(9, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 11 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
                                                                 product.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "h5");
            __builder.AddAttribute(15, "class", "card-title");
            __builder.AddContent(16, 
#nullable restore
#line 13 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
                                        product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "card-footer");
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "small");
            __builder.AddAttribute(24, "class", "text-muted");
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
                                  (e => SelectProduct(product.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "data-toggle", "modal");
            __builder.AddAttribute(29, "data-target", "#productModal");
            __builder.AddAttribute(30, "class", "btn btn-primary");
            __builder.AddMarkupContent(31, "\r\n                    More Info\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 24 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n");
#nullable restore
#line 27 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
 if (selectedProduct != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "modal fade");
            __builder.AddAttribute(38, "id", "productModal");
            __builder.AddAttribute(39, "tabindex", "-1");
            __builder.AddAttribute(40, "role", "dialog");
            __builder.AddAttribute(41, "aria-labelledby", "productTitle");
            __builder.AddAttribute(42, "aria-hidden", "true");
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(46, "role", "document");
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "modal-content");
            __builder.AddMarkupContent(50, "\r\n                r\r\n                ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "modal-header");
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.OpenElement(54, "h5");
            __builder.AddAttribute(55, "class", "modal-title");
            __builder.AddAttribute(56, "id", "productTitle");
            __builder.AddContent(57, 
#nullable restore
#line 33 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
                                                               selectedProduct.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.AddMarkupContent(59, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "modal-body");
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "card");
            __builder.AddMarkupContent(66, "\r\n                        ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "card-img");
            __builder.AddAttribute(69, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 40 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
                                                                             selectedProduct.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.AddMarkupContent(70, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                        ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "card-body");
            __builder.AddMarkupContent(74, "\r\n                            ");
            __builder.OpenElement(75, "p");
            __builder.AddAttribute(76, "class", "card-text");
            __builder.AddContent(77, 
#nullable restore
#line 43 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
                                                  selectedProduct.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "modal-footer");
            __builder.AddMarkupContent(84, "\r\n");
#nullable restore
#line 48 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
                     if (voteCount == 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(85, "                        ");
            __builder.AddMarkupContent(86, "<span>Be the first to vote!</span>\r\n");
#nullable restore
#line 51 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(87, "                        ");
            __builder.OpenElement(88, "span");
            __builder.AddContent(89, 
#nullable restore
#line 54 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
                               voteCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(90, " ");
            __builder.AddContent(91, 
#nullable restore
#line 54 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
                                          voteLabel

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(92, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n");
#nullable restore
#line 55 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(94, "\r\n");
#nullable restore
#line 57 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
                     for (int i = 0; i < 6; i++)
                    {
                        var currentStar = i;
                        if (i <= currentRating)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(95, "                            ");
            __builder.OpenElement(96, "span");
            __builder.AddAttribute(97, "class", "fa-star fa-star checked");
            __builder.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
                                                                            (e=> SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n");
#nullable restore
#line 63 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(100, "                            ");
            __builder.OpenElement(101, "span");
            __builder.AddAttribute(102, "class", "fa-star fa-star");
            __builder.AddAttribute(103, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
                                                                    (e=> SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n");
#nullable restore
#line 67 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"


                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(105, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n");
#nullable restore
#line 75 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor"
       
    Product selectedProduct;
    string selectedProductId;

    void SelectProduct(string productId)
    {
        selectedProductId = productId;
        selectedProduct = ProductService.GetProducts().First(x => x.Id == productId);
        GetCurrentRating();
    }

    int currentRating = 0;
    int voteCount = 0;
    string voteLabel;

    void GetCurrentRating()
    {
        if (selectedProduct.Ratings == null)
        {
            currentRating = 0;
            voteCount = 0;
        }
        else
        {
            voteCount = selectedProduct.Ratings.Count();
            voteLabel = voteCount > 1 ? "Votes" : "Vote";
            currentRating = selectedProduct.Ratings.Sum() / voteCount;
        }
        System.Console.WriteLine($"Current rating for {selectedProduct.Id}: {currentRating}");
    }
    void SubmitRating(int rating)
    {
        System.Console.WriteLine($"Rating received for {selectedProduct.Id}: {rating}");
        ProductService.AddRating(selectedProductId, rating);
        SelectProduct(selectedProductId);

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
