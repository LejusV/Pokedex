using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Skiddo Species to store common natural stats of all Skiddos
	#region SpeciesSkiddo
	public class SpeciesSkiddo : PokemonSpecies
	{
#nullable enable
		private static SpeciesSkiddo? _instance = null;
#nullable restore
        public static SpeciesSkiddo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSkiddo();
                }
                return _instance;
            }
        }

		#region SpeciesSkiddo Constructor
		public SpeciesSkiddo() : base(
			"Skiddo",
			0.9,
			31.0,
			66, // HPs
			65, 48, // Attack & Defense
			62, 57, // Special Attack & Defense
			52		
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
				"Vine-Whip",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Roar",
				"Surf",
				"Strength",
				"Leech-Seed",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Dig",
				"Toxic",
				"Double-Team",
				"Defense-Curl",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Rollout",
				"Swagger",
				"Milk-Drink",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Brick-Break",
				"Secret-Power",
				"Bulk-Up",
				"Leaf-Blade",
				"Payback",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Zen-Headbutt",
				"Grass-Knot",
				"Round",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Horn-Leech",
				"Grassy-Terrain",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Skiddo PokemonInstance Class
	#region Skiddo
	public class SkiddoInstance : PokemonInstance
	{
		#region Skiddo Constructors
		/// <summary>
		/// Skiddo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SkiddoInstance(string nickname, int level)
		: base(
				672,
				SpeciesSkiddo.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skiddo Builder only waiting for a Level
		/// </summary>
		public SkiddoInstance(int level)
		: base(
				672,
				SpeciesSkiddo.Instance, // PokemonInstance Species
				"Skiddo", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skiddo Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Skiddo() : base(
			672,
			SpeciesSkiddo.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}