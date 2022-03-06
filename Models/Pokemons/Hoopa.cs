using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Hoopa Specie to store common natural stats of all Hoopas
	#region SpecieHoopa
	public class SpecieHoopa : PokemonSpecie
	{
#nullable enable
		private static SpecieHoopa? _instance = null;
#nullable restore
        public static SpecieHoopa Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHoopa();
                }
                return _instance;
            }
        }

		#region SpecieHoopa Builder
		public SpecieHoopa() : base(
			"Hoopa",
			80, // HPs
			110, 60, // Attack & Defense
			150, 130, // Special Attack & Defense
			70		
		)
		{
			this._height = 5;
			this._weight = 90;
		}
		#endregion
	}
	#endregion

	//Hoopa Pokemon Class
	#region Hoopa
	public class Hoopa : Pokemon
	{
		#region Hoopa Builders
		/// <summary>
		/// Hoopa Builder waiting for a Nickname & a Level
		/// </summary>
		public Hoopa(string nickname, int level)
		: base(
				720,
				SpecieHoopa.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hoopa Builder only waiting for a Level
		/// </summary>
		public Hoopa(int level)
		: base(
				720,
				SpecieHoopa.Instance, // Pokemon Specie
				"Hoopa", level,
				Psychic.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hoopa Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Hoopa() : base(
			720,
			SpecieHoopa.Instance, // Pokemon Specie
			Psychic.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}