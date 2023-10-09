using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace EmployeeSalesDatabase
{
    public class DataLayer
    {
        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["EmployeeSalesDatabase.Properties.Settings.EmployeesDBConnectionString"].ConnectionString;
        }


        public static DataTable GetEmployees()
        {
            string sql = "SELECT firstname, lastname, title, birthdate FROM Employees";
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static int GetNumEmployees()
        {
            string sql = "SELECT COUNT(*) FROM Employees";
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public static string GetXML()
        {
            string sql = "SELECT firstname, lastname FROM Employees FOR XML AUTO";
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                System.Xml.XmlReader reader = cmd.ExecuteXmlReader();
                string xmlResult = "";
                while (reader.Read())
                {
                    xmlResult += reader.ReadOuterXml();
                }
                return xmlResult;
            }
        }
    }
}
