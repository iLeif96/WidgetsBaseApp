using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLeif.Environments.EnvObjects
{
    public interface IEnvButton : IEnvText, IEnvIco
    {
        bool IsPressed { get; set; }
        Action Command { get; set; }
    }
}
