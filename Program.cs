
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 2001,
                FirstName = "Yasin",
                LastName = "Şensoy",
                IdentityNumber = 12345
            });
        }
    }
}