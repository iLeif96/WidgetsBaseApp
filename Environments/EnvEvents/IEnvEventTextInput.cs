
using iLeif.Environments.EnvEvents;

namespace iLeif.Environment.EnvEvents
{
    public interface IEnvTextInput : IEnvEvent
    {
        string PreviousText { get; }
        string NewText { get; }
    }
}
