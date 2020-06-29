using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konichi_wa
{
    internal class TurnBlonde : IHero_Super_Sayan
    {
        private int rekimas { get; set; }
        int IHero_Super_Sayan.rekimas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        private string raumenys { get; set; }
        string IHero_Super_Sayan.raumenys { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void wtf()
        {
            Console.WriteLine(" ");
        }
    }

    internal class Morph : IVillain_Freeza
    {
        private int rekimasNera { get; set; }
        int IVillain_Freeza.rekimasNera { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        private string raumenysLabaiMaziLolNoob { get; set; }
        string IVillain_Freeza.raumenysLabaiMaziLolNoob { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void whaaaat()
        {
            Console.WriteLine(" ");
        }
    }

    internal class Kakaroto : IHero_Super_Sayan
    {
        public int rekimas { get { return int.MaxValue; } set { } }
        public string raumenys { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void wtf()
        {
            Console.WriteLine("Saitama is op");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }
}