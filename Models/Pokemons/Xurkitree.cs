using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Xurkitree Species to store common natural stats of all Xurkitrees
	#region SpeciesXurkitree
	public class SpeciesXurkitree : PokemonSpecies
	{
#nullable enable
		private static SpeciesXurkitree? _instance = null;
#nullable restore
        public static SpeciesXurkitree Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesXurkitree();
                }
                return _instance;
            }
        }

		#region SpeciesXurkitree Constructor
		public SpeciesXurkitree() : base(
			"Xurkitree",
			3.8,
			100.0,
			83, // HPs
			89, 71, // Attack & Defense
			173, 71, // Special Attack & Defense
			83		
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Thunder-Punch",
				"Wrap",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Hypnosis",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Rest",
				"Substitute",
				"Protect",
				"Zap-Cannon",
				"Swagger",
				"Spark",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Charge",
				"Ingrain",
				"Tail-Glow",
				"Signal-Beam",
				"Calm-Mind",
				"Shock-Wave",
				"Fling",
				"Energy-Ball",
				"Giga-Impact",
				"Discharge",
				"Power-Whip",
				"Grass-Knot",
				"Charge-Beam",
				"Round",
				"Volt-Switch",
				"Wild-Charge",
				"Ion-Deluge",
				"Confide",
				"Eerie-Impulse",
				"Electric-Terrain",
				"Dazzling-Gleam",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Xurkitree PokemonInstance Class
	#region Xurkitree
	public class XurkitreeInstance : PokemonInstance
	{
		#region Xurkitree Constructors
		/// <summary>
		/// Xurkitree Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public XurkitreeInstance(string nickname, int level)
		: base(
				796,
				SpeciesXurkitree.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Xurkitree Builder only waiting for a Level
		/// </summary>
		public XurkitreeInstance(int level)
		: base(
				796,
				SpeciesXurkitree.Instance, // PokemonInstance Species
				"Xurkitree", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Xurkitree Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Xurkitree() : base(
			796,
			SpeciesXurkitree.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}