using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Frogadier Species to store common natural stats of all Frogadiers
	#region SpeciesFrogadier
	public class SpeciesFrogadier : PokemonSpecies
	{
#nullable enable
		private static SpeciesFrogadier? _instance = null;
#nullable restore
        public static SpeciesFrogadier Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFrogadier();
                }
                return _instance;
            }
        }

		#region SpeciesFrogadier Constructor
		public SpeciesFrogadier() : base(
			"Frogadier",
			0.6,
			10.9,
			54, // HPs
			63, 52, // Attack & Defense
			83, 56, // Special Attack & Defense
			97		
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
				"Ice-Punch",
				"Cut",
				"Growl",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Low-Kick",
				"Strength",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Smokescreen",
				"Lick",
				"Waterfall",
				"Bubble",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Facade",
				"Taunt",
				"Role-Play",
				"Snatch",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bounce",
				"Water-Pulse",
				"U-Turn",
				"Fling",
				"Dark-Pulse",
				"Gunk-Shot",
				"Grass-Knot",
				"Smack-Down",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Acrobatics",
				"Water-Pledge",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Frogadier PokemonInstance Class
	#region Frogadier
	public class FrogadierInstance : PokemonInstance
	{
		#region Frogadier Constructors
		/// <summary>
		/// Frogadier Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FrogadierInstance(string nickname, int level)
		: base(
				657,
				SpeciesFrogadier.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Frogadier Builder only waiting for a Level
		/// </summary>
		public FrogadierInstance(int level)
		: base(
				657,
				SpeciesFrogadier.Instance, // PokemonInstance Species
				"Frogadier", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Frogadier Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Frogadier() : base(
			657,
			SpeciesFrogadier.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}