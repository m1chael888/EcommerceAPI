using Microsoft.AspNetCore.Mvc;
using EcommerceAPI.Services;

namespace EcommerceAPI.Controllers;

[ApiController]
[Route("api/category")]
public class CategoryController
{
    private readonly ICategoryService _categoryService;
    public CategoryController(ICategoryService CategoryService)
    {
        _categoryService = CategoryService;
    }

    [HttpPost("api/category")]
    public void CreateCategory()
    {
        
    }
}