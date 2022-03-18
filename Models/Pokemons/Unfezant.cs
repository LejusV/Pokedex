using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Unfezant Species to store common natural stats of all Unfezants
	#region SpeciesUnfezant
	public class SpeciesUnfezant : PokemonSpecies
	{
#nullable enable
		private static SpeciesUnfezant? _instance = null;
#nullable restore
        public static SpeciesUnfezant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesUnfezant();
                }
                return _instance;
            }
        }

		#region SpeciesUnfezant Constructor
		public SpeciesUnfezant() : base(
			521,
			"Unfezant",
			1.2,
			29.0,
			80, // HPs
			115, 80, // Attack & Defense
			65, 55, // Special Attack & Defense
			93		
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
				"Razor-Wind",
				"Gust",
				"Fly",
				"Leer",
				"Growl",
				"Hyper-Beam",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Detect",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Uproar",
				"Heat-Wave",
				"Facade",
				"Taunt",
				"Secret-Power",
				"Feather-Dance",
				"Air-Cutter",
				"Aerial-Ace",
				"Roost",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Air-Slash",
				"Giga-Impact",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Unfezant PokemonInstance Class
	#region Unfezant
	public class UnfezantInstance : PokemonInstance
	{
		#region Unfezant Constructors
		/// <summary>
		/// Unfezant Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public UnfezantInstance(string nickname, int level)
		: base(
				SpeciesUnfezant.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Unfezant Builder only waiting for a Level
		/// </summary>
		public UnfezantInstance(int level)
		: base(
				SpeciesUnfezant.Instance, // PokemonInstance Species
				"Unfezant", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Unfezant Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public UnfezantInstance() : base(
			SpeciesUnfezant.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}