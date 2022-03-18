using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Wooper Species to store common natural stats of all Woopers
	#region SpeciesWooper
	public class SpeciesWooper : PokemonSpecies
	{
#nullable enable
		private static SpeciesWooper? _instance = null;
#nullable restore
        public static SpeciesWooper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesWooper();
                }
                return _instance;
            }
        }

		#region SpeciesWooper Constructor
		public SpeciesWooper() : base(
			194,
			"Wooper",
			0.4,
			8.5,
			55, // HPs
			45, 45, // Attack & Defense
			25, 25, // Special Attack & Defense
			15		
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
				"Ice-Punch",
				"Slam",
				"Double-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Tail-Whip",
				"Mist",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Counter",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Recover",
				"Defense-Curl",
				"Haze",
				"Waterfall",
				"Amnesia",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Hail",
				"Facade",
				"Yawn",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Muddy-Water",
				"Mud-Shot",
				"Water-Pulse",
				"Natural-Gift",
				"Guard-Swap",
				"Aqua-Tail",
				"Earth-Power",
				"Mud-Bomb",
				"Captivate",
				"Sludge-Wave",
				"Acid-Spray",
				"After-You",
				"Round",
				"Scald",
				"Bulldoze",
				"Confide",
				"Eerie-Impulse",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Wooper PokemonInstance Class
	#region Wooper
	public class WooperInstance : PokemonInstance
	{
		#region Wooper Constructors
		/// <summary>
		/// Wooper Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WooperInstance(string nickname, int level)
		: base(
				SpeciesWooper.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wooper Builder only waiting for a Level
		/// </summary>
		public WooperInstance(int level)
		: base(
				SpeciesWooper.Instance, // PokemonInstance Species
				"Wooper", level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wooper Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public WooperInstance() : base(
			SpeciesWooper.Instance, // PokemonInstance Species
			Water.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}