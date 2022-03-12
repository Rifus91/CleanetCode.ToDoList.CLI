using CleanetCode.ToDoList.CLI.Operations;

namespace CleanetCode.ToDoList.CLI
{
    
        public class Menu 
    {
        private IOperation[] _operations;

        public Menu(IOperation[] operations)
        {
            _operations = operations;
        }
    }
    
}
