using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Sirfetchd Specie to store common natural stats of all Sirfetchds
	#region SpecieSirfetchd
	public class SpecieSirfetchd : PokemonSpecie
	{
#nullable enable
		private static SpecieSirfetchd? _instance = null;
#nullable restore
        public static SpecieSirfetchd Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSirfetchd();
                }
                return _instance;
            }
        }

		#region SpecieSirfetchd Builder
		public SpecieSirfetchd() : base(
			"Sirfetchd",
			62, // HPs
			135, 95, // Attack & Defense
			68, 82, // Special Attack & Defense
			65		
		)
		{
			this._height = 8;
			this._weight = 1170;
		}
		#endregion
	}
	#endregion

	//Sirfetchd Pokemon Class
	#region Sirfetchd
	public class Sirfetchd : Pokemon
	{
		#region Sirfetchd Builders
		/// <summary>
		/// Sirfetchd Builder waiting for a Nickname & a Level
		/// </summary>
		public Sirfetchd(string nickname, int level)
		: base(
				865,
				SpecieSirfetchd.Instance, // Pokemon Specie
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
		public Sirfetchd(int level)
		: base(
				865,
				SpecieSirfetchd.Instance, // Pokemon Specie
				"Sirfetchd", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sirfetchd Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Sirfetchd() : base(
			865,
			SpecieSirfetchd.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}