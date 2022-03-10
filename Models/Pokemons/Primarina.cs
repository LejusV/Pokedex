using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Primarina Species to store common natural stats of all Primarinas
	#region SpeciesPrimarina
	public class SpeciesPrimarina : PokemonSpecies
	{
#nullable enable
		private static SpeciesPrimarina? _instance = null;
#nullable restore
        public static SpeciesPrimarina Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPrimarina();
                }
                return _instance;
            }
        }

		#region SpeciesPrimarina Constructor
		public SpeciesPrimarina() : base(
			"Primarina",
			1.8,
			44.0,
			80, // HPs
			74, 74, // Attack & Defense
			126, 116, // Special Attack & Defense
			60		
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
				"Pound",
				"Double-Slap",
				"Growl",
				"Sing",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Waterfall",
				"Rest",
				"Substitute",
				"Protect",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Hail",
				"Facade",
				"Hyper-Voice",
				"Hydro-Cannon",
				"Energy-Ball",
				"Giga-Impact",
				"Captivate",
				"Aqua-Jet",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Acrobatics",
				"Water-Pledge",
				"Work-Up",
				"Disarming-Voice",
				"Misty-Terrain",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam",
				"Baby-Doll-Eyes",
				"Sparkling-Aria"
			};
		}
		#endregion
	}
	#endregion

	//Primarina PokemonInstance Class
	#region Primarina
	public class PrimarinaInstance : PokemonInstance
	{
		#region Primarina Constructors
		/// <summary>
		/// Primarina Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PrimarinaInstance(string nickname, int level)
		: base(
				730,
				SpeciesPrimarina.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Primarina Builder only waiting for a Level
		/// </summary>
		public PrimarinaInstance(int level)
		: base(
				730,
				SpeciesPrimarina.Instance, // PokemonInstance Species
				"Primarina", level,
				Water.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Primarina Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Primarina() : base(
			730,
			SpeciesPrimarina.Instance, // PokemonInstance Species
			Water.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}