using AfaRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfaRestApi.Data
{
    /// <summary>
    /// Temporary List of Users
    /// </summary>
    public class FakeData
    {
        private static IList<User> AllUsers;
        /// <summary>
        /// Returns all users in IList
        /// </summary>
        /// <returns>List of users</returns>
        public IList<User> GetUsers()
        {
            if (AllUsers==null)
            {
                AllUsers = new List<User>() {
                    new User() { ID=1,NAME="Ali Fuat",PHONE="5055050505"},
                    new User() { ID=2,NAME="Gonca",PHONE="5065060606"},
                    new User(){ ID=3,NAME="Meral Bilge",PHONE="5075070707"} };                
            }
            return AllUsers;
        }
        /// <summary>
        /// Adds a new user in to List
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Returns true if succeeded false otherwise</returns>
        public bool InsertUser(User user)
        {
            bool result = false;
            try
            {
                AllUsers.Add(user);
                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
        /// <summary>
        ///  Removes a new user from List
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Returns true if succeeded false otherwise</returns>
        public bool DeleteUser(User user)
        {
            bool result = false;
            try
            {
                AllUsers.Remove(user);
                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }
}
