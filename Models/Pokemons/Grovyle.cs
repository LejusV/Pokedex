using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Grovyle Species to store common natural stats of all Grovyles
	#region SpeciesGrovyle
	public class SpeciesGrovyle : PokemonSpecies
	{
#nullable enable
		private static SpeciesGrovyle? _instance = null;
#nullable restore
        public static SpeciesGrovyle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGrovyle();
                }
                return _instance;
            }
        }

		#region SpeciesGrovyle Constructor
		public SpeciesGrovyle() : base(
			253,
			"Grovyle",
			0.9,
			21.6,
			50, // HPs
			65, 45, // Attack & Defense
			85, 65, // Special Attack & Defense
			95		
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
				"Mega-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Slam",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Absorb",
				"Mega-Drain",
				"Solar-Beam",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Mimic",
				"Screech",
				"Double-Team",
				"Swift",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Detect",
				"Giga-Drain",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Pursuit",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Nature-Power",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Bullet-Seed",
				"Aerial-Ace",
				"Leaf-Blade",
				"Natural-Gift",
				"Fling",
				"Worry-Seed",
				"Seed-Bomb",
				"X-Scissor",
				"Drain-Punch",
				"Energy-Ball",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Low-Sweep",
				"Round",
				"Quick-Guard",
				"Acrobatics",
				"Grass-Pledge",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Grovyle PokemonInstance Class
	#region Grovyle
	public class GrovyleInstance : PokemonInstance
	{
		#region Grovyle Constructors
		/// <summary>
		/// Grovyle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GrovyleInstance(string nickname, int level)
		: base(
				SpeciesGrovyle.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grovyle Builder only waiting for a Level
		/// </summary>
		public GrovyleInstance(int level)
		: base(
				SpeciesGrovyle.Instance, // PokemonInstance Species
				"Grovyle", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grovyle Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GrovyleInstance() : base(
			SpeciesGrovyle.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}