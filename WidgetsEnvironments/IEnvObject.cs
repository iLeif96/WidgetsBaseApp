using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLeif.Environments
{
    public interface IEnvObject
    {
        double Width { get; set; }
        double Height { get; set; }

        bool IsActive { get; set; }
        bool IsCollapced { get; set; }
    }
}
