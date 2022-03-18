using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Swampert Species to store common natural stats of all Swamperts
	#region SpeciesSwampert
	public class SpeciesSwampert : PokemonSpecies
	{
#nullable enable
		private static SpeciesSwampert? _instance = null;
#nullable restore
        public static SpeciesSwampert Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSwampert();
                }
                return _instance;
            }
        }

		#region SpeciesSwampert Constructor
		public SpeciesSwampert() : base(
			260,
			"Swampert",
			1.5,
			81.9,
			100, // HPs
			110, 90, // Attack & Defense
			85, 90, // Special Attack & Defense
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
				"Mega-Punch",
				"Ice-Punch",
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Roar",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Bide",
				"Waterfall",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Icy-Wind",
				"Outrage",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Hydro-Cannon",
				"Rock-Tomb",
				"Muddy-Water",
				"Mud-Shot",
				"Water-Pulse",
				"Hammer-Arm",
				"Natural-Gift",
				"Fling",
				"Aqua-Tail",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Avalanche",
				"Mud-Bomb",
				"Rock-Climb",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Sludge-Wave",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Water-Pledge",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Swampert PokemonInstance Class
	#region Swampert
	public class SwampertInstance : PokemonInstance
	{
		#region Swampert Constructors
		/// <summary>
		/// Swampert Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SwampertInstance(string nickname, int level)
		: base(
				SpeciesSwampert.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swampert Builder only waiting for a Level
		/// </summary>
		public SwampertInstance(int level)
		: base(
				SpeciesSwampert.Instance, // PokemonInstance Species
				"Swampert", level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swampert Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SwampertInstance() : base(
			SpeciesSwampert.Instance, // PokemonInstance Species
			Water.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}