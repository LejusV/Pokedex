using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Froakie Species to store common natural stats of all Froakies
	#region SpeciesFroakie
	public class SpeciesFroakie : PokemonSpecies
	{
#nullable enable
		private static SpeciesFroakie? _instance = null;
#nullable restore
        public static SpeciesFroakie Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFroakie();
                }
                return _instance;
            }
        }

		#region SpeciesFroakie Constructor
		public SpeciesFroakie() : base(
			"Froakie",
			0.3,
			7.0,
			41, // HPs
			56, 40, // Attack & Defense
			62, 44, // Special Attack & Defense
			71		
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
				"Cut",
				"Growl",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
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
				"Mind-Reader",
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
				"Camouflage",
				"Mud-Sport",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bounce",
				"Water-Sport",
				"Water-Pulse",
				"U-Turn",
				"Fling",
				"Toxic-Spikes",
				"Grass-Knot",
				"Smack-Down",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Acrobatics",
				"Bestow",
				"Water-Pledge",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Froakie PokemonInstance Class
	#region Froakie
	public class FroakieInstance : PokemonInstance
	{
		#region Froakie Constructors
		/// <summary>
		/// Froakie Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FroakieInstance(string nickname, int level)
		: base(
				656,
				SpeciesFroakie.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Froakie Builder only waiting for a Level
		/// </summary>
		public FroakieInstance(int level)
		: base(
				656,
				SpeciesFroakie.Instance, // PokemonInstance Species
				"Froakie", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Froakie Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Froakie() : base(
			656,
			SpeciesFroakie.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}