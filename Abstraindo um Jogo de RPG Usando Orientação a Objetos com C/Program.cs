using System;
using Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C.src.Entites;

namespace Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C_
{
    class Program
    {       

        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus",35, "Knight","HP 469/749","MP 72/72", "Tauros");
            Wizard wizard = new Wizard("Jeni35",35, "White Wizard","HP 325/601","MP 474/482", "Virgo");
            Ninja Wedge = new Ninja("Wedge",35, "Ninja","HP 292/574","MP 89/89", "Aquarius");
            Blck Topapa = new Blck("Topapa",35, "Black Wizard","HP 106/385","MP 611/641", "Scorpio");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(9));
        }

    }
}
