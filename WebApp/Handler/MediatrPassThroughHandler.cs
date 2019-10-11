using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebApp.Handler
{
    public class MediatrPassThroughHandler : IRequestHandler<MediatrPassThrough, string>
    {
        public async Task<string> Handle(MediatrPassThrough request, CancellationToken cancellationToken)
        {
            return request.Message;
        }
    }
}
