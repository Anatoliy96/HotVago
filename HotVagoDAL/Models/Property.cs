﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotVagoDAL.Models
{
   public class Property : Common
    {
        public string PropertyName { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string County { get; set; }

        public int PostalCode { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        [ForeignKey("PropertyType")]
        public int PropertyTypeID { get; set; }
        public PropertyType PropertyType { get; set; }
    }
}
