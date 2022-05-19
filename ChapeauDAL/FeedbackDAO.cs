using System;
using System.Collections.Generic;
using System.Text;
using ChapeauModel;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class FeedbackDao : BaseDao
    {
        public void AddFeedback(Feedback feedback)
        {
            string feedackNote = (feedback.Note);
            string query = $"";
            SqlParameter[] sqlParameters = { new SqlParameter() };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
