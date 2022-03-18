using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Dustox Species to store common natural stats of all Dustoxs
	#region SpeciesDustox
	public class SpeciesDustox : PokemonSpecies
	{
#nullable enable
		private static SpeciesDustox? _instance = null;
#nullable restore
        public static SpeciesDustox Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDustox();
                }
                return _instance;
            }
        }

		#region SpeciesDustox Constructor
		public SpeciesDustox() : base(
			269,
			"Dustox",
			1.2,
			31.6,
			60, // HPs
			50, 70, // Attack & Defense
			50, 90, // Special Attack & Defense
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
				"Gust",
				"Whirlwind",
				"Double-Edge",
				"Psybeam",
				"Hyper-Beam",
				"Solar-Beam",
				"Poison-Powder",
				"String-Shot",
				"Toxic",
				"Confusion",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Moonlight",
				"Hidden-Power",
				"Twister",
				"Sunny-Day",
				"Shadow-Ball",
				"Facade",
				"Secret-Power",
				"Air-Cutter",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Bug-Buzz",
				"Energy-Ball",
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Bug-Bite",
				"Ominous-Wind",
				"Venoshock",
				"Quiver-Dance",
				"Round",
				"Acrobatics",
				"Struggle-Bug",
				"Electroweb",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Dustox PokemonInstance Class
	#region Dustox
	public class DustoxInstance : PokemonInstance
	{
		#region Dustox Constructors
		/// <summary>
		/// Dustox Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DustoxInstance(string nickname, int level)
		: base(
				SpeciesDustox.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dustox Builder only waiting for a Level
		/// </summary>
		public DustoxInstance(int level)
		: base(
				SpeciesDustox.Instance, // PokemonInstance Species
				"Dustox", level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dustox Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DustoxInstance() : base(
			SpeciesDustox.Instance, // PokemonInstance Species
			Bug.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}