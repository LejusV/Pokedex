using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Onix Species to store common natural stats of all Onixs
	#region SpeciesOnix
	public class SpeciesOnix : PokemonSpecies
	{
#nullable enable
		private static SpeciesOnix? _instance = null;
#nullable restore
        public static SpeciesOnix Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesOnix();
                }
                return _instance;
            }
        }

		#region SpeciesOnix Constructor
		public SpeciesOnix() : base(
			"Onix",
			8.8,
			210.0,
			35, // HPs
			45, 160, // Attack & Defense
			30, 45, // Special Attack & Defense
			70		
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
				"Bind",
				"Slam",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Roar",
				"Strength",
				"Rock-Throw",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Harden",
				"Defense-Curl",
				"Bide",
				"Self-Destruct",
				"Skull-Bash",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
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
				"Sand-Tomb",
				"Block",
				"Rock-Blast",
				"Gyro-Ball",
				"Natural-Gift",
				"Payback",
				"Rock-Polish",
				"Dragon-Pulse",
				"Earth-Power",
				"Flash-Cannon",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Wide-Guard",
				"Smack-Down",
				"Heavy-Slam",
				"Round",
				"Bulldoze",
				"Dragon-Tail",
				"Rototiller",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Onix PokemonInstance Class
	#region Onix
	public class OnixInstance : PokemonInstance
	{
		#region Onix Constructors
		/// <summary>
		/// Onix Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public OnixInstance(string nickname, int level)
		: base(
				95,
				SpeciesOnix.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Onix Builder only waiting for a Level
		/// </summary>
		public OnixInstance(int level)
		: base(
				95,
				SpeciesOnix.Instance, // PokemonInstance Species
				"Onix", level,
				Rock.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Onix Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Onix() : base(
			95,
			SpeciesOnix.Instance, // PokemonInstance Species
			Rock.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}