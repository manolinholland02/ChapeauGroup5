using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public string TypeOfFeedback { get; set; }
        public string Note { get; set; }
        public DateTime DateOfFeedback { get; set; }
        //public int TableId { get; set; }
    }
}
