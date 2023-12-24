using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiH_VP_Project_.Classes
{
    internal class Doctor
    {
        int Doctor_id;
        string Name, Email, Location;
        double Phone;

        dbConnection d = new dbConnection();

        public int Doctor_id1 { get => Doctor_id; set => Doctor_id = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Location1 { get => Location; set => Location = value; }
        public double Phone1 { get => Phone; set => Phone = value; }


        public void create()
        {
            string query = $"insert into Doctor(Name,Phone,Email,Location) values" +
               $"('{this.Name1}',{this.Phone1},'{this.Email1}','{this.Location1}')";

            d.ExecuteQuery(query, true);
        }
        public DataTable read()
        {
            string query = "Select * from Doctor";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;
        }
        public void update()
        {

            string query = $"update Doctor set Name='{Name1}',Location='{Location1}'," +
                $"Phone='{Phone1}',Email='{Email1}' where Doctor_id ='{Doctor_id1}'";

            d.ExecuteQuery(query, true);
        }
        public DataTable delete(int id)
        {
            string query = $"Delete from Doctor where Doctor_id='{Doctor_id}'";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
    }
}
