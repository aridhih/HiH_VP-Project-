using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HiH_VP_Project_.Classes
{
    internal class appointments
    {
        int Appointment_id;
        int Patient_id, Doctor_id;
        string Date,Time;


        dbConnection d = new dbConnection();



        public string Date1 { get => Date; set => Date = value; }
        public string Time1 { get => Time; set => Time = value; }
        public int Appointment_id1 { get => Appointment_id; set => Appointment_id = value; }
        public int Patient_id1 { get => Patient_id; set => Patient_id = value; }
        public int Doctor_id1 { get => Doctor_id; set => Doctor_id = value; }

        public void create()
        {
            
            string query = $"insert into Appointments(Patient_id,Doctor_id,Date,Time) values" +
               $"('{this.Patient_id1}','{this.Doctor_id1}','{this.Date}','{this.Time.ToUpper()}')";

            d.ExecuteQuery(query, true);
        }
        public DataTable read()
        {
            string query = "Select * from Appointments";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;
        }
        public void update()
        {
            string query = $"update Appointments set Patient_id='{Patient_id1}',Doctor_id='{Doctor_id1}'," +
                $"Date='{Date}',Time='{Time}' where Appointment_id ='{Appointment_id1}'";

            d.ExecuteQuery(query, true);
        }
     
        public DataTable delete(int id)
        {
            string query = $"Delete from Appointments where Appointment_id='{Appointment_id1}'";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;
        }
    }

}
