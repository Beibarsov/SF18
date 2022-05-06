using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF18
{
    abstract public class Command
    {
        public abstract Task Run();
        
    }
}
