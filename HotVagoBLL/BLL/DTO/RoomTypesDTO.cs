using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotVagoBLL.BLL.DTO
{
    public class RoomTypesDTO
    {
        public int ID { get; set; }
        public string RoomTypes { get; set; }
        public bool IsActive { get; set; }
        public int Sleeps { get; set; }
        public decimal Price { get; set; }
        public int NumberOfRooms { get; set; }

        public string Description { get; set; }
    }
}
