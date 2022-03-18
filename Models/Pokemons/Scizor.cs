using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Scizor Species to store common natural stats of all Scizors
	#region SpeciesScizor
	public class SpeciesScizor : PokemonSpecies
	{
#nullable enable
		private static SpeciesScizor? _instance = null;
#nullable restore
        public static SpeciesScizor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesScizor();
                }
                return _instance;
            }
        }

		#region SpeciesScizor Constructor
		public SpeciesScizor() : base(
			212,
			"Scizor",
			1.8,
			118.0,
			70, // HPs
			130, 100, // Attack & Defense
			55, 80, // Special Attack & Defense
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
				"Razor-Wind",
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Double-Edge",
				"Leer",
				"Hyper-Beam",
				"Counter",
				"Strength",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Focus-Energy",
				"Swift",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Detect",
				"Sandstorm",
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
				"Pursuit",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Silver-Wind",
				"Aerial-Ace",
				"Iron-Defense",
				"Roost",
				"Natural-Gift",
				"Feint",
				"Tailwind",
				"U-Turn",
				"Fling",
				"Night-Slash",
				"X-Scissor",
				"Giga-Impact",
				"Bullet-Punch",
				"Flash-Cannon",
				"Defog",
				"Iron-Head",
				"Captivate",
				"Bug-Bite",
				"Double-Hit",
				"Ominous-Wind",
				"Venoshock",
				"Round",
				"Acrobatics",
				"Struggle-Bug",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Scizor PokemonInstance Class
	#region Scizor
	public class ScizorInstance : PokemonInstance
	{
		#region Scizor Constructors
		/// <summary>
		/// Scizor Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ScizorInstance(string nickname, int level)
		: base(
				SpeciesScizor.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scizor Builder only waiting for a Level
		/// </summary>
		public ScizorInstance(int level)
		: base(
				SpeciesScizor.Instance, // PokemonInstance Species
				"Scizor", level,
				Bug.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scizor Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ScizorInstance() : base(
			SpeciesScizor.Instance, // PokemonInstance Species
			Bug.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}