using AfaRestApi.Data;
using AfaRestApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfaRestApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    public class RehberController : Controller
    {
        /// <summary>
        /// Inserts and returns the added user
        /// </summary>
        /// <param name="rehber">a user with name and phone should be added</param>
        /// <returns></returns>
        [HttpPost]
        public Rehber Post([FromBody] Rehber rehber)
        {
            return RehberData.RehberKaydet(rehber);
        }
    }
}
