using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iLeif.Extensions.Objects.Comparing;

namespace iLeif.Extensions.Objects
{
    public static partial class Extensions
    {
        public static PropertiesInfo<TObject> Compare<TObject>(this TObject v1, TObject v2) => (new Comparer()).Compare(v1, v2);

    }
}
