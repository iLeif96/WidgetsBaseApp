using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLeif.Environments
{
    public interface IEnvObject
    {
        UId _id { get; }
        Graphic.Size Size { get; set; }
        bool IsActive { get; set; }
        bool IsCollapced { get; set; }
    }
}
