using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Cutiefly Species to store common natural stats of all Cutieflys
	#region SpeciesCutiefly
	public class SpeciesCutiefly : PokemonSpecies
	{
#nullable enable
		private static SpeciesCutiefly? _instance = null;
#nullable restore
        public static SpeciesCutiefly Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCutiefly();
                }
                return _instance;
            }
        }

		#region SpeciesCutiefly Constructor
		public SpeciesCutiefly() : base(
			"Cutiefly",
			0.1,
			0.2,
			40, // HPs
			45, 40, // Attack & Defense
			55, 40, // Special Attack & Defense
			84		
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
				"Absorb",
				"Stun-Spore",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Leech-Life",
				"Rest",
				"Substitute",
				"Thief",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Baton-Pass",
				"Sweet-Scent",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Facade",
				"Skill-Swap",
				"Aromatherapy",
				"Silver-Wind",
				"Aerial-Ace",
				"Calm-Mind",
				"Roost",
				"U-Turn",
				"Bug-Buzz",
				"Energy-Ball",
				"Quiver-Dance",
				"Round",
				"Acrobatics",
				"Bestow",
				"Struggle-Bug",
				"Sticky-Web",
				"Draining-Kiss",
				"Fairy-Wind",
				"Moonblast",
				"Confide",
				"Powder",
				"Dazzling-Gleam",
				"Infestation",
				"Speed-Swap"
			};
		}
		#endregion
	}
	#endregion

	//Cutiefly PokemonInstance Class
	#region Cutiefly
	public class CutieflyInstance : PokemonInstance
	{
		#region Cutiefly Constructors
		/// <summary>
		/// Cutiefly Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CutieflyInstance(string nickname, int level)
		: base(
				742,
				SpeciesCutiefly.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cutiefly Builder only waiting for a Level
		/// </summary>
		public CutieflyInstance(int level)
		: base(
				742,
				SpeciesCutiefly.Instance, // PokemonInstance Species
				"Cutiefly", level,
				Bug.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cutiefly Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Cutiefly() : base(
			742,
			SpeciesCutiefly.Instance, // PokemonInstance Species
			Bug.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}