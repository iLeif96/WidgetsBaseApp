using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLeif.Environments.EnvObjects
{
    public interface IEnvCheckBox : IEnvObject, IEnvIco
    {
        bool IsChecked { get; set; }
    }
}
