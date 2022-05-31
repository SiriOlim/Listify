using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestProj.Handlers.Interfaces;
using TestProj.Resources;

namespace TestProj.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ListifyController : ControllerBase
    {

        [HttpGet]
        public async Task<ListifyResponseResource> Get([FromServices] IListifyHandler handler, ListifyRequestResource request)
        {
            return await handler.HandleGet(request);
        }
    }
}

