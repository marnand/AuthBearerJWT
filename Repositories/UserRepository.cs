using System.Collections.Generic;
using System.Linq;
using AuthBearerJWT.Models;

namespace AuthBearerJWT.Repositories
{
    public static class UserRepository
    {
        public static User Get(string userName, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, UserName = "Batman", Password = "batman", Role = "manager" });
            users.Add(new User { Id = 2, UserName = "Robin", Password = "robin", Role = "employee" });

            return users.Where(x => x.UserName.ToLower() == userName.ToLower() && x.Password == password.ToLower()).FirstOrDefault();
        }
        
    }
}