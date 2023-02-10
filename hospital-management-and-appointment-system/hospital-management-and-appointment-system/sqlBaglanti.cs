using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace hospital_management_and_appointment_system
{
    internal class sqlBaglanti 
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-T54ECK5;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();  
            return baglan;
        }
    }
}
