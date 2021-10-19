using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLeif.Transactions
{
    public interface ITimeoutable
    {
        event EventHandler TimerStopped;
        double TimeToStop { get; set; }

        void SatrtTimer();
        void StopTimer();

    }
}
