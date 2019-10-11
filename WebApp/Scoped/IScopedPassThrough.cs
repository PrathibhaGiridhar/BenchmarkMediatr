using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Scoped
{
    public interface IScopedPassThrough
    {
        Task<string> PassThrough(string message);
    }
}
