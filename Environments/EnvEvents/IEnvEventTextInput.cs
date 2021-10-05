using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iLeif.Environments.EnvEvents;

namespace iLeif.Environments.EnvObserving.IEnvObservers
{
    public interface IEnvTextInput : IEnvEvent
    {
        string PreviousText { get; }
        string NewText { get; }
    }
}
