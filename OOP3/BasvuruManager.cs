using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerservice)
        {
            //Başvuran bilgilerini değerlendir
            //İhtiyac türüne göre kredi seceneklerini gözden geçir
            //IKrediManager olarak yollarsak tüm veri tipleri giriş yapılabilir, giriş yapılan veri türüne göre hesaplamalar yapılır
            krediManager.Hesapla();
            foreach (var loggerService in loggerservice)
            {
                loggerService.Log();
            }

        }

        public void KrediBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }
        }
    }
}
