using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Bidoof Species to store common natural stats of all Bidoofs
	#region SpeciesBidoof
	public class SpeciesBidoof : PokemonSpecies
	{
#nullable enable
		private static SpeciesBidoof? _instance = null;
#nullable restore
        public static SpeciesBidoof Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBidoof();
                }
                return _instance;
            }
        }

		#region SpeciesBidoof Constructor
		public SpeciesBidoof() : base(
			"Bidoof",
			0.5,
			20.0,
			59, // HPs
			45, 40, // Attack & Defense
			35, 40, // Special Attack & Defense
			31		
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
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Ice-Beam",
				"Blizzard",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Defense-Curl",
				"Swift",
				"Skull-Bash",
				"Amnesia",
				"Fury-Swipes",
				"Rest",
				"Hyper-Fang",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Taunt",
				"Superpower",
				"Yawn",
				"Secret-Power",
				"Mud-Sport",
				"Odor-Sleuth",
				"Covet",
				"Water-Sport",
				"Shock-Wave",
				"Natural-Gift",
				"Pluck",
				"Last-Resort",
				"Aqua-Tail",
				"Rock-Climb",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Bidoof PokemonInstance Class
	#region Bidoof
	public class BidoofInstance : PokemonInstance
	{
		#region Bidoof Constructors
		/// <summary>
		/// Bidoof Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BidoofInstance(string nickname, int level)
		: base(
				399,
				SpeciesBidoof.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bidoof Builder only waiting for a Level
		/// </summary>
		public BidoofInstance(int level)
		: base(
				399,
				SpeciesBidoof.Instance, // PokemonInstance Species
				"Bidoof", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bidoof Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Bidoof() : base(
			399,
			SpeciesBidoof.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}