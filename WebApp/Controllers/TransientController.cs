using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Transient;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransientController : ControllerBase
    {
        private ITransientPassThrough transientPassThrough;

        public TransientController(ITransientPassThrough transientPassThrough)
        {
            this.transientPassThrough = transientPassThrough;
        }

        [HttpGet]
        public async Task<string> GetMessage(string message)
        {
            return await transientPassThrough.PassThrough(message);
        }
    }
}