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
    public class GuestBLL
    {
        public List<GuestDTO> GetAll()
        {
            GuestsDAO guestsDAO = new GuestsDAO();
            List<Guests> guests = (List<Guests>)guestsDAO.GetAll();
            List<GuestDTO> guestDTOs = new List<GuestDTO>();

            foreach (var g in guests)
            {
                CloneData.CloneData<Guests, GuestDTO> convertor =
                    new CloneData.CloneData<Guests, GuestDTO>();

                guestDTOs.Add(convertor.CopyData(g));
            }
            return guestDTOs;
        }

        public GuestDTO Get(int ID)
        {
            GuestsDAO guestsDAO = new GuestsDAO();
            Guests guests = guestsDAO.GetByID(ID);
            GuestDTO guestDTO = new GuestDTO();

            CloneData.CloneData<Guests, GuestDTO> convertor =
                new CloneData.CloneData<Guests, GuestDTO>();

            guestDTO = convertor.CopyData(guests);
            return guestDTO;
        }

        public void Insert(
            string FirstName,
            string LastName,
            string Email,
            int PhoneNumber)
        {
            Guests guests = new Guests();

            guests.FirstName = FirstName;
            guests.LastName = LastName;
            guests.Email = Email;
            guests.PhoneNumber = PhoneNumber;

            GuestsDAO guestsDAO = new GuestsDAO();
            guestsDAO.Add(guests);
        }

        public void Update(
            int ID,
            string FirstName,
            string LastName,
            string Email,
            int PhoneNumber)
        {
            Guests guests = new Guests();

            guests.ID = ID;
            guests.FirstName = FirstName;
            guests.LastName = LastName;
            guests.Email = Email;
            guests.PhoneNumber = PhoneNumber;

            GuestsDAO guestsDAO = new GuestsDAO();
            guestsDAO.Update(guests);
        }

        public void Delete(int ID)
        {
            GuestsDAO guestsDAO = new GuestsDAO();
            guestsDAO.Delete(ID);
        }
    }
}
