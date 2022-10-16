using Microsoft.AspNetCore.Mvc;

namespace DeliveryAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class DeliveryController : ControllerBase
{
    private static readonly string[] Seller = new[]
    {
        "DPD", "Pony", "SDEK"
    };

    [HttpGet]
    public ActionResult Get()
    {
        var rng = new Random();
        return Ok(Seller[rng.Next(Seller.Length)]);

    }
}
