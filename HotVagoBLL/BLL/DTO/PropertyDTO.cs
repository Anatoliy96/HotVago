using HotVagoDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotVagoBLL.BLL.DTO
{
   public class PropertyDTO : IDto
    {
        public int ID { get; set; }
        public string PropertyName { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string County { get; set; }

        public int PostalCode { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }
        public PropertyType PropertyType { get; set; }
    }
}
