using System;
using Xello.BusinessLayer;

namespace Xello.Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            var UserCreds = new UserCredentialsFunctions();
            UserCreds.createUser();
            Console.WriteLine("Hello World!");
        }
    }
}
