using System;
using System.Collections.Generic;

namespace Pokedex.Models
{
    internal class Pokemon
    {
        private readonly int _id;
        private int? _level;
        private string _cry,
                       _nickname;
        protected PokemonType[] _types;

        protected PokemonStats _base_stats;
        protected PokemonStats _evolutive_stats;

        protected List<Move> _moves;

        public string Nickname
        {
            get { return _nickname; }
        }

        public string Shout
        {
            get { return _cry; }
        }

        public int Id
        {
            get { return _id; }
        }

        public int? Level
        {
            get { return _level; }
        }

        public List<Move> Moves
        {
            get {return _moves;}
        }

        public string Cry
        {
            set { this._cry = value; }
        }
        public string Rename
        {
            set { this._nickname = value; }
        }
        
        public void AddMove(Move move)
        {
            _moves.Add( move );
        }

        public string TypesDisplay
        {
            get
            {
                string res = "";
                foreach (PokemonType type in _types) res += string.Format(" " + type.Name);
                return res;
            }
        }

        public string StatsDisplay
        {
            get
            {
                string res = "";
                foreach (string key in _evolutive_stats.Keys) res += string.Format("\n\t" + key.ToUpper() + " " + _evolutive_stats.Get(key));
                return res;
            }
        }

        public override string ToString()
        {
            return string.Format(this._nickname + " : " + "\n" +
                                "id " + this._id + "\t" +
                                "Level " + this._level + "\n" +
                                "My name is {0}", this._nickname + "\n" +
                                this._cry + "\n" +
                                "Type" + TypesDisplay + "\n" + 
                                "Stats:" + StatsDisplay + "\n\n"
                );
        }

        public string MovesDisplay()
        {
            string res = "";
            foreach (Move m in _moves) res += m.Name + "\n";
            res += "\n";
            return res;
        }

        protected void CalculateStats()
        {
            foreach(string key in _evolutive_stats.Keys)
            {
                int base_stat = _base_stats.Get( key );
                this._evolutive_stats.Set( key , Convert.ToInt32(base_stat + 0.002*( base_stat * ( _level ?? default(int) - 1)  + 0.1 * base_stat * ( _level ?? default(int) - 1 ) * ( _level ?? default(int) -1 ) )));
            }
        //    (2*base + iv +  ev/4 * level)/100  + level + 10
        //    (2*base + iv + ev/4 * level)/100  + 5
        }

        
        public Pokemon(int id, string nickname, string cry, int? level, params PokemonType[] types)
        {
            _cry = cry;
            _id = id;
            _level = level;
            _nickname = nickname;
            _types = types;
            _evolutive_stats = new PokemonStats(0, 0, 0, 0, 0, 0);
            _moves = new List<Move>();
        }
    }
}
