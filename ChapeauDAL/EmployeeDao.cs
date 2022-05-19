using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ChapeauModel;

namespace ChapeauDAL
{
    public class EmployeeDao : BaseDao
    {
        public List<Employee> GetAllRooms()
        {
            string query = "SELECT roomNr, roomType, capacity FROM [ROOM]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();

            foreach (DataRow dr in dataTable.Rows)
            {


                Employee employee = new Employee()
                {
                    EmployeeFirstName = (string)dr["firstName"].ToString(),
                    EmployeeLastName = (string)dr["lastName"].ToString(),
                    EmployeeUsername = (string)dr["username"].ToString(),
                    EmployeeUserPassword = (string)dr["userPassword"].ToString(),
                    employeeType = (EmployeeType)dr["employeeType"]
                };
                employees.Add(employee);
            }
            return employees;
        }

        private void AddEmployee(Employee employee)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@firstName", employee.EmployeeFirstName),
                new SqlParameter("@lastName", employee.EmployeeLastName),
                new SqlParameter("@userame", employee.EmployeeUsername),
                new SqlParameter("@password", employee.EmployeeUserPassword),
                new SqlParameter("@type", employee.employeeType),
            };

        }

    }
}
