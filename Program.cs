using Pokedex.Models;
using Pokedex.Models.Pokemons;
using Pokedex.Models.Types;
using System;

namespace Pokedex
{
    class Program
    {
        static void Main(string[] args)
        {

            Electric electric = Electric.Instance;
            Fire fire = Fire.Instance;
            Grass grass = Grass.Instance;
            Normal normal = Normal.Instance;
            Rock rock = Rock.Instance;
            Water water = Water.Instance;

            Pokemon pikachu = new Pikachu("Pikatchum", 17);
            Pokemon dracofeu = new Charizard("Dracofeu", 49);
            Pokemon bulbizarre = new Bulbasaur("Bulbizarre", 12);
            Pokemon tortank = new Blastoise("Tortank", 666);
            Pokemon miaouss = new Meowth("Miaouss", 1);
            Pokemon salameche = new(4, "Salamèche", "Bulbizarre", fire);
            Pokemon mrmime = new(122, "M. Mime", "Bulbizarre"/*, t_psy, t_fee*/);
            Pokemon racaillou = new(74, "Racaillou", "Bulbizarre", rock/*, t_sol*/);

            dracofeu.Cry = "FEU";
            bulbizarre.Cry = "Bizarre...";
            tortank.Cry = "PANZER";
            miaouss.Cry = "miaou";
            salameche.Cry = "Salam";
            mrmime.Cry = "[...]";
            racaillou.Cry = "ROCHER";

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
