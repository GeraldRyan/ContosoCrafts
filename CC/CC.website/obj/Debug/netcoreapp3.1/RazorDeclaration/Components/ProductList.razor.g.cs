#pragma checksum "C:\Users\User\Documents\Code\ASP\CC\CC.website\Components\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c88258b2647cd317d4fb2dea9bbf3325658c089c"
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