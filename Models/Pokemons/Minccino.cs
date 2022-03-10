using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Minccino Species to store common natural stats of all Minccinos
	#region SpeciesMinccino
	public class SpeciesMinccino : PokemonSpecies
	{
#nullable enable
		private static SpeciesMinccino? _instance = null;
#nullable restore
        public static SpeciesMinccino Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMinccino();
                }
                return _instance;
            }
        }

		#region SpeciesMinccino Constructor
		public SpeciesMinccino() : base(
			"Minccino",
			0.4,
			5.8,
			55, // HPs
			50, 40, // Attack & Defense
			40, 40, // Special Attack & Defense
			75		
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
				"Pound",
				"Double-Slap",
				"Slam",
				"Tail-Whip",
				"Growl",
				"Sing",
				"Thunderbolt",
				"Thunder-Wave",
				"Dig",
				"Toxic",
				"Double-Team",
				"Swift",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Uproar",
				"Facade",
				"Helping-Hand",
				"Knock-Off",
				"Secret-Power",
				"Hyper-Voice",
				"Fake-Tears",
				"Tickle",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Wake-Up-Slap",
				"U-Turn",
				"Fling",
				"Last-Resort",
				"Aqua-Tail",
				"Seed-Bomb",
				"Gunk-Shot",
				"Captivate",
				"Grass-Knot",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Tail-Slap",
				"Confide",
				"Dazzling-Gleam",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion

	//Minccino PokemonInstance Class
	#region Minccino
	public class MinccinoInstance : PokemonInstance
	{
		#region Minccino Constructors
		/// <summary>
		/// Minccino Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MinccinoInstance(string nickname, int level)
		: base(
				572,
				SpeciesMinccino.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Minccino Builder only waiting for a Level
		/// </summary>
		public MinccinoInstance(int level)
		: base(
				572,
				SpeciesMinccino.Instance, // PokemonInstance Species
				"Minccino", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Minccino Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Minccino() : base(
			572,
			SpeciesMinccino.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}