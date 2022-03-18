using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Corvisquire Species to store common natural stats of all Corvisquires
	#region SpeciesCorvisquire
	public class SpeciesCorvisquire : PokemonSpecies
	{
#nullable enable
		private static SpeciesCorvisquire? _instance = null;
#nullable restore
        public static SpeciesCorvisquire Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCorvisquire();
                }
                return _instance;
            }
        }

		#region SpeciesCorvisquire Constructor
		public SpeciesCorvisquire() : base(
			822,
			"Corvisquire",
			0.8,
			16.0,
			68, // HPs
			67, 55, // Attack & Defense
			43, 55, // Special Attack & Defense
			77		
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

	//Corvisquire PokemonInstance Class
	#region Corvisquire
	public class CorvisquireInstance : PokemonInstance
	{
		#region Corvisquire Constructors
		/// <summary>
		/// Corvisquire Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CorvisquireInstance(string nickname, int level)
		: base(
				SpeciesCorvisquire.Instance, // Pokemon Species
				nickname, level,
				Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Corvisquire Builder only waiting for a Level
		/// </summary>
		public CorvisquireInstance(int level)
		: base(
				SpeciesCorvisquire.Instance, // PokemonInstance Species
				"Corvisquire", level,
				Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Corvisquire Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CorvisquireInstance() : base(
			SpeciesCorvisquire.Instance, // PokemonInstance Species
			Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}