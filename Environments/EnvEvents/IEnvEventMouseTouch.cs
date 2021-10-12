
using iLeif.Environments.Enums;
using iLeif.Environments.EnvEvents;

namespace iLeif.Environments.EnvObserving.IEnvObservers
{
    public interface IEnvMouseTouch : IEnvEvent
    {
        KeyUpDown LeftKey { get; }
        KeyUpDown RightKey { get; }
    }
}
