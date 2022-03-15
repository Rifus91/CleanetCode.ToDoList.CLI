using System;

namespace CleanetCode.ToDoList.CLI.Operations
{

    public class CreateNewUserOperation : IOperation
    {
        public string Name => "Create new user";
        public void Execute()
        {
            Console.WriteLine("User created");
        }
    }

}
