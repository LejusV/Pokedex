using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Bewear Specie to store common natural stats of all Bewears
	#region SpecieBewear
	public class SpecieBewear : PokemonSpecie
	{
#nullable enable
		private static SpecieBewear? _instance = null;
#nullable restore
        public static SpecieBewear Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBewear();
                }
                return _instance;
            }
        }

		#region SpecieBewear Builder
		public SpecieBewear() : base(
			"Bewear",
			120, // HPs
			125, 80, // Attack & Defense
			55, 60, // Special Attack & Defense
			60		
		)
		{
			this._height = 21;
			this._weight = 1350;
		}
		#endregion
	}
	#endregion

	//Bewear Pokemon Class
	#region Bewear
	public class Bewear : Pokemon
	{
		#region Bewear Builders
		/// <summary>
		/// Bewear Builder waiting for a Nickname & a Level
		/// </summary>
		public Bewear(string nickname, int level)
		: base(
				760,
				SpecieBewear.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bewear Builder only waiting for a Level
		/// </summary>
		public Bewear(int level)
		: base(
				760,
				SpecieBewear.Instance, // Pokemon Specie
				"Bewear", level,
				Normal.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bewear Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Bewear() : base(
			760,
			SpecieBewear.Instance, // Pokemon Specie
			Normal.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}