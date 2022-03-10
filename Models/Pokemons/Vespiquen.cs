using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Vespiquen Species to store common natural stats of all Vespiquens
	#region SpeciesVespiquen
	public class SpeciesVespiquen : PokemonSpecies
	{
#nullable enable
		private static SpeciesVespiquen? _instance = null;
#nullable restore
        public static SpeciesVespiquen Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesVespiquen();
                }
                return _instance;
            }
        }

		#region SpeciesVespiquen Constructor
		public SpeciesVespiquen() : base(
			"Vespiquen",
			1.2,
			38.5,
			70, // HPs
			80, 102, // Attack & Defense
			80, 102, // Special Attack & Defense
			40		
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
				"Poison-Sting",
				"Hyper-Beam",
				"String-Shot",
				"Toxic",
				"Double-Team",
				"Confuse-Ray",
				"Swift",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Destiny-Bond",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Sweet-Scent",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Facade",
				"Endeavor",
				"Secret-Power",
				"Air-Cutter",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Fling",
				"Air-Slash",
				"X-Scissor",
				"Power-Gem",
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Bug-Bite",
				"Attack-Order",
				"Defend-Order",
				"Heal-Order",
				"Ominous-Wind",
				"Hone-Claws",
				"Venoshock",
				"Round",
				"Quash",
				"Acrobatics",
				"Struggle-Bug",
				"Fell-Stinger",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Vespiquen PokemonInstance Class
	#region Vespiquen
	public class VespiquenInstance : PokemonInstance
	{
		#region Vespiquen Constructors
		/// <summary>
		/// Vespiquen Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public VespiquenInstance(string nickname, int level)
		: base(
				416,
				SpeciesVespiquen.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vespiquen Builder only waiting for a Level
		/// </summary>
		public VespiquenInstance(int level)
		: base(
				416,
				SpeciesVespiquen.Instance, // PokemonInstance Species
				"Vespiquen", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vespiquen Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Vespiquen() : base(
			416,
			SpeciesVespiquen.Instance, // PokemonInstance Species
			Bug.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}