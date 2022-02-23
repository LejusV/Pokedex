using System;
using System.Collections.Generic;

namespace Pokedex.Models
{
    public class Pokemon
    {
        
        //PokemonDB db = new PokemonDB();

        //public void connection

        private readonly int _id;
        protected int _level;
        private string _nickname;
        protected PokemonSpecie _specie;
        protected PokemonType[] _types;
        protected PokemonStats _calculated_stats;
        protected PokemonStats _current_stats;

        protected List<Move> _moves;

        public string Nickname
        {
            get { return _nickname; }
        }

        public int Id
        {
            get { return _id; }
        }

        public int Level
        {
            get { return _level; }
        }

        public List<Move> Moves
        {
            get {return _moves;}
        }

        public PokemonStats CalculatedStats
        {
            get { return _calculated_stats;}
        }

        public PokemonStats CurrentStats
        {
            get { return _current_stats;}
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
                foreach (string key in _calculated_stats.Keys) res += string.Format("\n\t" + key.ToUpper() + " " + _calculated_stats.Get(key));
                return res+"\n\n";
            }
        }

        public override string ToString()
        {
            return string.Format("\n" + 
                                this._nickname + " : " + "\n" +
                                "\tLevel " + this._level + "\n" +
                                "\t" + this._current_stats.Get("hp") + "/" + this._calculated_stats.Get("hp") + "HP" + "\n\n"
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
            this._calculated_stats.Set( "hp" , Convert.ToInt32(_specie.Hp + 0.002*( _specie.Hp * ( _level - 1)  + 0.1 * _specie.Hp * ( _level - 1 ) * ( _level -1 ) )));
            this._calculated_stats.Set( "attack" , Convert.ToInt32(_specie.Attack + 0.002*( _specie.Attack * ( _level - 1)  + 0.1 * _specie.Attack * ( _level - 1 ) * ( _level -1 ) )));
            this._calculated_stats.Set( "defense" , Convert.ToInt32(_specie.Defense + 0.002*( _specie.Defense * ( _level - 1)  + 0.1 * _specie.Defense * ( _level - 1 ) * ( _level -1 ) )));
            this._calculated_stats.Set( "sp_attack" , Convert.ToInt32(_specie.SpecialAttack + 0.002*( _specie.SpecialAttack * ( _level - 1)  + 0.1 * _specie.SpecialAttack * ( _level - 1 ) * ( _level -1 ) )));
            this._calculated_stats.Set( "sp_defense" , Convert.ToInt32(_specie.SpecialDefense + 0.002*( _specie.SpecialDefense * ( _level - 1)  + 0.1 * _specie.SpecialDefense * ( _level - 1 ) * ( _level -1 ) )));
            this._calculated_stats.Set( "speed" , Convert.ToInt32(_specie.Speed + 0.002*( _specie.Speed * ( _level - 1)  + 0.1 * _specie.Speed * ( _level - 1 ) * ( _level -1 ) )));
        }
        //    (2*base + iv +  ev/4 * level)/100  + level + 10
        //    (2*base + iv + ev/4 * level)/100  + 5


        public void ResetActualStats()
        {
            this._calculated_stats.CopyTo(this._current_stats);
            this._current_stats.Set("hp", this._current_stats.Get("hp"));
        }

        
        public Pokemon(
            int id,
            PokemonSpecie specie,
            string nickname,
            int level,
            params PokemonType[] types
            )
        {
            _id = id;
            _level = level;
            _nickname = nickname;
            _specie = specie;
            _types = types;
            _calculated_stats = new PokemonStats(0, 0, 0, 0, 0, 0);
            _current_stats = new PokemonStats(0, 0, 0, 0, 0, 0);
            _moves = new List<Move>();
        }

        public Pokemon(
            int id,
            PokemonSpecie specie,
            params PokemonType[] types
            )
        {
            _id = id;
            _specie = specie;
            _types = types;
        }
    }
}