using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Relicanth Species to store common natural stats of all Relicanths
	#region SpeciesRelicanth
	public class SpeciesRelicanth : PokemonSpecies
	{
#nullable enable
		private static SpeciesRelicanth? _instance = null;
#nullable restore
        public static SpeciesRelicanth Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRelicanth();
                }
                return _instance;
            }
        }

		#region SpeciesRelicanth Constructor
		public SpeciesRelicanth() : base(
			"Relicanth",
			1.0,
			23.4,
			100, // HPs
			90, 130, // Attack & Defense
			45, 65, // Special Attack & Defense
			55		
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
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Waterfall",
				"Skull-Bash",
				"Amnesia",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Magnitude",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Yawn",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Rock-Tomb",
				"Muddy-Water",
				"Bounce",
				"Mud-Shot",
				"Water-Sport",
				"Calm-Mind",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Rock-Polish",
				"Aqua-Tail",
				"Earth-Power",
				"Giga-Impact",
				"Zen-Headbutt",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Head-Smash",
				"Smack-Down",
				"Round",
				"Scald",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Relicanth PokemonInstance Class
	#region Relicanth
	public class RelicanthInstance : PokemonInstance
	{
		#region Relicanth Constructors
		/// <summary>
		/// Relicanth Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RelicanthInstance(string nickname, int level)
		: base(
				369,
				SpeciesRelicanth.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Relicanth Builder only waiting for a Level
		/// </summary>
		public RelicanthInstance(int level)
		: base(
				369,
				SpeciesRelicanth.Instance, // PokemonInstance Species
				"Relicanth", level,
				Water.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Relicanth Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Relicanth() : base(
			369,
			SpeciesRelicanth.Instance, // PokemonInstance Species
			Water.Instance, Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}