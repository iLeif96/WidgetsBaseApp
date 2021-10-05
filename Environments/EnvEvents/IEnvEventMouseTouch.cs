using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iLeif.Environments.Enums;
using iLeif.Environments.EnvEvents;

namespace iLeif.Environments.EnvObserving.IEnvObservers
{
    public interface IEnvMouseTouch : IEnvEvent
    {
        KeyUpDown LeftKey { get; }
        KeyUpDown RightKey { get; }
    }
}
