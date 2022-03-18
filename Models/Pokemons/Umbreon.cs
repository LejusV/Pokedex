using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Umbreon Species to store common natural stats of all Umbreons
	#region SpeciesUmbreon
	public class SpeciesUmbreon : PokemonSpecies
	{
#nullable enable
		private static SpeciesUmbreon? _instance = null;
#nullable restore
        public static SpeciesUmbreon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesUmbreon();
                }
                return _instance;
            }
        }

		#region SpeciesUmbreon Constructor
		public SpeciesUmbreon() : base(
			197,
			"Umbreon",
			1.0,
			27.0,
			95, // HPs
			65, 110, // Attack & Defense
			60, 130, // Special Attack & Defense
			65		
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
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Tail-Whip",
				"Hyper-Beam",
				"Dig",
				"Toxic",
				"Psychic",
				"Quick-Attack",
				"Mimic",
				"Screech",
				"Double-Team",
				"Confuse-Ray",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Endure",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Pursuit",
				"Iron-Tail",
				"Moonlight",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Torment",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Covet",
				"Natural-Gift",
				"Payback",
				"Assurance",
				"Guard-Swap",
				"Last-Resort",
				"Sucker-Punch",
				"Dark-Pulse",
				"Giga-Impact",
				"Captivate",
				"Wonder-Room",
				"Foul-Play",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Snarl",
				"Confide",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion

	//Umbreon PokemonInstance Class
	#region Umbreon
	public class UmbreonInstance : PokemonInstance
	{
		#region Umbreon Constructors
		/// <summary>
		/// Umbreon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public UmbreonInstance(string nickname, int level)
		: base(
				SpeciesUmbreon.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Umbreon Builder only waiting for a Level
		/// </summary>
		public UmbreonInstance(int level)
		: base(
				SpeciesUmbreon.Instance, // PokemonInstance Species
				"Umbreon", level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Umbreon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public UmbreonInstance() : base(
			SpeciesUmbreon.Instance, // PokemonInstance Species
			Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}