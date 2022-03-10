using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Manaphy Species to store common natural stats of all Manaphys
	#region SpeciesManaphy
	public class SpeciesManaphy : PokemonSpecies
	{
#nullable enable
		private static SpeciesManaphy? _instance = null;
#nullable restore
        public static SpeciesManaphy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesManaphy();
                }
                return _instance;
            }
        }

		#region SpeciesManaphy Constructor
		public SpeciesManaphy() : base(
			"Manaphy",
			0.3,
			1.4,
			100, // HPs
			100, 100, // Attack & Defense
			100, 100, // Special Attack & Defense
			100		
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
				"Supersonic",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Waterfall",
				"Swift",
				"Bubble",
				"Flash",
				"Acid-Armor",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Charm",
				"Swagger",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Facade",
				"Helping-Hand",
				"Knock-Off",
				"Skill-Swap",
				"Secret-Power",
				"Dive",
				"Tail-Glow",
				"Signal-Beam",
				"Bounce",
				"Covet",
				"Water-Sport",
				"Calm-Mind",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"U-Turn",
				"Fling",
				"Last-Resort",
				"Heart-Swap",
				"Aqua-Ring",
				"Energy-Ball",
				"Giga-Impact",
				"Grass-Knot",
				"Round",
				"Scald",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Manaphy PokemonInstance Class
	#region Manaphy
	public class ManaphyInstance : PokemonInstance
	{
		#region Manaphy Constructors
		/// <summary>
		/// Manaphy Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ManaphyInstance(string nickname, int level)
		: base(
				490,
				SpeciesManaphy.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Manaphy Builder only waiting for a Level
		/// </summary>
		public ManaphyInstance(int level)
		: base(
				490,
				SpeciesManaphy.Instance, // PokemonInstance Species
				"Manaphy", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Manaphy Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Manaphy() : base(
			490,
			SpeciesManaphy.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}