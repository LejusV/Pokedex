using System.Collections.Generic;
using System.Text;
using Pokedex.Enums;

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

        #region ToString Functions
        public string Status
        {
            get
            {
                StringBuilder output = new StringBuilder();
                    output.AppendLine($"  Specie Attributes :");
                    output.AppendLine("");
                    output.AppendLine($"    Morphology :");
                    output.AppendLine($"      Height {string.Format("{0:0.0}",this.Height), 5}m");
                    output.AppendLine($"      Weight {string.Format("{0:0.0}",this.Weight), 5}kg");
                    output.AppendLine("");
                    output.AppendLine($"    Stats : ");
                    output.Append($"      HP     {this.Stats.Get(Stat.HP), 3}  ");
                    output.AppendLine($"SPEED  {this.Stats.Get(Stat.SPEED), 3}");
                    output.Append($"      ATK    {this.Stats.Get(Stat.ATK), 3}  ");
                    output.AppendLine($"DEF    {this.Stats.Get(Stat.DEF), 3}");
                    output.Append($"      SP_ATK {this.Stats.Get(Stat.SP_ATK), 3}  ");
                    output.AppendLine($"SP_DEF {this.Stats.Get(Stat.SP_DEF), 3}");

                    return output.ToString();
            }
        }
        /// <summary>
        /// Types Display
        /// </summary>
        /// <returns>Returns the formated Types string</returns>
        public string TypesString
        {
            get
            {
                if (Type2 is not null)
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
                            //{ {Stat.HP, hp}, {Stat.ATK, atk}, {Stat.DEF, def}, {Stat.SP_ATK, sp_atk}, {Stat.SP_DEF, sp_def}, {Stat.SPEED, speed} }
            Type1 = type1;
            Type2 = types2;
            Weight = weight;
        }

        public PokemonSpecies(int id, string name, PokemonType type1, double height, double weight, PokemonStats stats)
        : this(id, name, type1, null, height, weight, stats)
        { }

    }
}