using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace iLeif.Extensions.Objects.Reflection
{
    public class ReflectionManager<TObject>
    {
        public Properties<TObject> GetProperties(TObject obj) =>
            new Properties<TObject>(obj, obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.GetProperty));

        public void ApplyPropertiesToObject(TObject obj, Properties<TObject> props)
        {
            props.ApplyToObject(obj);
        }
    }
}
