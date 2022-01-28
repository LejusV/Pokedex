using System;
namespace Pokedex.Models

{
    internal class Pokemon
    {
        private readonly int p_id;
        private int p_level;
        private string p_cry,
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
        public int Id
        {
            get { return p_id; }
        }
        public int Level
        {
            get { return p_level; }
        }
        
        public string Cry
        {
            set { this.p_cry = value; }
        }

        public override string ToString()
        {
            return string.Format("My name is {0}", this.p_nickname);
        }

        public void Display()
        {
            Console.WriteLine(this.p_id);
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
            this.p_cry = cry;
            this.p_id = id;
            this.p_level = level;
            this.p_nickname = nickname;
            this.p_types = types;
        }
    }


}
