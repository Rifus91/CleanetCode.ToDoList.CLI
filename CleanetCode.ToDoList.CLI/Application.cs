
using System;

namespace CleanetCode.ToDoList.CLI
{

    public class Application
    {
        private readonly Menu _menu;

        public Application(Menu menu)
        {
            _menu = menu;
        }

        public void Run()
        {
            string[] operationNames = _menu.GetOperationNames();

            Console.WriteLine(string.Join(", ", operationNames));
        }
    }

}
