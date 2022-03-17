using CleanetCode.ToDoList.CLI.Models;
using System.Collections.Generic;

namespace CleanetCode.ToDoList.CLI.Storages
{    
        public class UserStorage 
    {
        private static readonly Dictionary<string, User> _users = new();
        public static User? Get(string email)
        {
            _users.TryGetValue(email, out User? user);
            return user;
        }

        public static void Create(User user)
        {
            _users.Add(user.Email, user);
        }
    }
    
}
