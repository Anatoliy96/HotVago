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

        public TDestination CopyData(TSource Source)
        {
            //Create object
            TDestination destination = (TDestination)Activator.CreateInstance(typeof(TDestination));

            // Get common properties by name
            List<PropertyInfo> props = typeof(TDestination).GetProperties().
                Where(pd => typeof(TSource).GetProperties().Any(ps => ps.Name == pd.Name)).ToList();

            // Copy values of command properties and set them to destination
            foreach (PropertyInfo property in props)
            {
                var _prop = typeof(TSource).GetProperty(property.Name).GetValue(Source);
                typeof(TDestination).GetProperty(property.Name).SetValue(destination, _prop);
            }

            return destination;
        }















        //public static TDestination CopyProperties(TSource source)
        //{
        //    var target = (TDestination)Activator.CreateInstance(typeof(TDestination));

        //    Type objTypeBase = source.GetType();
        //    Type objTypeTarget = target.GetType();

        //    PropertyInfo _propinfo = null;
        //    var propInfos = objTypeBase.GetProperties(BindingFlags.Instance | BindingFlags.Public);
        //    foreach (var propInfo in propInfos)
        //    {
        //        try
        //        {
        //            _propinfo = objTypeTarget.GetProperty(propInfo.Name, BindingFlags.Instance | BindingFlags.Public);
        //            if (_propinfo != null)
        //            {
        //                _propinfo.SetValue(target, propInfo.GetValue(source));
        //            }
        //        }
        //        catch (ArgumentException aex) { if (!string.IsNullOrEmpty(aex.Message)) continue; }
        //        catch (Exception ex) { if (!string.IsNullOrEmpty(ex.Message)) return default(TDestination); }
        //    }

        //    return target;
        //}
    }
}
