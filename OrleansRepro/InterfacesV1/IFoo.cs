using Orleans.CodeGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Version(1)]
    public interface IFoo : IGrainWithStringKey
    {
        Task<string> Bar1();
    }
}
