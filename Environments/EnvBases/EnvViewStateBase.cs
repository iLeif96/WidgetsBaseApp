using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iLeif.Extensions.Objects.Comparing;
using iLeif.Graphic;

namespace iLeif.Environment.EnvBases
{
    public abstract class EnvViewStateBase : IEnvViewState
    {
        //private bool _isCloned = false;
        //public bool IsCloned => _isCloned;

        [NotComparableProperty]
        public Guid Id { get; } = Guid.NewGuid();
        public Size Size { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsCollapced { get; set; } = true;

        protected EnvViewStateBase(string name, string description, Size size)
        {
            Name = name;
            Description = description;
            Size = size;
        }

        public virtual object Clone()
        {
            object cloned = MemberwiseClone();

            if (cloned is EnvViewStateBase tCloned)
            {
                tCloned.Size = (Size)Size.Clone();
            }

            return cloned;
        }

    }
}
