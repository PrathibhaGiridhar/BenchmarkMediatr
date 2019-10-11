using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Scoped
{
    public class ScopedPassThrough : IScopedPassThrough
    {
        public async Task<string> PassThrough(string message)
        {
            return message;
        }
    }
}
