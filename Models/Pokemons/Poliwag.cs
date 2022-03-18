using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Poliwag Species to store common natural stats of all Poliwags
	#region SpeciesPoliwag
	public class SpeciesPoliwag : PokemonSpecies
	{
#nullable enable
		private static SpeciesPoliwag? _instance = null;
#nullable restore
        public static SpeciesPoliwag Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPoliwag();
                }
                return _instance;
            }
        }

		#region SpeciesPoliwag Constructor
		public SpeciesPoliwag() : base(
			60,
			"Poliwag",
			0.6,
			12.4,
			40, // HPs
			50, 40, // Attack & Defense
			40, 40, // Special Attack & Defense
			90		
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
				"Double-Slap",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Mist",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Dig",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Haze",
				"Bide",
				"Waterfall",
				"Skull-Bash",
				"Amnesia",
				"Bubble",
				"Psywave",
				"Splash",
				"Rest",
				"Substitute",
				"Thief",
				"Mind-Reader",
				"Snore",
				"Curse",
				"Protect",
				"Belly-Drum",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Hidden-Power",
				"Rain-Dance",
				"Whirlpool",
				"Hail",
				"Facade",
				"Helping-Hand",
				"Endeavor",
				"Refresh",
				"Secret-Power",
				"Dive",
				"Ice-Ball",
				"Mud-Shot",
				"Water-Sport",
				"Water-Pulse",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Mud-Bomb",
				"Captivate",
				"Round",
				"Scald",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Poliwag PokemonInstance Class
	#region Poliwag
	public class PoliwagInstance : PokemonInstance
	{
		#region Poliwag Constructors
		/// <summary>
		/// Poliwag Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PoliwagInstance(string nickname, int level)
		: base(
				SpeciesPoliwag.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poliwag Builder only waiting for a Level
		/// </summary>
		public PoliwagInstance(int level)
		: base(
				SpeciesPoliwag.Instance, // PokemonInstance Species
				"Poliwag", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poliwag Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PoliwagInstance() : base(
			SpeciesPoliwag.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}