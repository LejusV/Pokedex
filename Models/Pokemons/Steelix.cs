using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Steelix Species to store common natural stats of all Steelixs
	#region SpeciesSteelix
	public class SpeciesSteelix : PokemonSpecies
	{
#nullable enable
		private static SpeciesSteelix? _instance = null;
#nullable restore
        public static SpeciesSteelix Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSteelix();
                }
                return _instance;
            }
        }

		#region SpeciesSteelix Constructor
		public SpeciesSteelix() : base(
			"Steelix",
			9.2,
			400.0,
			75, // HPs
			85, 200, // Attack & Defense
			55, 65, // Special Attack & Defense
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
				"Cut",
				"Bind",
				"Slam",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Roar",
				"Hyper-Beam",
				"Strength",
				"Rock-Throw",
				"Earthquake",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Harden",
				"Defense-Curl",
				"Self-Destruct",
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
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Sunny-Day",
				"Crunch",
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Secret-Power",
				"Mud-Sport",
				"Rock-Tomb",
				"Block",
				"Gyro-Ball",
				"Natural-Gift",
				"Payback",
				"Magnet-Rise",
				"Rock-Polish",
				"Dark-Pulse",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Earth-Power",
				"Giga-Impact",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Flash-Cannon",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Autotomize",
				"Smack-Down",
				"Round",
				"Bulldoze",
				"Dragon-Tail",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Steelix PokemonInstance Class
	#region Steelix
	public class SteelixInstance : PokemonInstance
	{
		#region Steelix Constructors
		/// <summary>
		/// Steelix Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SteelixInstance(string nickname, int level)
		: base(
				208,
				SpeciesSteelix.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Steelix Builder only waiting for a Level
		/// </summary>
		public SteelixInstance(int level)
		: base(
				208,
				SpeciesSteelix.Instance, // PokemonInstance Species
				"Steelix", level,
				Steel.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Steelix Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Steelix() : base(
			208,
			SpeciesSteelix.Instance, // PokemonInstance Species
			Steel.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}