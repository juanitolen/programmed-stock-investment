using Microsoft.AspNetCore.Mvc;
using CompraProgramadaAcoes.Data;
using CompraProgramadaAcoes.Services;

namespace CompraProgramadaAcoes.Controllers;

[ApiController]
[Route("investment")]
public class InvestmentController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly PurchaseService _purchaseService;

    public InvestmentController(AppDbContext context, PurchaseService purchaseService)
    {
        _context = context;
        _purchaseService = purchaseService;
    }

[HttpPost("purchase")]
public IActionResult Purchase([FromQuery] decimal amount)
{
    if (amount <= 0)
    {
        return BadRequest("Amount must be greater than zero.");
    }

    _purchaseService.ExecutePurchase(amount);

    return Ok("Purchase executed successfully");
}

    [HttpGet("orders")]
    public IActionResult GetOrders()
    {
        var orders = _context.Orders.ToList();
        return Ok(orders);
    }

    [HttpGet("portfolio")]
    public IActionResult GetPortfolio()
    {
        var assets = _context.Assets.ToList();
        return Ok(assets);
    }
}