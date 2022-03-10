using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Suicune Species to store common natural stats of all Suicunes
	#region SpeciesSuicune
	public class SpeciesSuicune : PokemonSpecies
	{
#nullable enable
		private static SpeciesSuicune? _instance = null;
#nullable restore
        public static SpeciesSuicune Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSuicune();
                }
                return _instance;
            }
        }

		#region SpeciesSuicune Constructor
		public SpeciesSuicune() : base(
			"Suicune",
			2.0,
			187.0,
			100, // HPs
			75, 115, // Attack & Defense
			90, 115, // Special Attack & Defense
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
				"Cut",
				"Gust",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Mist",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Aurora-Beam",
				"Hyper-Beam",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Waterfall",
				"Swift",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Detect",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Mirror-Coat",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Extrasensory",
				"Sheer-Cold",
				"Calm-Mind",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Tailwind",
				"Giga-Impact",
				"Avalanche",
				"Ice-Fang",
				"Rock-Climb",
				"Iron-Head",
				"Ominous-Wind",
				"Round",
				"Scald",
				"Quash",
				"Bulldoze",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Suicune PokemonInstance Class
	#region Suicune
	public class SuicuneInstance : PokemonInstance
	{
		#region Suicune Constructors
		/// <summary>
		/// Suicune Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SuicuneInstance(string nickname, int level)
		: base(
				245,
				SpeciesSuicune.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Suicune Builder only waiting for a Level
		/// </summary>
		public SuicuneInstance(int level)
		: base(
				245,
				SpeciesSuicune.Instance, // PokemonInstance Species
				"Suicune", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Suicune Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Suicune() : base(
			245,
			SpeciesSuicune.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}