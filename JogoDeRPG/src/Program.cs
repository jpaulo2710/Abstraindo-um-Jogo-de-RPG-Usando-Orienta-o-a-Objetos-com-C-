using System;
using JogoDeRPG.src.entities;


namespace JogoDeRPG
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                Hero arus = new Hero("Arus", 23, "Knight");
                Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
                Knight knight = new Knight("Knight", 23, "Knight");
                Wedge knight1 = new Wedge("Knight", 20, "Knight");


                Console.WriteLine(wizard.Attack(7));
                Console.WriteLine(wizard.Attack(1));
            }
        }
    }
}
        
    
    
