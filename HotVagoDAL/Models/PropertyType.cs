using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotVagoDAL.Models
{
    public class PropertyType : Common
    {
        public string PropertyTypeName { get; set; }

        [ForeignKey("PropertyID")]
        public int PropertyID { get; set; }
    }
}
