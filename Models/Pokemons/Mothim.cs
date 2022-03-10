using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Mothim Species to store common natural stats of all Mothims
	#region SpeciesMothim
	public class SpeciesMothim : PokemonSpecies
	{
#nullable enable
		private static SpeciesMothim? _instance = null;
#nullable restore
        public static SpeciesMothim Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMothim();
                }
                return _instance;
            }
        }

		#region SpeciesMothim Constructor
		public SpeciesMothim() : base(
			"Mothim",
			0.9,
			23.3,
			70, // HPs
			94, 50, // Attack & Defense
			94, 50, // Special Attack & Defense
			66		
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
				"Tackle",
				"Psybeam",
				"Hyper-Beam",
				"Solar-Beam",
				"Poison-Powder",
				"String-Shot",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Facade",
				"Skill-Swap",
				"Secret-Power",
				"Camouflage",
				"Air-Cutter",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Air-Slash",
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
				"Infestation",
				"Lunge"
			};
		}
		#endregion
	}
	#endregion

	//Mothim PokemonInstance Class
	#region Mothim
	public class MothimInstance : PokemonInstance
	{
		#region Mothim Constructors
		/// <summary>
		/// Mothim Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MothimInstance(string nickname, int level)
		: base(
				414,
				SpeciesMothim.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mothim Builder only waiting for a Level
		/// </summary>
		public MothimInstance(int level)
		: base(
				414,
				SpeciesMothim.Instance, // PokemonInstance Species
				"Mothim", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mothim Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Mothim() : base(
			414,
			SpeciesMothim.Instance, // PokemonInstance Species
			Bug.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}