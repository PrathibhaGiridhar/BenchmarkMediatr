using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Transient
{
    public interface ITransientPassThrough
    {
        Task<string> PassThrough(string message);
    }
}
