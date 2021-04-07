using System;
using System.Collections.Generic;
using System.Text;

namespace _5_HW5_GameProject
{
    interface IUserValidationService
    {
        // Kullanıcı doğrulama sistemi
        bool Validate(Gamer gamer);
    }
}
