using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iLeif.Environments.EnvObjects;

namespace iLeif.Environments
{
    public interface IEnvironment
    {
        IEnvLayout DefaultLayout { get; }

        void AddButton(IEnvButton envObject, IEnvLayout envLayout = null);
        void AddLabel(IEnvLabel envObject, IEnvLayout envLayout = null);
        void AddContainer(IEnvContainer envObject, IEnvLayout envLayout = null);
        void AddCheckBox(IEnvCheckBox envObject, IEnvLayout envLayout = null);
        void AddRadioButton(IEnvRadioButton envObject, IEnvLayout envLayout = null);
        void AddRadio(IEnvRadioField envObject, IEnvLayout envLayout = null);
        void AddPopUp(IEnvPopUp envObject, IEnvLayout envLayout = null);

        void UpdateEnvObject(IEnvObject envObject);
    }
}
