using HotVagoBLL.BLL.ViewModels.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotVagoBLL.BLL.BLO.Dashboard
{
   public class Dashboard
    {
        public DashboardViewModel GetDashboardViewModel()
        {
            PropertyBLL propertybll = new PropertyBLL();
            GuestBLL guestbll = new GuestBLL();
            PaymentBLL paymentbll = new PaymentBLL();
            BookingBLL bookingbll = new BookingBLL();
            return new DashboardViewModel()
            {
                PropertyCount = propertybll.GetAll().Count(),
                GuestCount = guestbll.GetAll().Count(),
                PaymentCount = paymentbll.GetAll().Count(),
                BookingCount = bookingbll.GetAll().Count()
            };
        }
    }
}
