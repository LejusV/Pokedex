using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Wooloo Species to store common natural stats of all Wooloos
	#region SpeciesWooloo
	public class SpeciesWooloo : PokemonSpecies
	{
#nullable enable
		private static SpeciesWooloo? _instance = null;
#nullable restore
        public static SpeciesWooloo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesWooloo();
                }
                return _instance;
            }
        }

		#region SpeciesWooloo Constructor
		public SpeciesWooloo() : base(
			831,
			"Wooloo",
			0.6,
			6.0,
			42, // HPs
			40, 55, // Attack & Defense
			40, 45, // Special Attack & Defense
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
				
			};
		}
		#endregion
	}
	#endregion

	//Wooloo PokemonInstance Class
	#region Wooloo
	public class WoolooInstance : PokemonInstance
	{
		#region Wooloo Constructors
		/// <summary>
		/// Wooloo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WoolooInstance(string nickname, int level)
		: base(
				SpeciesWooloo.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wooloo Builder only waiting for a Level
		/// </summary>
		public WoolooInstance(int level)
		: base(
				SpeciesWooloo.Instance, // PokemonInstance Species
				"Wooloo", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wooloo Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public WoolooInstance() : base(
			SpeciesWooloo.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}