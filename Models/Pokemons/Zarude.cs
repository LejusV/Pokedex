using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Zarude Species to store common natural stats of all Zarudes
	#region SpeciesZarude
	public class SpeciesZarude : PokemonSpecies
	{
#nullable enable
		private static SpeciesZarude? _instance = null;
#nullable restore
        public static SpeciesZarude Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesZarude();
                }
                return _instance;
            }
        }

		#region SpeciesZarude Constructor
		public SpeciesZarude() : base(
			"Zarude",
			1.8,
			70.0,
			105, // HPs
			120, 105, // Attack & Defense
			70, 95, // Special Attack & Defense
			105		
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

	//Zarude PokemonInstance Class
	#region Zarude
	public class ZarudeInstance : PokemonInstance
	{
		#region Zarude Constructors
		/// <summary>
		/// Zarude Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ZarudeInstance(string nickname, int level)
		: base(
				893,
				SpeciesZarude.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zarude Builder only waiting for a Level
		/// </summary>
		public ZarudeInstance(int level)
		: base(
				893,
				SpeciesZarude.Instance, // PokemonInstance Species
				"Zarude", level,
				Dark.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zarude Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Zarude() : base(
			893,
			SpeciesZarude.Instance, // PokemonInstance Species
			Dark.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}