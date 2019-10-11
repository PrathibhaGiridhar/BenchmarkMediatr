using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Handler;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediatrController : ControllerBase
    {
        private IMediator mediator;
        public MediatrController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<string> GetMessage(string message)
        {
            return await mediator.Send(new MediatrPassThrough(message));
        }
    }
}