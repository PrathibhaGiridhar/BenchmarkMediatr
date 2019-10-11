using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Transient
{
    public class TransientPassThrough : ITransientPassThrough
    {
        public async Task<string> PassThrough(string message)
        {
            return message;
        }
    }
}
