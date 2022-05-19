using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public DateTime DateOfPayment { get; set; }
        public double PaymentPrice { get; set; }
        public double Tip { get; set; }
        //public int TableId { get; set; }
    }
}
