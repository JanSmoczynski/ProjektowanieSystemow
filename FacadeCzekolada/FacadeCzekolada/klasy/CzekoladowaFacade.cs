using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeCzekolada.klasy
{
    class CzekoladowaFacade
    {
        Marka marka;
        Rodzaj rodzaj;
        Kakao kakao;
        Dodatki dodatki;
        KostkaNaM2 kostka;

        public CzekoladowaFacade()
        {
            marka = new Marka();
            rodzaj = new Rodzaj();
            kakao = new Kakao();
            dodatki = new Dodatki();
            kostka = new KostkaNaM2();
        }

        public void TworzenieCzekolady()
        {
            Console.WriteLine("Tworzenie twojej najsmaczniejszej czekolady \n");

            marka.SetMarka();
            rodzaj.SetRodzaj();
            kakao.SetKakao();
            dodatki.SetDodatki();
            kostka.SetKM2();

            Console.WriteLine("\n Tworzenie czekolady zakończone sukcesem \n");
        }
    }
}
