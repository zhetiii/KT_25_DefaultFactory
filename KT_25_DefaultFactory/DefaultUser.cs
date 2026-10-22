using System;

namespace KT_25_DefaultFactory
{
    public class DefaultUser : IInitializable
    {
        public string Name;
        public int Age;

        public DefaultUser()
        {
        }

        public void Initialize()
        {
            Name = "Гость";
            Age = 18;
            Console.WriteLine($"DefaultUser инициализирован: Имя = {Name}, Возраст = {Age}");
        }
    }
}