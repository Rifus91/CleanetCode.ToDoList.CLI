using CleanetCode.ToDoList.CLI.Operations;
using System;
using System.Collections.Generic;

namespace CleanetCode.ToDoList.CLI
{

    public class Menu
    {
        private IOperation[] _operations;

        public Menu(IOperation[] operations)
        {
            _operations = operations;
        }

        public string[] GetOperationNames()
        {
            List<string> operationNames = new List<string>();
            for (int i = 0; i < _operations.Length; i++)
            {
                IOperation operation = _operations[i];
                operationNames.Add($"{i} - {operation.Name}");
            }
            return operationNames.ToArray();
        }

        public void Enter(int operationNumber)
        {
            //найти номер операции и соответствующий номер операции мы тут задействуем (найдем этот номер)
            if (operationNumber < 0 || operationNumber >= _operations.Length)
            {
                return;
            }
            _operations[operationNumber].Execute(); 
        }
    }
    
}
