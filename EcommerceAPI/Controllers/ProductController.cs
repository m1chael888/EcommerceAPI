using EcommerceAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers;

[ApiController]
[Route("api/product")]
public class ProductController
{
    private readonly IProductService _productService;
    public ProductController(IProductService ProductService)
    {
        _productService = ProductService;
    }

}