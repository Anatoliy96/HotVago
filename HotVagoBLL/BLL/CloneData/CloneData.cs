using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HotVagoBLL.BLL.CloneData
{
    public class CloneData<TSource, TDestination>
    {
        public static TDestination CopyProperties(TSource source)
        {
            var target = (TDestination)Activator.CreateInstance(typeof(TDestination));

            Type objTypeBase = source.GetType();
            Type objTypeTarget = target.GetType();

            PropertyInfo _propinfo = null;
            var propInfos = objTypeBase.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach (var propInfo in propInfos)
            {
                try
                {
                    _propinfo = objTypeTarget.GetProperty(propInfo.Name, BindingFlags.Instance | BindingFlags.Public);
                    if (_propinfo != null)
                    {
                        _propinfo.SetValue(target, propInfo.GetValue(source));
                    }
                }
                catch (ArgumentException aex) { if (!string.IsNullOrEmpty(aex.Message)) continue; }
                catch (Exception ex) { if (!string.IsNullOrEmpty(ex.Message)) return default(TDestination); }
            }

            return target;
        }
    }
}
