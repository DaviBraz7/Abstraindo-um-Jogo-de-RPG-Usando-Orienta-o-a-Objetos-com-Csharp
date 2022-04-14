using System;
using Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C_.src.entities;

namespace Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C_
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 23, "knight");
            Wizard Wizard = new Wizard("Jennica", 23, "Write Wizard");

            Console.WriteLine(Wizard.Attack(1));
            Console.WriteLine(Wizard.Attack(7));
            
        }
    }

}