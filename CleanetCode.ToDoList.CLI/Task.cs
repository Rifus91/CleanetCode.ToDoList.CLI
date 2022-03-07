using System;

namespace CleanetCode.ToDoList.CLI
{
    partial class Program
    {
        class Task

        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public bool IsCompleted { get; set; }
            public DateTime DateOfCreation { get; set; }
            public DateTime UpdatedDate { get; set; }
            public Guid UserId { get; set; }

        }
    }
}
