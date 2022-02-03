using System.Collections.Generic;

namespace Pokedex.Models
{
    internal abstract class PokemonType
    {
        private readonly string p_name,
                        p_color;
        protected List<PokemonType> p_strength;

        public string Name
        {
            get { return p_name; }
        }

        public string Color
        {
            get { return p_color; }
        }

        public List<PokemonType> Strength
        {
            get
            {
                if (this.p_strength == null)
                {
                    this.DeclareStrength();
                }
                return this.p_strength;
            }
        }

        public PokemonType(string name, string color)
        {
            this.p_name = name;
            this.p_color = color;
            this.p_strength = null;
        }

        /*** Methods ***/
        protected abstract void DeclareStrength();

        public bool Affinity(PokemonType versus)
        {
            bool exist = false;

            foreach (PokemonType strength in this.Strength)
            {
                if (strength.Name == versus.Name)
                {
                    exist = true;
                }
            }
            return exist;
        }
        public bool Weakness(PokemonType versus)
        {
            bool exist = false;

            foreach (PokemonType strength in versus.Strength)
            {
                if (strength.Name == versus.Name)
                {
                    exist = true;
                }
            }
            return exist;
        }
    }
}
