using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AfaRestApi.Models
{
    /// <summary>
    /// Car Object
    /// </summary>
    public class Car
    {
        /// <summary>
        /// DB Unique ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Year of the car
        /// </summary>
        
        [Required]
        public int Year { get; set; }
        /// <summary>
        /// Brand of the car
        /// </summary>
        [StringLength(10)]
        [Required]
        public string Make { get; set; }
        /// <summary>
        /// Model of the car
        /// </summary>
        [Required]
        public string Model { get; set; }
        /// <summary>
        /// Money to be paid for the car
        /// </summary>
        [Required]
        public Double Price { get; set; }
    }
}
