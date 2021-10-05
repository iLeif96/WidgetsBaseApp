using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iLeif.Environments.Enums;

namespace iLeif.Environments.EnvEvents
{
    public interface IEnvEventKey
    {
        ConsoleKey Key { get; }
        KeyUpDown UpDown { get; }
    }
}
