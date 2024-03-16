using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace StudentRC_management_system.Models
{
    public class ClsEmployeeDbcontext
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public bool AddEmployee(ClsEmployee std)
        {

            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("sp_setEmployeeDetail", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@code", std.code);
            cmd.Parameters.AddWithValue("@Name", std.Name);
            cmd.Parameters.AddWithValue("@Age", std.Age);
            cmd.Parameters.AddWithValue("@Department", std.Department);
            cmd.Parameters.AddWithValue("@Email", std.Email);
            cmd.Parameters.AddWithValue("@Salary", std.Salary);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public List<SelectListItem> GetItemsFromDatabase()
        {
            List<SelectListItem> items = new List<SelectListItem>();

            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT Id, Name FROM tblemployee";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    items.Add(new SelectListItem
                    {
                        Value = rdr["id"].ToString(),
                        Text = rdr["Name"].ToString()
                    });
                }
            

            return items;
        }

    }


}