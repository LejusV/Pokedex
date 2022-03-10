using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Amoonguss Species to store common natural stats of all Amoongusss
	#region SpeciesAmoonguss
	public class SpeciesAmoonguss : PokemonSpecies
	{
#nullable enable
		private static SpeciesAmoonguss? _instance = null;
#nullable restore
        public static SpeciesAmoonguss Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAmoonguss();
                }
                return _instance;
            }
        }

		#region SpeciesAmoonguss Constructor
		public SpeciesAmoonguss() : base(
			"Amoonguss",
			0.6,
			10.5,
			114, // HPs
			85, 70, // Attack & Defense
			85, 80, // Special Attack & Defense
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
				"Hyper-Beam",
				"Absorb",
				"Mega-Drain",
				"Growth",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Bide",
				"Spore",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Secret-Power",
				"Astonish",
				"Payback",
				"Gastro-Acid",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Grass-Knot",
				"Venoshock",
				"Rage-Powder",
				"Foul-Play",
				"After-You",
				"Round",
				"Clear-Smog",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Amoonguss PokemonInstance Class
	#region Amoonguss
	public class AmoongussInstance : PokemonInstance
	{
		#region Amoonguss Constructors
		/// <summary>
		/// Amoonguss Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AmoongussInstance(string nickname, int level)
		: base(
				591,
				SpeciesAmoonguss.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Amoonguss Builder only waiting for a Level
		/// </summary>
		public AmoongussInstance(int level)
		: base(
				591,
				SpeciesAmoonguss.Instance, // PokemonInstance Species
				"Amoonguss", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Amoonguss Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Amoonguss() : base(
			591,
			SpeciesAmoonguss.Instance, // PokemonInstance Species
			Grass.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}