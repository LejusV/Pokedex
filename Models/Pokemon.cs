//using Pokemons.Models.Abilities.ElectrikType;
//using Pokemons.Models.Abilities.NormalType;
using Pokemons.Models.Types;
using System;

namespace Pokemons.Models.Pokemons.ElectrikType
{
    class Pikachu : Pokemon
    {
        #region Constructors
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="level">Pokemon level</param>
        public Pikachu(Int32 level)
            : base(25, "Pikachu", level, 0.4, 6, "Balance des éclairs", Electrik.Singleton)
        {
            // Implement attacks
            this.attacks.Add(new Feint());
            this.attacks.Add(new Spark());
            this.attacks.Add(new Thunder());
        }
        #endregion
    }
}

{
    internal class Pokemon
    {
        private int p_id,
                    p_level;
        private string  p_cry,
                        p_name;
        private PokemonType[] p_types;

        public string Name
        {
            get { return p_name; }
        }
        public string Shout
        {
            get { return p_cry; }
        }
        public int ID
        {
            get { return p_id; }
        }
        public int Level
        {
            get { return p_level; }
        }

        public void Display()
        {
            Console.WriteLine(this.p_id);
            Console.WriteLine(this.p_name);
            Console.WriteLine("Level " + this.p_level);
            Console.WriteLine(this.ToString());
            Console.WriteLine(this.p_cry);
            Console.Write("Type");
            foreach (PokemonType type in p_types)
                 Console.Write(" " + type.Name);
            Console.WriteLine();
            Console.WriteLine();
        }

        public Pokemon(int id, string n, params PokemonType[] types)
        {
            this.p_level = 1;
            this.p_id = id;
            this.p_cry = string.Empty;
            this.p_name = n;
            this.p_types = types;
        }

        public string Cry
        {
            set { this.p_cry = value; }
        }

        public override string ToString()
        {
            return string.Format("My name is {0}", this.p_name);
        }
    }


}
