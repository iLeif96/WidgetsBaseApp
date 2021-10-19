using System.Collections.Generic;

namespace iLeif.Environment.EnvViewStates.Extensions
{
    public interface IEnvIco
    {
        Dictionary<string, Graphic.Image> Ico { get; set; }
        bool IsIcoUsing { get; set; }
    }
}
