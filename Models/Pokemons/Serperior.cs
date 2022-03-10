using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Serperior Species to store common natural stats of all Serperiors
	#region SpeciesSerperior
	public class SpeciesSerperior : PokemonSpecies
	{
#nullable enable
		private static SpeciesSerperior? _instance = null;
#nullable restore
        public static SpeciesSerperior Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSerperior();
                }
                return _instance;
            }
        }

		#region SpeciesSerperior Constructor
		public SpeciesSerperior() : base(
			"Serperior",
			3.3,
			63.0,
			75, // HPs
			75, 95, // Attack & Defense
			75, 95, // Special Attack & Defense
			113		
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
				"Bind",
				"Slam",
				"Vine-Whip",
				"Tackle",
				"Wrap",
				"Leer",
				"Hyper-Beam",
				"Strength",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Outrage",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Aerial-Ace",
				"Frenzy-Plant",
				"Calm-Mind",
				"Leaf-Blade",
				"Wring-Out",
				"Gastro-Acid",
				"Worry-Seed",
				"Aqua-Tail",
				"Seed-Bomb",
				"Dragon-Pulse",
				"Energy-Ball",
				"Giga-Impact",
				"Leaf-Storm",
				"Grass-Knot",
				"Coil",
				"Round",
				"Grass-Pledge",
				"Dragon-Tail",
				"Work-Up",
				"Leaf-Tornado",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Serperior PokemonInstance Class
	#region Serperior
	public class SerperiorInstance : PokemonInstance
	{
		#region Serperior Constructors
		/// <summary>
		/// Serperior Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SerperiorInstance(string nickname, int level)
		: base(
				497,
				SpeciesSerperior.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Serperior Builder only waiting for a Level
		/// </summary>
		public SerperiorInstance(int level)
		: base(
				497,
				SpeciesSerperior.Instance, // PokemonInstance Species
				"Serperior", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Serperior Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Serperior() : base(
			497,
			SpeciesSerperior.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}