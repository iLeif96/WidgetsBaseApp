using System;

using iLeif.Environments.Enums;

namespace iLeif.Environment.EnvEvents
{
    public interface IEnvEventKey
    {
        ConsoleKey Key { get; }
        KeyUpDown UpDown { get; }
    }
}
