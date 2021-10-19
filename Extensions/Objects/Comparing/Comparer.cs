using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using iLeif.Extensions.Objects.Reflection;

namespace iLeif.Extensions.Objects.Comparing
{
    internal class Comparer<TObject>
    {
        private ReflectionManager<TObject> _refManager = new ReflectionManager<TObject>();

        public Properties<TObject> Compare(TObject v1, TObject v2)
        {
            Properties<TObject> result = new Properties<TObject>(v2);
            if (v1.GetType().Name != v2.GetType().Name)
                return result;


            var props1 = _refManager.GetProperties(v1)
                .Where(v => v.GetCustomAttribute<NotComparablePropertyAttribute>(false) == null).ToDictionary(v => v.Name);
            var props2 = _refManager.GetProperties(v2)
                .Where(v => v.GetCustomAttribute<NotComparablePropertyAttribute>(false) == null).ToDictionary(v => v.Name);

            foreach (var p1 in props1)
            {
                if (props2.TryGetValue(p1.Key, out PropertyInfo p2))
                {
                    if (!p1.Value.GetValue(v1).Equals(p2.GetValue(v2)))
                    {
                        result.Add(p2);
                    }
                }
            }

            return result;
        }
    }
}
