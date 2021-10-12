using System;

using iLeif.Environments.EnvModels.Extensions;

namespace iLeif.Environments.EnvModels
{
    public interface IEnvCheckBoxModel : IEnvModel, IEnvIco
    {
        bool IsChecked { get; set; }
    }

    public interface IEnvButtonModel : IEnvText, IEnvIco
    {
        bool IsPressed { get; set; }
        Action Command { get; set; }
    }

    public interface IEnvContainerModel : IEnvModel
    {

    }

    public interface IEnvLabelModel : IEnvModel
    {

    }

    public interface IEnvPopUpModel : IEnvText
    {

    }

    public interface IEnvRadioBoxModel : IEnvContainerModel
    {
        void AddRadioButton(IEnvRadioButtonModel envRadioButton);

        bool SetRadioButtonEnable(IEnvRadioButtonModel envRadioButton);
    }

    public interface IEnvRadioButtonModel : IEnvIco, IEnvText
    {
        bool IsEnabled { get; set; }
    }

    public interface IEnvTextBox : IEnvModel
    {

    }
}
