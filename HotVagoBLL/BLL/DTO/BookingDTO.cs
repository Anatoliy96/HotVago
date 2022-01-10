using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotVagoBLL.BLL.DTO
{
    public class BookingDTO
    {
        
        public int RoomID { get; set; }
        public int GuestsID { get; set; }
        public int PaymentID { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Status { get; set; }
        public int RoomCount { get; set; }
    }
}
