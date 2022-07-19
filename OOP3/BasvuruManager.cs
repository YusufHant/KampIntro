using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection-bu metodun kullanacağı hangi kredi türü,hangi loglayacı olacağını enjekte ediyoruz.
        public void BasvuruYap(IKrediManager krediManager, IloggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            //
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBigilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
