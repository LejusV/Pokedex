//using Pokemons.Models.Abilities.ElectrikType;
//using Pokemons.Models.Abilities.NormalType;
using System;

namespace Pokemons.Models.Pokemons.ElectrikType
{
    /*class Pikachu : Pokemon
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
    }*/
}

namespace Pokedex.Models

{
    internal class Pokemon
    {
        private int p_id,
                    p_level;
        private string  p_cry,
                        p_nickname;
        protected PokemonType[] p_types;

        public string nickname
        {
            get { return p_nickname; }
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
            Console.WriteLine(this.p_nickname);
            Console.WriteLine("Level " + this.p_level);
            Console.WriteLine(this.ToString());
            Console.WriteLine(this.p_cry);
            Console.Write("Type");
            foreach (PokemonType type in p_types)
                 Console.Write(" " + type.Name);
            Console.WriteLine();
            Console.WriteLine();
        }

        public Pokemon(int id, string nickname, string cry, int level, params PokemonType[] types)
        {
            this.p_level = level;
            this.p_id = id;
            this.p_cry = string.Empty;
            this.p_nickname = nickname;
            this.p_cry = cry;
            this.p_types = types;
        }

        public string Cry
        {
            set { this.p_cry = value; }
        }

        public override string ToString()
        {
            return string.Format("My name is {0}", this.p_nickname);
        }
    }


}
