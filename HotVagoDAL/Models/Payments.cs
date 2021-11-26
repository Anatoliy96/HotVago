using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotVagoDAL.Models
{
   public class Payments : Common
    {
        [ForeignKey("Room")]
        public int RoomID { get; set; }

        public DateTime Date { get; set; }

        public string Payment { get; set; }

        [ForeignKey("PaymentTypes")]
        public int PaymentTypesID { get; set; }
    }
}
