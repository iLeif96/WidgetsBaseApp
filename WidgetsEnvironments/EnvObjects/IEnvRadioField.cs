using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLeif.Environments.EnvObjects
{
    public interface IEnvRadioField
    {
        void AddRadioButton(IEnvRadioButton envRadioButton);

        bool SetRadioButtonEnable(IEnvRadioButton envRadioButton);
    }
}
