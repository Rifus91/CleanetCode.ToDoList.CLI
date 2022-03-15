using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanetCode.ToDoList.CLI.Operations
{
    public class LoginUserOperation : IOperation
    {
        public string Name => "Login into the system";

        public void Execute()
        {
            Console.WriteLine("User logged in");
        }
    }
}
