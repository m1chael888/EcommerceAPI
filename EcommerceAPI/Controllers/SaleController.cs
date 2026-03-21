using Microsoft.AspNetCore.Mvc;
using EcommerceAPI.Services;

namespace EcommerceAPI.Controllers;

[ApiController]
[Route("api/sale")]
public class SaleController
{
    private readonly ISaleService _saleService;
    public SaleController(ISaleService SaleService)
    {
        _saleService = SaleService;
    }

}