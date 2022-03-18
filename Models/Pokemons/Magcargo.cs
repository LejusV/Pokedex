using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Magcargo Species to store common natural stats of all Magcargos
	#region SpeciesMagcargo
	public class SpeciesMagcargo : PokemonSpecies
	{
#nullable enable
		private static SpeciesMagcargo? _instance = null;
#nullable restore
        public static SpeciesMagcargo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMagcargo();
                }
                return _instance;
            }
        }

		#region SpeciesMagcargo Constructor
		public SpeciesMagcargo() : base(
			219,
			"Magcargo",
			0.8,
			55.0,
			60, // HPs
			50, 120, // Attack & Defense
			90, 80, // Special Attack & Defense
			30		
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
				"Body-Slam",
				"Double-Edge",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Rock-Throw",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Recover",
				"Harden",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Self-Destruct",
				"Smog",
				"Fire-Blast",
				"Amnesia",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Nature-Power",
				"Yawn",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Iron-Defense",
				"Gyro-Ball",
				"Natural-Gift",
				"Rock-Polish",
				"Earth-Power",
				"Giga-Impact",
				"Lava-Plume",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Smack-Down",
				"Flame-Burst",
				"Flame-Charge",
				"After-You",
				"Round",
				"Clear-Smog",
				"Shell-Smash",
				"Incinerate",
				"Bulldoze",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Magcargo PokemonInstance Class
	#region Magcargo
	public class MagcargoInstance : PokemonInstance
	{
		#region Magcargo Constructors
		/// <summary>
		/// Magcargo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MagcargoInstance(string nickname, int level)
		: base(
				SpeciesMagcargo.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magcargo Builder only waiting for a Level
		/// </summary>
		public MagcargoInstance(int level)
		: base(
				SpeciesMagcargo.Instance, // PokemonInstance Species
				"Magcargo", level,
				Fire.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magcargo Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MagcargoInstance() : base(
			SpeciesMagcargo.Instance, // PokemonInstance Species
			Fire.Instance, Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}