using System.Collections.Generic;

namespace Pokedex.Models
{
    public abstract class PokemonSpecies
    {
        private readonly int _id; // ID of the pokemon species in the pokedex

        //private readonly string _genus;
        private readonly double _height;
        protected List<string> _moveList;
        private readonly string _name;
        private readonly PokemonStats _stats;
        protected PokemonType _type1; // Type N°1 of the Species (required)
        #nullable enable
        protected PokemonType? _type2 = null; // Type N°2 of the Species (optional)
        #nullable restore
        private readonly double _weight;


        public int Generation
        {
            get
            {
                if (this._id > 0)
                {
                    switch (this._id)
                    {
                        case <= 151:
                            return 1;
                        case <= 251:
                            return 2;
                        case <= 386:
                            return 3;
                        case <= 493:
                            return 4;
                        case <= 649:
                            return 5;
                        case <= 721:
                            return 6;
                        case <= 809:
                            return 7;
                        case <= 898:
                            return 8;
                        default:
                            return 0;
                    }
                }
                else return -1;
            }
        }

        //public string Genus => _genus;

        public int Id => this._id;

        public double Height => _height;

        public string Name => _name;

        public PokemonStats Stats => _stats;

        public double Weight => _weight;
        
        public List<string> MoveList => _moveList;
        
        #region Types Getter
        /// <summary>
        /// Types Getter
        /// </summary>
        /// <returns>Returns the Types tuple</returns>
        #nullable enable
        public (PokemonType, PokemonType?) Types => (this._type1, this._type2);
        #nullable restore
        #endregion

        #region Types ToString
        /// <summary>
        /// Types Display
        /// </summary>
        /// <returns>Returns the formated Types string</returns>
        public string TypesString
        {
            get
            {
                if (_type2 != null)
                    return $"{this._type1} Type";
                else
                    return $"{this._type1} - {this._type2} Types";
            }
        }
        #endregion

        #nullable enable
        public PokemonSpecies(int id, string name, PokemonType type1, PokemonType? types2, double height, double weight, PokemonStats stats)
        #nullable restore
        {
            _id = id; // store species id
            _height = height; // store species height
            _name = name; // store species name
            _stats = stats; // store a PokemonStats instance which is a Dictionnary<string, int>()
                            //{ {"HP", hp}, {"ATK", atk}, {"DEF", def}, {"SP_ATK", sp_atk}, {"SP_DEF", sp_def}, {"SPEED", speed} }
            _type1 = type1;
            _type2 = types2;
            _weight = weight;
        }

        public PokemonSpecies(int id, string name, PokemonType type1, double height, double weight, PokemonStats stats)
        : this(id, name, type1, null, height, weight, stats)
        { }

    }
}