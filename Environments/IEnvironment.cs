
using iLeif.Environments.EnvModels;
using iLeif.Environments.EnvViews;

namespace iLeif.Environments
{
    public interface IEnvironment
    {
        IEnvLayoutModel DefaultLayout { get; }

        IEnvButtonView AddButton(IEnvButtonModel envObject, IEnvLayoutModel envLayout = null);
        IEnvLabelView AddLabel(IEnvLabelModel envObject, IEnvLayoutModel envLayout = null);
        IEnvContainerView AddContainer(IEnvContainerModel envObject, IEnvLayoutModel envLayout = null);
        IEnvCheckBoxView AddCheckBox(IEnvCheckBoxModel envObject, IEnvLayoutModel envLayout = null);
        IEnvRadioButtonView AddRadioButton(IEnvRadioButtonModel envObject, IEnvLayoutModel envLayout = null);
        IEnvRadioBoxView AddRadio(IEnvRadioBoxModel envObject, IEnvLayoutModel envLayout = null);
        IEnvPopUpView AddPopUp(IEnvPopUpModel envObject, IEnvLayoutModel envLayout = null);

        void UpdateEnvView(IEnvModel envObject);
    }
}
