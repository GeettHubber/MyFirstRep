using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konichi_wa
{
    interface IHero_Super_Sayan
    {
        int rekimas {get; set; }
        string raumenys { get; set; }
        void wtf();
    }
    class TurnBlonde : IHero_Super_Sayan
    {
        int rekimas { get; set; }
        int IHero_Super_Sayan.rekimas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string raumenys { get; set; }
        string IHero_Super_Sayan.raumenys { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void wtf()
        {
                Console.WriteLine(" ");
        }
}
    interface IVillain_Freeza
    {
        int rekimasNera { get; set; }
        string raumenysLabaiMaziLolNoob { get; set; }
        void whaaaat();
    }
    class Morph : IVillain_Freeza
    {
        int rekimasNera { get; set; }
        int IVillain_Freeza.rekimasNera { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string raumenysLabaiMaziLolNoob { get; set; }
        string IVillain_Freeza.raumenysLabaiMaziLolNoob { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void whaaaat()
        {
            Console.WriteLine(" ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
