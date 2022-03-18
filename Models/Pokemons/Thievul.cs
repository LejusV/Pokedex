using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Thievul Species to store common natural stats of all Thievuls
	#region SpeciesThievul
	public class SpeciesThievul : PokemonSpecies
	{
#nullable enable
		private static SpeciesThievul? _instance = null;
#nullable restore
        public static SpeciesThievul Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesThievul();
                }
                return _instance;
            }
        }

		#region SpeciesThievul Constructor
		public SpeciesThievul() : base(
			828,
			"Thievul",
			1.2,
			19.9,
			70, // HPs
			58, 58, // Attack & Defense
			87, 92, // Special Attack & Defense
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
				
			};
		}
		#endregion
	}
	#endregion

	//Thievul PokemonInstance Class
	#region Thievul
	public class ThievulInstance : PokemonInstance
	{
		#region Thievul Constructors
		/// <summary>
		/// Thievul Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ThievulInstance(string nickname, int level)
		: base(
				SpeciesThievul.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Thievul Builder only waiting for a Level
		/// </summary>
		public ThievulInstance(int level)
		: base(
				SpeciesThievul.Instance, // PokemonInstance Species
				"Thievul", level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Thievul Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ThievulInstance() : base(
			SpeciesThievul.Instance, // PokemonInstance Species
			Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}