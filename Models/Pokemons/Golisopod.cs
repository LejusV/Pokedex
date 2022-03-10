using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Golisopod Species to store common natural stats of all Golisopods
	#region SpeciesGolisopod
	public class SpeciesGolisopod : PokemonSpecies
	{
#nullable enable
		private static SpeciesGolisopod? _instance = null;
#nullable restore
        public static SpeciesGolisopod Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGolisopod();
                }
                return _instance;
            }
        }

		#region SpeciesGolisopod Constructor
		public SpeciesGolisopod() : base(
			"Golisopod",
			2.0,
			108.0,
			75, // HPs
			125, 140, // Attack & Defense
			60, 90, // Special Attack & Defense
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
				"Swords-Dance",
				"Sand-Attack",
				"Pin-Missile",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Toxic",
				"Double-Team",
				"Waterfall",
				"Leech-Life",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Spite",
				"Protect",
				"Sludge-Bomb",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Taunt",
				"Brick-Break",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Bulk-Up",
				"Payback",
				"Fling",
				"Sucker-Punch",
				"Poison-Jab",
				"Dark-Pulse",
				"X-Scissor",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Bug-Bite",
				"Venoshock",
				"Sludge-Wave",
				"Round",
				"Scald",
				"Struggle-Bug",
				"Frost-Breath",
				"Razor-Shell",
				"Snarl",
				"Confide",
				"First-Impression",
				"Liquidation"
			};
		}
		#endregion
	}
	#endregion

	//Golisopod PokemonInstance Class
	#region Golisopod
	public class GolisopodInstance : PokemonInstance
	{
		#region Golisopod Constructors
		/// <summary>
		/// Golisopod Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GolisopodInstance(string nickname, int level)
		: base(
				768,
				SpeciesGolisopod.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golisopod Builder only waiting for a Level
		/// </summary>
		public GolisopodInstance(int level)
		: base(
				768,
				SpeciesGolisopod.Instance, // PokemonInstance Species
				"Golisopod", level,
				Bug.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golisopod Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Golisopod() : base(
			768,
			SpeciesGolisopod.Instance, // PokemonInstance Species
			Bug.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}