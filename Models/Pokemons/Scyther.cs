using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Scyther Species to store common natural stats of all Scythers
	#region SpeciesScyther
	public class SpeciesScyther : PokemonSpecies
	{
#nullable enable
		private static SpeciesScyther? _instance = null;
#nullable restore
        public static SpeciesScyther Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesScyther();
                }
                return _instance;
            }
        }

		#region SpeciesScyther Constructor
		public SpeciesScyther() : base(
			"Scyther",
			1.5,
			56.0,
			70, // HPs
			110, 80, // Attack & Defense
			55, 80, // Special Attack & Defense
			105		
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
				"Razor-Wind",
				"Swords-Dance",
				"Cut",
				"Wing-Attack",
				"Headbutt",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Hyper-Beam",
				"Counter",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Focus-Energy",
				"Bide",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Reversal",
				"Protect",
				"Detect",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Baton-Pass",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Silver-Wind",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Feint",
				"Tailwind",
				"U-Turn",
				"Night-Slash",
				"Air-Slash",
				"X-Scissor",
				"Bug-Buzz",
				"Vacuum-Wave",
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Bug-Bite",
				"Double-Hit",
				"Ominous-Wind",
				"Round",
				"Quick-Guard",
				"Struggle-Bug",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Scyther PokemonInstance Class
	#region Scyther
	public class ScytherInstance : PokemonInstance
	{
		#region Scyther Constructors
		/// <summary>
		/// Scyther Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ScytherInstance(string nickname, int level)
		: base(
				123,
				SpeciesScyther.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scyther Builder only waiting for a Level
		/// </summary>
		public ScytherInstance(int level)
		: base(
				123,
				SpeciesScyther.Instance, // PokemonInstance Species
				"Scyther", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scyther Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Scyther() : base(
			123,
			SpeciesScyther.Instance, // PokemonInstance Species
			Bug.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}