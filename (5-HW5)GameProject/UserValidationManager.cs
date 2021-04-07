using System;
using System.Collections.Generic;
using System.Text;

namespace _5_HW5_GameProject
{
    class UserValidationManager : IUserValidationService
    {
        // sonucunda sadece doğru yada yanlış olarak geri dönüş aldığımız için public void yerine public bool yaparız
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear == 1996 && gamer.FirstName == "AYTUĞ" && gamer.LastName == "YEŞİLYURT" && gamer.IdentityNumber == 12345)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        
    }
}
