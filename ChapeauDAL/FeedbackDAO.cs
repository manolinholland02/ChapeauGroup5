using System;
using System.Collections.Generic;
using System.Text;
using ChapeauModel;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
<<<<<<< HEAD
    public class FeedbackDAO : BaseDao
=======
    public class FeedbackDao
>>>>>>> 8568e1683575d6f53c231608ed3c40b7da1e2191
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
