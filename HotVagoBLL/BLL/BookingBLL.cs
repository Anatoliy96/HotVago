using HotVagoBLL.BLL.DTO;
using HotVagoDAL.DAO;
using HotVagoDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotVagoBLL.BLL
{
    public class BookingBLL
    {
        public List<BookingDTO> GetAll()
        {
            BookingDAO bookingDAO = new BookingDAO();
            List<Booking> bookings = (List<Booking>)bookingDAO.GetAll();
            List<BookingDTO> bookingDTO = new List<BookingDTO>();

            foreach (var b in bookings)
            {
                CloneData.CloneData<Booking, BookingDTO> convertor =
                    new CloneData.CloneData<Booking, BookingDTO>();

                bookingDTO.Add(convertor.CopyData(b));
            }

            return bookingDTO;
        }
    } 
}
