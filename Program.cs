using Pokedex.Models;
using Pokedex.Models.Pokemons;
using System;

namespace Pokedex
{
    class Program
    {
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

            Pikachu pikachu = new("Pikatchum");
            Pokemon dracofeu = new(next_pokemon_id++, "Dracofeu", "Dracofeu", t_feu, t_vol);
            Pokemon bulbizarre = new(next_pokemon_id++, "Bulbizarre", "Bulbizarre", t_plante);
            Pokemon tortank = new(next_pokemon_id++, "Tortank", "Bulbizarre", t_eau);
            Pokemon miaouss = new(next_pokemon_id++, "Miaouss", "Bulbizarre", t_normal);
            Pokemon salameche = new(next_pokemon_id++, "Salamèche", "Bulbizarre", t_feu);
            Pokemon mrmime = new(next_pokemon_id++, "M. Mime", "Bulbizarre", t_psy, t_fee);
            Pokemon racaillou = new(next_pokemon_id++, "Racaillou", "Bulbizarre", t_roche, t_sol);

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
