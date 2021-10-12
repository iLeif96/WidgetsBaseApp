
using iLeif.Environments.EnvEvents;

namespace iLeif.Environments.EnvObserving.IEnvObservers
{
    public interface IEnvTextInput : IEnvEvent
    {
        string PreviousText { get; }
        string NewText { get; }
    }
}
