using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Gloom Species to store common natural stats of all Glooms
	#region SpeciesGloom
	public class SpeciesGloom : PokemonSpecies
	{
#nullable enable
		private static SpeciesGloom? _instance = null;
#nullable restore
        public static SpeciesGloom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGloom();
                }
                return _instance;
            }
        }

		#region SpeciesGloom Constructor
		public SpeciesGloom() : base(
			44,
			"Gloom",
			0.8,
			8.6,
			60, // HPs
			65, 70, // Attack & Defense
			85, 75, // Special Attack & Defense
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
				"Cut",
				"Take-Down",
				"Double-Edge",
				"Acid",
				"Absorb",
				"Mega-Drain",
				"Growth",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"Petal-Dance",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Sweet-Scent",
				"Synthesis",
				"Moonlight",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Secret-Power",
				"Bullet-Seed",
				"Natural-Gift",
				"Fling",
				"Gastro-Acid",
				"Lucky-Chant",
				"Worry-Seed",
				"Seed-Bomb",
				"Drain-Punch",
				"Energy-Ball",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"After-You",
				"Round",
				"Petal-Blizzard",
				"Grassy-Terrain",
				"Confide",
				"Dazzling-Gleam",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Gloom PokemonInstance Class
	#region Gloom
	public class GloomInstance : PokemonInstance
	{
		#region Gloom Constructors
		/// <summary>
		/// Gloom Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GloomInstance(string nickname, int level)
		: base(
				SpeciesGloom.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gloom Builder only waiting for a Level
		/// </summary>
		public GloomInstance(int level)
		: base(
				SpeciesGloom.Instance, // PokemonInstance Species
				"Gloom", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gloom Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GloomInstance() : base(
			SpeciesGloom.Instance, // PokemonInstance Species
			Grass.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}