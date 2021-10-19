using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using iLeif.Extensions.Arrays;

namespace iLeif.Extensions.Objects.Reflection
{
    public class Properties<TObject> : IEnumerable<PropertyInfo>
    {
        private TObject _valObject;
        private List<PropertyInfo> _properies;

        public Properties(TObject valObj)
        {
            _valObject = valObj;
            _properies = new List<PropertyInfo>();
        }
        public Properties(TObject valObj, IEnumerable<PropertyInfo> properies)
        {
            _valObject = valObj;
            _properies = new List<PropertyInfo>(properies);
        }

        public int Count => _properies.Count;

        public void Add(PropertyInfo pInfo)
        {
            _properies.Add(pInfo);
        }

        public void ApplyToObject(TObject obj)
        {
            foreach (var prop in _properies)
            {
                prop.SetValue(obj, prop.GetValue(_valObject));
            }
        }

        public IEnumerator<PropertyInfo> GetEnumerator() => ((IEnumerable<PropertyInfo>)_properies).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_properies).GetEnumerator();
    }
}
