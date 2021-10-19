
using iLeif.Environment.EnvViewStates;
using iLeif.Environment.EnvViews;
using iLeif.Graphic;
using iLeif.MVP;
using System.Collections.Generic;

namespace iLeif.Environment
{
    public class CheckModel : IEnvCheckBoxState
    {
        public bool IsChecked { get; set; }
        public Size Size { get; set; }
        public bool IsActive { get; set; }
        public bool IsCollapced { get; set; }
        public Dictionary<string, Image> Ico { get; set; }
        public bool IsIcoUsing { get; set; }
    }

    public interface IEnvironment
    {
        string Name { get; }
        //IEnvironment GetInctance();
        IEnvPresentatorsFactory CreateFactory();
    }
}
