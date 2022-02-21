using System;
using System.Collections.Generic;

namespace Pokedex.Models
{
    internal class Pokemon
    {
        
        PokemonDB db = new PokemonDB();

        //public void connection

        private readonly int _id;
        protected int? _level;
        private string _cry,
                       _nickname;
        protected PokemonType[] _types;

        protected PokemonStats _natural_fixed_stats;
        protected PokemonStats _current_base_stats;
        protected PokemonStats _current_actual_stats;

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

        public PokemonStats BaseStats
        {
            get { return _current_base_stats;}
        }

        public PokemonStats ActualStats
        {
            get { return _current_actual_stats;}
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
                string res = "Type";
                foreach (PokemonType type in _types) res += string.Format(" " + type.Name);
                return res+"\n\n";
            }
        }

        public string StatsDisplay
        {
            get
            {
                string res = "Stats:";
                foreach (string key in _current_base_stats.Keys) res += string.Format("\n\t" + key.ToUpper() + " " + _current_base_stats.Get(key));
                return res+"\n\n";
            }
        }

        public override string ToString()
        {
            return string.Format("\n" + 
                                this._nickname + " : " + "\n" +
                                "\tLevel " + this._level + "\n" +
                                "\t" + this._current_actual_stats.Get("hp") + "/" + this._current_base_stats.Get("hp") + "HP" + "\n\n"
                );
        }

        public string MovesDisplay()
        {
            string res = "";
            foreach (Move m in _moves) res += m.Name + "\n";
            return res+"\n";
        }
        

        public void CalculateStats()
        {
            foreach(string key in _current_base_stats.Keys)
            {
                int natural_stat = _natural_fixed_stats.Get( key );
                this._current_base_stats.Set( key , Convert.ToInt32(natural_stat + 0.002*( natural_stat * ( _level ?? default(int) - 1)  + 0.1 * natural_stat * ( _level ?? default(int) - 1 ) * ( _level ?? default(int) -1 ) )));
            }
        //    (2*base + iv +  ev/4 * level)/100  + level + 10
        //    (2*base + iv + ev/4 * level)/100  + 5
        }

        public void ResetActualStats()
        {
            this._current_base_stats.CopyTo(this._current_actual_stats);
            this._current_actual_stats.Set("hp", this._current_actual_stats.Get("hp") - 1);
        }

        
        public Pokemon(int id, string nickname, string cry, int? level, params PokemonType[] types)
        {
            _cry = cry;
            _id = id;
            _level = level;
            _nickname = nickname;
            _types = types;
            _current_base_stats = new PokemonStats(0, 0, 0, 0, 0, 0);
            _current_actual_stats = new PokemonStats(0, 0, 0, 0, 0, 0);
            _moves = new List<Move>();
        }
    }
}