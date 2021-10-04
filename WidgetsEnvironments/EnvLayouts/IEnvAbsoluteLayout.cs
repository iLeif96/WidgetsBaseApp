using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLeif.Environments.EnvLayouts
{
    public interface IEnvAbsoluteLayout : IEnvLayout
    {
        int X { get; set; }
        int Y { get; set; }
    }
}
