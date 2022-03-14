﻿using System;

namespace CleanetCode.ToDoList.CLI.Operations
{

    public class CreateNewUserOperation : IOperation
    {
        public string Name { get; set; }
        public void Execute()
        {
            Console.WriteLine("User created");
        }
    }

}
