using Common;
using Orleans.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiloV2
{
    public class FooGrain : IGrainBase, IFoo
    {
        public IGrainContext GrainContext { get; }

        public FooGrain(IGrainContext grainContext)
        {
            GrainContext = grainContext;
        }

        public Task<string> Bar1()
        {
            return Task.FromResult("Version 2: Bar1");
        }

        public Task<string> Bar2()
        {
            return Task.FromResult("Version 2: Bar2");
        }
    }
}
