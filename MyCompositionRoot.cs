using DryIoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DryIOC
{
    public class MyCompositionRoot
    {
        public MyCompositionRoot(IRegistrator r)
        {
            r.Register<IHello, Hello>(Reuse.Transient);
        }
    }
}
