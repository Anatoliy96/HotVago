using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotVagoBLL.BLL.DTO
{
   public class PaymentDTO
    {
        public int RoomID { get; set; }

        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public int PaymentTypesID { get; set; }
    }
}
