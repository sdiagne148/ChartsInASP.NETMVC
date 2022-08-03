using ArticleAPIExample.Data;
using ArticleAPIExample.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArticleAPIExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        ConnectionDbContext db;
        public ValuesController(ConnectionDbContext _db)
        {
                db = _db;
        }
        [HttpGet]
        public ActionResult GetData()
        {
            return Ok(db.saleData.ToList());
        }
        
    }
}
