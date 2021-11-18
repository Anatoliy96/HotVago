using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotVagoDAL.Models
{
   public class RoomType : Common 
    {
        public string RoomTypes { get; set; }
        public bool RoomStatus { get; set; }
        public int Sleeps { get; set; }
        public decimal Price { get; set; }
        public int NumberOfRooms { get; set; }

        public string Description { get; set; }
    }
}
