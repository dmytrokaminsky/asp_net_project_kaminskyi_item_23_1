using asp_net_project_kaminskyi_item_23_1_web.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_project_kaminskyi_item_23_1_web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        [HttpGet]
        public ActionResult Get()
        {
            return Ok("Hello world!");
        }

        [HttpPost]
        public ActionResult Post(User user)
        {
            return Ok(user);
        }


    }
}
