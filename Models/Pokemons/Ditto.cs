using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Ditto Species to store common natural stats of all Dittos
	#region SpeciesDitto
	public class SpeciesDitto : PokemonSpecies
	{
#nullable enable
		private static SpeciesDitto? _instance = null;
#nullable restore
        public static SpeciesDitto Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDitto();
                }
                return _instance;
            }
        }

		#region SpeciesDitto Constructor
		public SpeciesDitto() : base(
			"Ditto",
			0.3,
			4.0,
			48, // HPs
			48, 48, // Attack & Defense
			48, 48, // Special Attack & Defense
			48		
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
				"Transform"
			};
		}
		#endregion
	}
	#endregion

	//Ditto PokemonInstance Class
	#region Ditto
	public class DittoInstance : PokemonInstance
	{
		#region Ditto Constructors
		/// <summary>
		/// Ditto Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DittoInstance(string nickname, int level)
		: base(
				132,
				SpeciesDitto.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ditto Builder only waiting for a Level
		/// </summary>
		public DittoInstance(int level)
		: base(
				132,
				SpeciesDitto.Instance, // PokemonInstance Species
				"Ditto", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ditto Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Ditto() : base(
			132,
			SpeciesDitto.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}