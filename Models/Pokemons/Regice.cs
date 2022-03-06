using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Regice Specie to store common natural stats of all Regices
	#region SpecieRegice
	public class SpecieRegice : PokemonSpecie
	{
#nullable enable
		private static SpecieRegice? _instance = null;
#nullable restore
        public static SpecieRegice Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRegice();
                }
                return _instance;
            }
        }

		#region SpecieRegice Builder
		public SpecieRegice() : base(
			"Regice",
			80, // HPs
			50, 100, // Attack & Defense
			100, 200, // Special Attack & Defense
			50		
		)
		{
			this._height = 18;
			this._weight = 1750;
		}
		#endregion
	}
	#endregion

	//Regice Pokemon Class
	#region Regice
	public class Regice : Pokemon
	{
		#region Regice Builders
		/// <summary>
		/// Regice Builder waiting for a Nickname & a Level
		/// </summary>
		public Regice(string nickname, int level)
		: base(
				378,
				SpecieRegice.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regice Builder only waiting for a Level
		/// </summary>
		public Regice(int level)
		: base(
				378,
				SpecieRegice.Instance, // Pokemon Specie
				"Regice", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regice Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Regice() : base(
			378,
			SpecieRegice.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}