using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ChapeauModel;

namespace ChapeauDAL
{
    public class PaymentDAO : BaseDao
    {
        public List<Payment> GetPaymentDetails()
        {
            string query = $"";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Payment> ReadTables(DataTable dataTable)
        {
            List<Payment> payments = new List<Payment>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Payment payment = new Payment()
                {
                    PaymentId = (int)dr["paymentId"],
                    DateOfPayment = (DateTime)dr["dateOfPayment"],
                    PaymentPrice = (decimal)dr["paymentPrice"],
                    Tip = (decimal)dr["tip"],
                    TableId = (int)dr["tableId"],
                };
                payments.Add(payment);
            }
            return payments;
        }
    }
}
