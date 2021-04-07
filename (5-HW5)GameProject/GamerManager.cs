using System;
using System.Collections.Generic;
using System.Text;

namespace _5_HW5_GameProject
{
    class GamerManager : IGamerService
    {
        // MicroService

        private IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName.ToUpper() + " sisteme başarıyla kaydedildi!");
            }
            else
            {
                Console.WriteLine(gamer.FirstName + " " + (gamer.LastName).ToUpper() + " KİŞİ BİLGİLERİ UYUŞMUYOR! LÜTFEN KONTROL EDİN.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " sistemden başarıyla silindi!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " sistemde başarıyla güncellendi!");
        }
    }
}
