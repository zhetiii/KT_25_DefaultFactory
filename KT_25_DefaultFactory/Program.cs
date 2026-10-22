using System;

namespace KT_25_DefaultFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DefaultUser user = Factory.CreateAndInitialize<DefaultUser>();

            DefaultSettings settings = Factory.CreateAndInitialize<DefaultSettings>();
        }
    }
}