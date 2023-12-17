using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace HiH_VP_Project_.Classes
{
    internal class dbConnection
    {
        string con = "Data Source=.;Initial Catalog=OnlineDoctorAppointmentSystem;" +
            "Integrated Security=True";
        public DataTable? ExecuteQuery(string query , bool flag)
        {
            SqlConnection c = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand(query, c);

            if (flag == true)
            {
                c.Open();
                cmd.ExecuteNonQuery();
                c.Close();
                return null;
            }
            else
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }
    }
}
