using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Misdreavus Species to store common natural stats of all Misdreavuss
	#region SpeciesMisdreavus
	public class SpeciesMisdreavus : PokemonSpecies
	{
#nullable enable
		private static SpeciesMisdreavus? _instance = null;
#nullable restore
        public static SpeciesMisdreavus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMisdreavus();
                }
                return _instance;
            }
        }

		#region SpeciesMisdreavus Constructor
		public SpeciesMisdreavus() : base(
			"Misdreavus",
			0.7,
			1.0,
			60, // HPs
			60, 60, // Attack & Defense
			85, 85, // Special Attack & Defense
			85		
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
				"Double-Edge",
				"Growl",
				"Psybeam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Confuse-Ray",
				"Defense-Curl",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Zap-Cannon",
				"Destiny-Bond",
				"Perish-Song",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Torment",
				"Will-O-Wisp",
				"Memento",
				"Facade",
				"Taunt",
				"Trick",
				"Magic-Coat",
				"Skill-Swap",
				"Imprison",
				"Grudge",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Astonish",
				"Aerial-Ace",
				"Calm-Mind",
				"Shock-Wave",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Me-First",
				"Sucker-Punch",
				"Dark-Pulse",
				"Power-Gem",
				"Nasty-Plot",
				"Shadow-Sneak",
				"Trick-Room",
				"Captivate",
				"Charge-Beam",
				"Ominous-Wind",
				"Wonder-Room",
				"Telekinesis",
				"Magic-Room",
				"Foul-Play",
				"Round",
				"Echoed-Voice",
				"Hex",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Misdreavus PokemonInstance Class
	#region Misdreavus
	public class MisdreavusInstance : PokemonInstance
	{
		#region Misdreavus Constructors
		/// <summary>
		/// Misdreavus Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MisdreavusInstance(string nickname, int level)
		: base(
				200,
				SpeciesMisdreavus.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Misdreavus Builder only waiting for a Level
		/// </summary>
		public MisdreavusInstance(int level)
		: base(
				200,
				SpeciesMisdreavus.Instance, // PokemonInstance Species
				"Misdreavus", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Misdreavus Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Misdreavus() : base(
			200,
			SpeciesMisdreavus.Instance, // PokemonInstance Species
			Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}