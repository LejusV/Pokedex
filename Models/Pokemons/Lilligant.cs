using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Lilligant Species to store common natural stats of all Lilligants
	#region SpeciesLilligant
	public class SpeciesLilligant : PokemonSpecies
	{
#nullable enable
		private static SpeciesLilligant? _instance = null;
#nullable restore
        public static SpeciesLilligant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLilligant();
                }
                return _instance;
            }
        }

		#region SpeciesLilligant Constructor
		public SpeciesLilligant() : base(
			549,
			"Lilligant",
			1.1,
			16.3,
			70, // HPs
			60, 75, // Attack & Defense
			110, 75, // Special Attack & Defense
			90		
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
				"Hyper-Beam",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Petal-Dance",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Helping-Hand",
				"Role-Play",
				"Secret-Power",
				"Teeter-Dance",
				"Covet",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Grass-Knot",
				"Quiver-Dance",
				"After-You",
				"Round",
				"Petal-Blizzard",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Lilligant PokemonInstance Class
	#region Lilligant
	public class LilligantInstance : PokemonInstance
	{
		#region Lilligant Constructors
		/// <summary>
		/// Lilligant Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LilligantInstance(string nickname, int level)
		: base(
				SpeciesLilligant.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lilligant Builder only waiting for a Level
		/// </summary>
		public LilligantInstance(int level)
		: base(
				SpeciesLilligant.Instance, // PokemonInstance Species
				"Lilligant", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lilligant Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public LilligantInstance() : base(
			SpeciesLilligant.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}