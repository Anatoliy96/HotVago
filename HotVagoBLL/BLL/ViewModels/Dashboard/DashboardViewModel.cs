using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotVagoBLL.BLL.ViewModels.Dashboard
{
    public class DashboardViewModel
    {
        public int PropertyCount { get; set; }
        public int GuestCount { get; set; }
        public int PaymentCount { get; set; }
        public int BookingCount { get; set; }
    }
}
