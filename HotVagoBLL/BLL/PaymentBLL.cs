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
   public class PaymentBLL
    {
        public List<PaymentDTO> GetAll()
        {
            PaymentsDAO paymentsDAO = new PaymentsDAO();
            List<Payments> payments = (List<Payments>)paymentsDAO.GetAll();
            List<PaymentDTO> paymentDTOs = new List<PaymentDTO>();

            foreach (var p in payments)
            {
                CloneData.CloneData<Payments, PaymentDTO> convertor =
                    new CloneData.CloneData<Payments, PaymentDTO>();

                paymentDTOs.Add(convertor.CopyData(p));
            }
            return paymentDTOs;
        }
    }
}
