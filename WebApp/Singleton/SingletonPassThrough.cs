using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Singleton
{
    public class SingletonPassThrough : ISingletonPassThrough
    {
        public async Task<string> PassThrough(string message)
        {
            return message;
        }
    }
}
