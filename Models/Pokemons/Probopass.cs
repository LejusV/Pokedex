using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Probopass Species to store common natural stats of all Probopasss
	#region SpeciesProbopass
	public class SpeciesProbopass : PokemonSpecies
	{
#nullable enable
		private static SpeciesProbopass? _instance = null;
#nullable restore
        public static SpeciesProbopass Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesProbopass();
                }
                return _instance;
            }
        }

		#region SpeciesProbopass Constructor
		public SpeciesProbopass() : base(
			476,
			"Probopass",
			1.4,
			340.0,
			60, // HPs
			55, 145, // Attack & Defense
			75, 150, // Special Attack & Defense
			40		
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Headbutt",
				"Tackle",
				"Hyper-Beam",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Tri-Attack",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Lock-On",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Taunt",
				"Magic-Coat",
				"Secret-Power",
				"Rock-Tomb",
				"Iron-Defense",
				"Block",
				"Rock-Blast",
				"Shock-Wave",
				"Gravity",
				"Natural-Gift",
				"Magnet-Rise",
				"Rock-Polish",
				"Power-Gem",
				"Earth-Power",
				"Giga-Impact",
				"Flash-Cannon",
				"Discharge",
				"Iron-Head",
				"Magnet-Bomb",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Wide-Guard",
				"Smack-Down",
				"Round",
				"Volt-Switch",
				"Bulldoze",
				"Confide",
				"Magnetic-Flux",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Probopass PokemonInstance Class
	#region Probopass
	public class ProbopassInstance : PokemonInstance
	{
		#region Probopass Constructors
		/// <summary>
		/// Probopass Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ProbopassInstance(string nickname, int level)
		: base(
				SpeciesProbopass.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Probopass Builder only waiting for a Level
		/// </summary>
		public ProbopassInstance(int level)
		: base(
				SpeciesProbopass.Instance, // PokemonInstance Species
				"Probopass", level,
				Rock.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Probopass Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ProbopassInstance() : base(
			SpeciesProbopass.Instance, // PokemonInstance Species
			Rock.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}