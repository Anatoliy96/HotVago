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
        [ForeignKey("Booking")]
        public int BookingID { get; set; }

        [ForeignKey("Room")]
        public int RoomID { get; set; }
    }
}
