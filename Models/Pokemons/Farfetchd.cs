using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Farfetchd Specie to store common natural stats of all Farfetchds
	#region SpecieFarfetchd
	public class SpecieFarfetchd : PokemonSpecie
	{
#nullable enable
		private static SpecieFarfetchd? _instance = null;
#nullable restore
        public static SpecieFarfetchd Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFarfetchd();
                }
                return _instance;
            }
        }

		#region SpecieFarfetchd Builder
		public SpecieFarfetchd() : base(
			"Farfetchd",
			52, // HPs
			90, 55, // Attack & Defense
			58, 62, // Special Attack & Defense
			60		
		)
		{
			this._height = 8;
			this._weight = 150;
		}
		#endregion
	}
	#endregion

	//Farfetchd Pokemon Class
	#region Farfetchd
	public class Farfetchd : Pokemon
	{
		#region Farfetchd Builders
		/// <summary>
		/// Farfetchd Builder waiting for a Nickname & a Level
		/// </summary>
		public Farfetchd(string nickname, int level)
		: base(
				83,
				SpecieFarfetchd.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Farfetchd Builder only waiting for a Level
		/// </summary>
		public Farfetchd(int level)
		: base(
				83,
				SpecieFarfetchd.Instance, // Pokemon Specie
				"Farfetchd", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Farfetchd Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Farfetchd() : base(
			83,
			SpecieFarfetchd.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}