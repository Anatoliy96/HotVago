using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotVagoDAL.Models
{
    public class Room : Common
    {
        public int Sleeps { get; set; }

        public decimal Price { get; set; }

        public int NumberOfRooms { get; set; }
    }
}
