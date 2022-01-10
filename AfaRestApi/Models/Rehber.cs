using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfaRestApi.Models
{
    /// <summary>
    /// Rehber sınıfı, MSSQL Testi için
    /// </summary>
    public class Rehber
    {
        /// <summary>
        /// Veritabanı kayıt ID
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// adı soyadı
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// telefon numarası
        /// </summary>
        public string phone { get; set; }
        /// <summary>
        /// email
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// Yapıcı method :)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        public Rehber(string name, string phone, string email)
        {
            this.name = name;
            this.phone = phone;
            this.email = email;
        }
        /// <summary>
        /// Boş Yapıcı
        /// </summary>
        public Rehber()
        {
        }

        
    }
}
