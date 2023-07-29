using Microsoft.AspNetCore.Mvc;

namespace UbuntuTrial.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        List<string> products = new List<string>();

        [HttpGet]
        public IActionResult Get()
        {
            products.Add("Telefon");
            products.Add("PC");
            return Ok(products);
        }



    }
}
