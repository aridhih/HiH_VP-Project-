using System.Data;

namespace HiH_VP_Project_.Classes
{
    internal class Patient
    {
        int id;
        string Name, Address, Patient_email;
        double Phone;
        dbConnection d = new dbConnection();


        public string Name1 { get => Name; set => Name = value; }
        public string Address1 { get => Address; set => Address = value; }
        public string Patient_email1 { get => Patient_email; set => Patient_email = value; }
        public double Phone1 { get => Phone; set => Phone = value; }
        public int Id { get => id; set => id = value; }

        public void create()
        {
            string query = $"insert into Patient(Name,Address,Phone,Patient_email) values" +
                $"('{this.Name}','{this.Address}',{this.Phone1},'{this.Patient_email1}')";
           
            d.ExecuteQuery(query, true);
           
        }
        public DataTable read()
        {
            string query = "Select * from patient";            
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;
        }
        public void update()
        {
           
            string query = $"update Patient set Name='{Name1}',Address='{Address1}'," +
                $"Phone='{Phone1}',Patient_email='{Patient_email1}' where Patient_id='{Id}'";

            d.ExecuteQuery(query, true);
        }
        public DataTable delete(int id)
        {
            string query = $"Delete from patient WHERE Patient_id='{Id}'";
            DataTable dt =  d.ExecuteQuery(query, false);
            return dt;

        }

        

    }
}

