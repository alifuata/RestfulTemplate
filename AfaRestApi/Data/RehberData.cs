using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using AfaRestApi.Models;
namespace AfaRestApi.Data
{
    /// <summary>
    /// Rehber işlemleri için oluşturuldu
    /// </summary>
    public class RehberData
    {
        private static SqlConnection con = new SqlConnection(@"Server=DESKTOP-H2V3AVG\SQLEXPRESS;Database=Rehber;User Id=Rehber;Password=Pl123456;Integrated Security=false;");
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rehber"></param>
        public static Rehber RehberKaydet(Rehber rehber)
        {
            Rehber rb = new Rehber();
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Rehber (name, phone, email) VALUES (@name, @phone, @email); SELECT id FROM Rehber WHERE name=@name and phone=@phone and email=@email;", con);
                cmd.Parameters.AddWithValue("@name", rehber.name);
                cmd.Parameters.AddWithValue("@phone", rehber.phone);
                cmd.Parameters.AddWithValue("@email", rehber.email);
                con.Open();
                int id =(int) cmd.ExecuteScalar();
                con.Close();
                rb = new Rehber() { email = rehber.email, name = rehber.name, phone = rehber.phone, id = id };

            }
            catch (Exception)
            {
                rb.id = 0;
                throw;
            }
            return rb;

        }
    }
}
