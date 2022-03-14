using CleanetCode.ToDoList.CLI.Operations;
using System;

namespace CleanetCode.ToDoList.CLI
{
    partial class Program
    {

        static void Main(string[] args)
        {
            IOperation[] operations = new IOperation[]
            {
                new CreateNewUserOperation(),
                new LoginUserOperation(),
            };

            Menu menu = new Menu(operations);
            Application application = new Application(menu );
            application.Run();
           

            Console.ReadKey();
        }
    }
}
