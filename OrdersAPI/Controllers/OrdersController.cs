using Microsoft.AspNetCore.Mvc;

namespace OrdersAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class SellerController : ControllerBase
{
    private static readonly string[] Seller = new[]
    {
        "Yandex Market", "Ozon", "Online Trade"
    };

    [HttpGet]
    public ActionResult Get()
    {
        var rng = new Random();
        return Ok(Seller[rng.Next(Seller.Length)]);

    }
}
