using CleanetCode.ToDoList.CLI.Models;
using CleanetCode.ToDoList.CLI.Storages;
using System;

namespace CleanetCode.ToDoList.CLI.Operations
{

    public class CreateNewUserOperation : IOperation
    {
        public string Name => "Создать нового пользователя";//"Create new user";
        public void Execute()
        {            
            Console.WriteLine("Введите ваш email: ");
            string? email = Console.ReadLine();

            User newUser = new User()
            {
                Email = email,
            };

           bool UserCreated = UserStorage.Create(newUser);
            if (!UserCreated)
            {
                Console.WriteLine("Пользователь с таким email уже есть или произошла ошибка (по хорошему вернуть список вариантов ошибок)");
            }

            Console.WriteLine("Пользователь был успешно создан");

        }
    }

}
