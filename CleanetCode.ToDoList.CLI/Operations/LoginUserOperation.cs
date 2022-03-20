using CleanetCode.ToDoList.CLI.Models;
using CleanetCode.ToDoList.CLI.Storages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanetCode.ToDoList.CLI.Operations
{
    public class LoginUserOperation : IOperation
    {
        public string Name => "Залогинится в системе";//"Login into the system";

        public void Execute()
        {
            Console.WriteLine("Введите ваш email");
            string? email = Console.ReadLine();
            User? user = UserStorage.Get(email);

            if (user == null) 
            {
            UserSessioin.CurrentUser = user;
            }
        }
    }
}
