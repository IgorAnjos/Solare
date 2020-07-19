using Microsoft.AspNetCore.Mvc;

namespace SolareWeb.Controllers
{
    [ApiController]
    public class PromotionController : ControllerBase
    {
        public IActionResult Promotions(){
            return Ok();
        }

        public IActionResult PromotionAdd(){
            return Ok();
        }

        [HttpPost]
        public IActionResult Save(){
            return Ok();
        }

        public IActionResult Update(){
            return Ok();
        }

        public IActionResult Delete(){
            return Ok();
        }
    }
}