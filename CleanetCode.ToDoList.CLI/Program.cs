using System;

namespace CleanetCode.ToDoList.CLI
{
    class Program
    {

        class Task

        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public bool IsCompleted { get; set; }
            public DateTime DateOfCreation { get; set; }



        }






        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(1);

        }
    }
}
