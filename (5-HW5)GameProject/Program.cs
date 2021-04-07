using System;

namespace _5_HW5_GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer{Id = 1,BirthYear = 1996,FirstName = "AYTUĞ",LastName = "YEŞİLYURT",IdentityNumber = 12345});
            Console.ReadLine();
            
        }
    }
}
