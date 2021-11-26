using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotVagoDAL.Models
{
    public class Facilities : Common
    {
        public string Name { get; set; }

        [ForeignKey("FacilityType")]

        public int FacilityTypeID { get; set; }
    }
}
