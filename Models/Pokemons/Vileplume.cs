using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Vileplume Species to store common natural stats of all Vileplumes
	#region SpeciesVileplume
	public class SpeciesVileplume : PokemonSpecies
	{
#nullable enable
		private static SpeciesVileplume? _instance = null;
#nullable restore
        public static SpeciesVileplume Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesVileplume();
                }
                return _instance;
            }
        }

		#region SpeciesVileplume Constructor
		public SpeciesVileplume() : base(
			"Vileplume",
			1.2,
			18.6,
			75, // HPs
			80, 85, // Attack & Defense
			110, 90, // Special Attack & Defense
			50		
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
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Acid",
				"Hyper-Beam",
				"Absorb",
				"Mega-Drain",
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
				"Safeguard",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Secret-Power",
				"Aromatherapy",
				"Bullet-Seed",
				"Natural-Gift",
				"Fling",
				"Gastro-Acid",
				"Worry-Seed",
				"Seed-Bomb",
				"Drain-Punch",
				"Energy-Ball",
				"Giga-Impact",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"After-You",
				"Round",
				"Petal-Blizzard",
				"Confide",
				"Dazzling-Gleam",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Vileplume PokemonInstance Class
	#region Vileplume
	public class VileplumeInstance : PokemonInstance
	{
		#region Vileplume Constructors
		/// <summary>
		/// Vileplume Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public VileplumeInstance(string nickname, int level)
		: base(
				45,
				SpeciesVileplume.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vileplume Builder only waiting for a Level
		/// </summary>
		public VileplumeInstance(int level)
		: base(
				45,
				SpeciesVileplume.Instance, // PokemonInstance Species
				"Vileplume", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vileplume Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Vileplume() : base(
			45,
			SpeciesVileplume.Instance, // PokemonInstance Species
			Grass.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}