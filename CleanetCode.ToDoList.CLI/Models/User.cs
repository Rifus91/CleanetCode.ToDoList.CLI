using System;

namespace CleanetCode.ToDoList.CLI.Models
{
    public class User
    {
        public User()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Email { get; init; }

    }

}