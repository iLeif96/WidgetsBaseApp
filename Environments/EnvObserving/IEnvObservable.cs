using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLeif.Environments.EnvObserving
{
    public interface IEnvObservable
    {
        void RegisterObserver(IEnvObserver observer);
        void RemoveObserver(IEnvObserver observer);
        void NotifyObservers();
    }
}
