using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Rillaboom Species to store common natural stats of all Rillabooms
	#region SpeciesRillaboom
	public class SpeciesRillaboom : PokemonSpecies
	{
#nullable enable
		private static SpeciesRillaboom? _instance = null;
#nullable restore
        public static SpeciesRillaboom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRillaboom();
                }
                return _instance;
            }
        }

		#region SpeciesRillaboom Constructor
		public SpeciesRillaboom() : base(
			812,
			"Rillaboom",
			2.1,
			90.0,
			100, // HPs
			125, 90, // Attack & Defense
			60, 70, // Special Attack & Defense
			85		
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

	//Rillaboom PokemonInstance Class
	#region Rillaboom
	public class RillaboomInstance : PokemonInstance
	{
		#region Rillaboom Constructors
		/// <summary>
		/// Rillaboom Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RillaboomInstance(string nickname, int level)
		: base(
				SpeciesRillaboom.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rillaboom Builder only waiting for a Level
		/// </summary>
		public RillaboomInstance(int level)
		: base(
				SpeciesRillaboom.Instance, // PokemonInstance Species
				"Rillaboom", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rillaboom Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public RillaboomInstance() : base(
			SpeciesRillaboom.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}