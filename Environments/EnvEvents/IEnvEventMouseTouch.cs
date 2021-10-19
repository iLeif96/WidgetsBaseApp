
using iLeif.Environments.Enums;
using iLeif.Environments.EnvEvents;

namespace iLeif.Environment.EnvEvents
{
    public interface IEnvMouseTouch : IEnvEvent
    {
        KeyUpDown LeftKey { get; }
        KeyUpDown RightKey { get; }
    }
}
