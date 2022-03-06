using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Durant Specie to store common natural stats of all Durants
	#region SpecieDurant
	public class SpecieDurant : PokemonSpecie
	{
#nullable enable
		private static SpecieDurant? _instance = null;
#nullable restore
        public static SpecieDurant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDurant();
                }
                return _instance;
            }
        }

		#region SpecieDurant Builder
		public SpecieDurant() : base(
			"Durant",
			0.3,
			33.0,
			58, // HPs
			109, 112, // Attack & Defense
			48, 48, // Special Attack & Defense
			109		
		)
		{}
		#endregion
	}
	#endregion

	//Durant Pokemon Class
	#region Durant
	public class Durant : Pokemon
	{
		#region Durant Builders
		/// <summary>
		/// Durant Builder waiting for a Nickname & a Level
		/// </summary>
		public Durant(string nickname, int level)
		: base(
				632,
				SpecieDurant.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Durant Builder only waiting for a Level
		/// </summary>
		public Durant(int level)
		: base(
				632,
				SpecieDurant.Instance, // Pokemon Specie
				"Durant", level,
				Bug.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Durant Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Durant() : base(
			632,
			SpecieDurant.Instance, // Pokemon Specie
			Bug.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}