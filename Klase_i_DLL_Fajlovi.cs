using Klase_i_DLL_Fajlovi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_i_DLL_Fajlovi
{
    public class Klase_i_DLL_Fajlovi
    {
        public int x = 3;
        public string y = "string";
        public char c = 'c';
    }
}

namespace DrugiNameSpace
{
    public class Class2
    {
        public static void PrintMetod()
        {
            Klase_i_DLL_Fajlovi.Klase_i_DLL_Fajlovi Objekat2 = new Klase_i_DLL_Fajlovi.Klase_i_DLL_Fajlovi();

            Console.WriteLine("###########");
            Console.WriteLine(Objekat2.c);
            Console.WriteLine(Objekat2.y);
            Console.WriteLine(Objekat2.x);
        }
    }
}
namespace TreciNameSpace 
{
public class Class3 
    {
        public static void Mnozenje() 
        {
            Klase_i_DLL_Fajlovi.Klase_i_DLL_Fajlovi Objekat3 = new Klase_i_DLL_Fajlovi.Klase_i_DLL_Fajlovi();

            Console.WriteLine("#############");
            Console.WriteLine("Rezultat mnozenja iz treceg namespace");
            Console.WriteLine(Objekat3.x * 100);
        }
    }
}
