using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Singleton
{
    public interface ISingletonPassThrough
    {
        Task<string> PassThrough(string message);
    }
}
