using System;

using iLeif.Environment.EnvViewStates.Extensions;
using System.Collections.Generic;

namespace iLeif.Environment.EnvViewStates
{
    public interface IEnvCheckBoxState : IEnvViewState, IEnvIco
    {
        bool IsChecked { get; set; }
    }

    public interface IEnvButtonState : IEnvViewState, IEnvIco, IEnvText
    {
        bool IsPressed { get; set; }
        Action Command { get; set; }
    }

    public interface IEnvContainerState : IEnvViewState, IEnvIco
    {
        IEnvLayoutModel LayoutModel { get; set; }
    }

    public interface IEnvLabelState : IEnvViewState, IEnvText
    {

    }

    public interface IEnvPopUpState : IEnvViewState, IEnvText
    {

    }

    public interface IEnvRadioBoxState : IEnvContainerState
    {
        void AddRadioButton(IEnvRadioButtonState envRadioButton);

        bool SetRadioButtonEnable(IEnvRadioButtonState envRadioButton);
    }

    public interface IEnvRadioButtonState : IEnvViewState, IEnvIco, IEnvText
    {
        bool IsEnabled { get; set; }
    }

    public interface IEnvTextBoxState : IEnvViewState
    {

    }
}
