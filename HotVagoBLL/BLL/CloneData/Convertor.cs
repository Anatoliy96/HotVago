using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotVagoBLL.BLL.CloneData
{
   public class Convertor<TSource, TDestination> : CloneData<TSource, TDestination>
        where TSource : HotVagoDAL.Models.Common
        where TDestination : IDto
    {
    }
}
