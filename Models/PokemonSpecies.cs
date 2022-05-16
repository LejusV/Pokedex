using System.Collections.Generic;

namespace Pokedex.Models
{
    public abstract class PokemonSpecies
    {
        //private readonly string _genus;
        // private readonly double _height;
        // protected List<string> MoveList;
        // private readonly string _name;
        // private readonly PokemonStats _stats;
        
        // private readonly double _weight;


        public int Generation
        {
            get
            {
                if (this.Id > 0)
                {
                    switch (this.Id)
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

        public int Id { get; } // ID of the pokemon species in the pokedex

        public PokemonType Type1 { get; } // Type N°1 of the Species
        public PokemonType? Type2 { get; } = null; // Type N°2 of the Species

        public double Height { get;}

        public string Name { get;}

        public PokemonStats Stats { get; }

        public double Weight { get; }
        
        public List<string> MoveList { get; protected set; }
        
        #region Types Getter
        /// <summary>
        /// Types Getter
        /// </summary>
        /// <returns>Returns the Types tuple</returns>
        
        public (PokemonType, PokemonType?) Types => (this.Type1, this.Type2);
        
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
                if (Type2 != null)
                    return $"{this.Type1} Type";
                else
                    return $"{this.Type1} - {this.Type2} Types";
            }
        }
        #endregion

        
        public PokemonSpecies(int id, string name, PokemonType type1, PokemonType? types2, double height, double weight, PokemonStats stats)
        
        {
            Id = id; // store species id
            Height = height; // store species height
            MoveList = new List<string>(); // store species moves
            Name = name; // store species name
            Stats = stats; // store a PokemonStats instance which is a Dictionnary<string, int>()
                            //{ {"HP", hp}, {"ATK", atk}, {"DEF", def}, {"SP_ATK", sp_atk}, {"SP_DEF", sp_def}, {"SPEED", speed} }
            Type1 = type1;
            Type2 = types2;
            Weight = weight;
        }

        public PokemonSpecies(int id, string name, PokemonType type1, double height, double weight, PokemonStats stats)
        : this(id, name, type1, null, height, weight, stats)
        { }

    }
}