using System;
using System.Collections.Generic;
using System.Text;
using ChapeauModel;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class FeedbackDAO : BaseDao
    {
        public void AddFeedback(Feedback feedback)
        {
            bool feedback1 = (feedback.TypeOfFeedback) ? 1 : 0;
            string query = $"";
            SqlParameter[] sqlParameters = { new SqlParameter()};
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
