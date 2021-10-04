using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLeif.Environments.EnvObjects
{
    public interface IEnvIco : IEnvObject
    {
        double IcoWidth { get; set; }
        double IcoHeigth { get; set; }
        string URL { get; set; }
        bool IsIcoUsing { get; set; }
    }
}
