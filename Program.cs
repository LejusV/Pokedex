using Pokedex.Models;
using Pokedex.Models.Pokemons;
using System;

namespace Pokedex
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pikachu = new Pikachu("Pikatchum", 17);
            Pokemon dracofeu = new Charizard("Dracofeu", 49);
            Pokemon bulbizarre = new Bulbasaur("Bulbizarre", 12);
            Pokemon tortank = new Blastoise("Tortank", 666);
            Pokemon miaouss = new Meowth("Miaouss", 1);
            Pokemon salameche = new Charmander("Salamèche", 42);
            Pokemon mrmime = new MrMime("M. Mime", 2);
            Pokemon racaillou = new Geodude("Racaillou", 999);

            pikachu.Display();
            dracofeu.Display();
            bulbizarre.Display();
            tortank.Display();
            miaouss.Display();
            salameche.Display();
            mrmime.Display();
            racaillou.Display();
        }
    }
}
