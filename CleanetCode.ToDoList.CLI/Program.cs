using CleanetCode.ToDoList.CLI.Operations;
using System;
using System.Text;

namespace CleanetCode.ToDoList.CLI
{
    partial class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            IOperation[] operations = new IOperation[]
            {
                new LoginUserOperation(),
                new CreateNewUserOperation(),               
            };

            Menu menu = new Menu(operations);
            Application application = new Application(menu );
            application.Run();
           

            Console.ReadKey();
        }
    }
}
