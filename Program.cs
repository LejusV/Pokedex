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
            Pokemon dracofeu = new Charizard("Charizard", 49);
            Pokemon bulbizarre = new Bulbasaur("Bulbizarre", "Bulbizarre", Grass.Instance);
            Pokemon tortank = new(9, "Tortank", "Bulbizarre", water);
            Pokemon miaouss = new(52, "Miaouss", "Bulbizarre", normal);
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
