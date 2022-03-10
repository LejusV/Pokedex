using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Sirfetchd Species to store common natural stats of all Sirfetchds
	#region SpeciesSirfetchd
	public class SpeciesSirfetchd : PokemonSpecies
	{
#nullable enable
		private static SpeciesSirfetchd? _instance = null;
#nullable restore
        public static SpeciesSirfetchd Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSirfetchd();
                }
                return _instance;
            }
        }

		#region SpeciesSirfetchd Constructor
		public SpeciesSirfetchd() : base(
			"Sirfetchd",
			0.8,
			117.0,
			62, // HPs
			135, 95, // Attack & Defense
			68, 82, // Special Attack & Defense
			65		
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

	//Sirfetchd PokemonInstance Class
	#region Sirfetchd
	public class SirfetchdInstance : PokemonInstance
	{
		#region Sirfetchd Constructors
		/// <summary>
		/// Sirfetchd Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SirfetchdInstance(string nickname, int level)
		: base(
				865,
				SpeciesSirfetchd.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sirfetchd Builder only waiting for a Level
		/// </summary>
		public SirfetchdInstance(int level)
		: base(
				865,
				SpeciesSirfetchd.Instance, // PokemonInstance Species
				"Sirfetchd", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sirfetchd Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Sirfetchd() : base(
			865,
			SpeciesSirfetchd.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}