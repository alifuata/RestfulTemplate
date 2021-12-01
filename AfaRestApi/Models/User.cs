using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfaRestApi.Models
{
    /// <summary>
    /// A user class
    /// </summary>
    public class User
    {
        /// <summary>
        /// Unique ID of the record
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Name of the user
        /// </summary>
        public string NAME { get; set; }
        /// <summary>
        /// Phone number of the user
        /// </summary>
        public string PHONE { get; set; }
    }
}
