using System;
namespace Pokedex.Models

{
    internal class Pokemon
    {
        private readonly int p_id;
        private int? p_level;
        private string p_cry,
                       p_nickname;
        protected PokemonType[] p_types;

        public string Nickname
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
        public int? Level
        {
            get { return p_level; }
        }

        public string TypesDisplay
        {
            get
            {
                string res = "";
                foreach (PokemonType type in p_types) res += string.Format(" " + type.Name);
                return res;
            }
        }

        public string Cry
        {
            set { this.p_cry = value; }
        }
        public string Rename
        {
            set { this.p_nickname = value; }
        }

        public override string ToString()
        {
            return string.Format(this.p_nickname + " : " + "\n" +
                                "id " + this.p_id + "\t" +
                                "Level " + this.p_level + "\n" +
                                "My name is {0}", this.p_nickname + "\n" +
                                this.p_cry + "\n" +
                                "Type" + TypesDisplay + "\n\n"
                );
        }

        
        public Pokemon(int id, string nickname, string cry, int? level, params PokemonType[] types)
        {
            this.p_cry = cry;
            this.p_id = id;
            this.p_level = level;
            this.p_nickname = nickname;
            this.p_types = types;
        }
    }
}
