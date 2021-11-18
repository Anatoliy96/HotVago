using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotVagoDAL.Models
{
    public class Booking : Common
    {
        [ForeignKey("PropertyID")]
        public int PropertyID { get; set; }

        [ForeignKey("GuestsID")]
        public int GuestsID { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Status { get; set; }
        public int RoomCount { get; set; }
    }
}
