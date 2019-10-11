using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Scoped;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScopedController : ControllerBase
    {
        private IScopedPassThrough scopedPassThrough;

        public ScopedController(IScopedPassThrough scopedPassThrough)
        {
            this.scopedPassThrough = scopedPassThrough;
        }

        [HttpGet]
        public async Task<string> GetMessage(string message)
        {
            return await scopedPassThrough.PassThrough(message);
        }
    }
}