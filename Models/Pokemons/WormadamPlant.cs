using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Wormadam-Plant Species to store common natural stats of all Wormadam-Plants
	#region SpeciesWormadam-Plant
	public class SpeciesWormadamPlant : PokemonSpecies
	{
#nullable enable
		private static SpeciesWormadamPlant? _instance = null;
#nullable restore
        public static SpeciesWormadamPlant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesWormadamPlant();
                }
                return _instance;
            }
        }

		#region SpeciesWormadam-Plant Constructor
		public SpeciesWormadamPlant() : base(
			"Wormadam-Plant",
			0.5,
			6.5,
			60, // HPs
			59, 85, // Attack & Defense
			79, 105, // Special Attack & Defense
			36		
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
				"Tackle",
				"Psybeam",
				"Hyper-Beam",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"String-Shot",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Flail",
				"Protect",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Facade",
				"Endeavor",
				"Skill-Swap",
				"Secret-Power",
				"Signal-Beam",
				"Bullet-Seed",
				"Natural-Gift",
				"Worry-Seed",
				"Sucker-Punch",
				"Seed-Bomb",
				"Bug-Buzz",
				"Energy-Ball",
				"Giga-Impact",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Bug-Bite",
				"Venoshock",
				"Quiver-Dance",
				"Round",
				"Struggle-Bug",
				"Electroweb",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Wormadam-Plant PokemonInstance Class
	#region Wormadam-Plant
	public class WormadamPlantInstance : PokemonInstance
	{
		#region Wormadam-Plant Constructors
		/// <summary>
		/// Wormadam-Plant Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WormadamPlantInstance(string nickname, int level)
		: base(
				413,
				SpeciesWormadamPlant.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wormadam-Plant Builder only waiting for a Level
		/// </summary>
		public WormadamPlantInstance(int level)
		: base(
				413,
				SpeciesWormadamPlant.Instance, // PokemonInstance Species
				"Wormadam-Plant", level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wormadam-Plant Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public WormadamPlant() : base(
			413,
			SpeciesWormadamPlant.Instance, // PokemonInstance Species
			Bug.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}