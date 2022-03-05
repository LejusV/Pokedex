using Pokedex.Enums;
using System;
using System.Collections.Generic;

namespace Pokedex.Models
{
    internal class Player
    {
        private string p_name = "";
        private Gender? p_gender = null;
        private List<Pokemon> p_poks;

        int InsertByLevel(Pokemon pok)
        {

            int count = p_poks.Count;
            for (int i = 0; i < count; i++)
            {
                if (p_poks[i].Level < pok.Level)
                {
                    p_poks.Insert(i, pok);
                    return 1;
                }
            }

            p_poks.Add(pok);

            return 1;
        }

        public void AddPokemon(Pokemon pok)
        {
            InsertByLevel(pok);
            Console.WriteLine(pok.Nickname + " joined your team !\n");
        }

        public Gender? Gender
        {
            get { return p_gender; }
        }

        public string Name
        {
            get { return p_name; }
        }

        public List<Pokemon> Pokemons
        {
            get { return p_poks; }
        }

        public Player(string name, Gender gender, List<Pokemon> poks = null)
        {
            p_gender = gender;
            p_name = name;
            p_poks = poks;
            p_poks = new List<Pokemon>();
        }
    }
}
