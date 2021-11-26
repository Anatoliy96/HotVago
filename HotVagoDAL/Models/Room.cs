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
        [ForeignKey("Property")]
        public int PropertyID { get; set; }

        [ForeignKey("RoomType")]
        public int RoomTypeID { get; set; }
    }
}
