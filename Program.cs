using Pokedex.Models;
using System;

namespace Pokedex
{
    class Program
    {
        /*
        static void Display(Pokemon pok)
        {
            Console.WriteLine(pok.ID);
            Console.WriteLine(pok.Name);
            Console.WriteLine(pok.ToString());
            Console.WriteLine(pok.Shout);
        }*/

        static void Main(string[] args)
        {
            PokemonType t_normal = new("Normal", "gris");
            PokemonType t_feu = new("Feu", "rouge");
            PokemonType t_eau = new("Eau", "bleu outremer");
            PokemonType t_glace = new("Glace", "bleu clair");
            PokemonType t_elec = new("Electrique", "jaune");
            PokemonType t_plante = new("Plante", "vert");
            PokemonType t_psy = new("Psy", "rose fushia");
            PokemonType t_vol = new("Vol", "violette");
            PokemonType t_roche = new("Roche", "beige");
            PokemonType t_sol = new("Sol", "Marron");
            PokemonType t_fee = new("Fee", "rose pastel");

            int next_pokemon_id = 1;

            Pokemon pikachu = new(next_pokemon_id++, "Pika", t_elec);
            Pokemon dracofeu = new(next_pokemon_id++, "Dracofeu", t_feu, t_vol);
            Pokemon bulbizarre = new(next_pokemon_id++, "Bulbizarre", t_plante);
            Pokemon tortank = new(next_pokemon_id++, "Tortank", t_eau);
            Pokemon miaouss = new(next_pokemon_id++, "Miaouss", t_normal);
            Pokemon salameche = new(next_pokemon_id++, "Salamèche", t_feu);
            Pokemon mrmime = new(next_pokemon_id++, "M. Mime", t_psy, t_fee);
            Pokemon racaillou = new(next_pokemon_id++, "Racaillou", t_roche, t_sol);

            pikachu.Cry = "PikaPika";
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
