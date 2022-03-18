using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Oddish Species to store common natural stats of all Oddishs
	#region SpeciesOddish
	public class SpeciesOddish : PokemonSpecies
	{
#nullable enable
		private static SpeciesOddish? _instance = null;
#nullable restore
        public static SpeciesOddish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesOddish();
                }
                return _instance;
            }
        }

		#region SpeciesOddish Constructor
		public SpeciesOddish() : base(
			43,
			"Oddish",
			0.5,
			5.4,
			45, // HPs
			50, 55, // Attack & Defense
			75, 65, // Special Attack & Defense
			30		
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
				"Razor-Leaf",
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
				"Flail",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Charm",
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
				"Ingrain",
				"Secret-Power",
				"Teeter-Dance",
				"Tickle",
				"Bullet-Seed",
				"Natural-Gift",
				"Gastro-Acid",
				"Lucky-Chant",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"After-You",
				"Round",
				"Grassy-Terrain",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam",
				"Infestation",
				"Strength-Sap"
			};
		}
		#endregion
	}
	#endregion

	//Oddish PokemonInstance Class
	#region Oddish
	public class OddishInstance : PokemonInstance
	{
		#region Oddish Constructors
		/// <summary>
		/// Oddish Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public OddishInstance(string nickname, int level)
		: base(
				SpeciesOddish.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Oddish Builder only waiting for a Level
		/// </summary>
		public OddishInstance(int level)
		: base(
				SpeciesOddish.Instance, // PokemonInstance Species
				"Oddish", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Oddish Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public OddishInstance() : base(
			SpeciesOddish.Instance, // PokemonInstance Species
			Grass.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}