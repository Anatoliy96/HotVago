using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotVagoBLL.BLL.DTO
{
    public class FacilityDTO : IDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int FacilityTypeID { get; set; }
    }
}
