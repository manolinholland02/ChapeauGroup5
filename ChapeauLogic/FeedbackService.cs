using System;
using System.Collections.Generic;
using System.Text;
using ChapeauLogic;
using ChapeauModel;
using ChapeauDAL;
    


namespace ChapeauLogic
{
    public class FeedbackService
    {
        FeedbackDAO feedbackdb;

        public FeedbackService()
        {
            feedbackdb = new FeedbackDAO();
        }
        public void AddFeedback(Feedback feedback)
        {
            feedbackdb.AddFeedback(feedback);
        }
    }
}
