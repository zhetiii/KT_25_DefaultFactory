using System;

namespace KT_25_DefaultFactory
{
    public class DefaultSettings : IInitializable
    {
        public string Theme;
        public int Volume;

        public DefaultSettings()
        {
        }

        public void Initialize()
        {
            Theme = "Темная";
            Volume = 80;
            Console.WriteLine($"DefaultSettings инициализирован: Тема = {Theme}, Громкость = {Volume}");
        }
    }
}