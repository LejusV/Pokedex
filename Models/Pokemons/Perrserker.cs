using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Perrserker Species to store common natural stats of all Perrserkers
	#region SpeciesPerrserker
	public class SpeciesPerrserker : PokemonSpecies
	{
#nullable enable
		private static SpeciesPerrserker? _instance = null;
#nullable restore
        public static SpeciesPerrserker Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPerrserker();
                }
                return _instance;
            }
        }

		#region SpeciesPerrserker Constructor
		public SpeciesPerrserker() : base(
			863,
			"Perrserker",
			0.8,
			28.0,
			70, // HPs
			110, 100, // Attack & Defense
			50, 60, // Special Attack & Defense
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
				
			};
		}
		#endregion
	}
	#endregion

	//Perrserker PokemonInstance Class
	#region Perrserker
	public class PerrserkerInstance : PokemonInstance
	{
		#region Perrserker Constructors
		/// <summary>
		/// Perrserker Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PerrserkerInstance(string nickname, int level)
		: base(
				SpeciesPerrserker.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Perrserker Builder only waiting for a Level
		/// </summary>
		public PerrserkerInstance(int level)
		: base(
				SpeciesPerrserker.Instance, // PokemonInstance Species
				"Perrserker", level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Perrserker Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PerrserkerInstance() : base(
			SpeciesPerrserker.Instance, // PokemonInstance Species
			Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}