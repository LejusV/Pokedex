using Pokedex.Models;
using System;

namespace Pokedex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vive Linux !");

            Pokemon pikachu = new Pokemon("Pika");

            Console.WriteLine(pikachu.Name);
            Console.WriteLine(pikachu.ToString());
        }
    }
}
