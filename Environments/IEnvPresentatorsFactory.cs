using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iLeif.Environment.EnvViewStates;
using iLeif.Environment.EnvViews;
using iLeif.Environment;

namespace iLeif.Environment
{
    public interface IEnvPresentatorsFactory
    {
        IEnvButtonView AddButton(IEnvButtonModel envObject, IEnvLayoutModel envLayout = null);
        IEnvLabelView AddLabel(IEnvLabelModel envObject, IEnvLayoutModel envLayout = null);
        IEnvContainerView AddContainer(IEnvContainerModel envObject, IEnvLayoutModel envLayout = null);
        IEnvCheckBoxView AddCheckBox(IEnvCheckBoxModel envObject, IEnvLayoutModel envLayout = null);
        IEnvCheckBoxView AddToggle(IEnvCheckBoxModel envObject, IEnvLayoutModel envLayout = null);
        IEnvRadioButtonView AddRadioButton(IEnvRadioButtonModel envObject, IEnvLayoutModel envLayout = null);
        IEnvRadioBoxView AddRadio(IEnvRadioBoxModel envObject, IEnvLayoutModel envLayout = null);
        IEnvPopUpView AddPopUp(IEnvPopUpModel envObject, IEnvLayoutModel envLayout = null);


        IEnvLayoutModel DefaultLayout { get; }
        void UpdateEnvView(IEnvViewState envObject);
    }
}
