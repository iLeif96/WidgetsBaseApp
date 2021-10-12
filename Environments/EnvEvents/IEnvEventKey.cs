using System;

using iLeif.Environments.Enums;

namespace iLeif.Environments.EnvEvents
{
    public interface IEnvEventKey
    {
        ConsoleKey Key { get; }
        KeyUpDown UpDown { get; }
    }
}
