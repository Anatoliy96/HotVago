using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotVagoDAL.Models
{
    public class RoomsBooked : Common
    {
        [ForeignKey("BookingID")]
        public int BookingID { get; set; }

        [ForeignKey("RoomID")]
        public int RoomID { get; set; }
    }
}
