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
    /// Controller for the user
    /// </summary>
    [Route("api/[controller]")]
    public class UserController:ControllerBase
    {
        /// <summary>
        /// Returns all Users
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IList<User> Get()
        {
            FakeData fd = new FakeData();
            return fd.GetUsers();
        }
        /// <summary>
        /// Returns the user with the given ID
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        [HttpGet("{UserId}")]
        public User Get(int UserId)
        {
            FakeData fd = new FakeData();
            var user = fd.GetUsers().FirstOrDefault(x => x.ID == UserId);
            return user;
        }
        /// <summary>
        /// Inserts and returns the added user
        /// </summary>
        /// <param name="user">a user with name and phone should be added</param>
        /// <returns></returns>
        [HttpPost]
        public User Post([FromBody]User user)
        {
            FakeData fd = new FakeData();
            IList<User> myUsers = fd.GetUsers();
            int id = myUsers[fd.GetUsers().Count-1].ID;
            id++;
            if (fd.InsertUser(new Models.User() { ID = id, NAME = user.NAME, PHONE = user.PHONE })) return new Models.User() { ID = id, NAME = user.NAME, PHONE = user.PHONE };
            else return null;
        }
        /// <summary>
        /// Updates and returns the given user
        /// </summary>
        /// <param name="user">A user to </param>
        /// <returns></returns>
        [HttpPut]
        public User Put([FromBody] User user)
        {
            FakeData fd = new FakeData();
            var myUser = fd.GetUsers().FirstOrDefault(x => x.ID ==user.ID);
            myUser.NAME = user.NAME;
            myUser.PHONE = user.PHONE;
            return user;
        }
        /// <summary>
        /// Deletes the user with given ID
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns>True if succeeded</returns>
        [HttpDelete("{UserId}")]
        public bool Delete(int UserId)
        {
            bool result = false;
            FakeData fd = new FakeData();
            var user = fd.GetUsers().FirstOrDefault(x => x.ID == UserId);
            if (fd.DeleteUser(user)) result = true;
            return result;
        }
    }
}
