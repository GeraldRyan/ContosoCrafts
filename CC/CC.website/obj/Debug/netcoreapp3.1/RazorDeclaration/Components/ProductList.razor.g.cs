#pragma checksum "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd6fa87e9d52e2ec5e19acb5481c92a03b5ea39a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
