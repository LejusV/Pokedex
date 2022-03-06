using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Horsea Specie to store common natural stats of all Horseas
	#region SpecieHorsea
	public class SpecieHorsea : PokemonSpecie
	{
#nullable enable
		private static SpecieHorsea? _instance = null;
#nullable restore
        public static SpecieHorsea Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHorsea();
                }
                return _instance;
            }
        }

		#region SpecieHorsea Builder
		public SpecieHorsea() : base(
			"Horsea",
			0.4,
			8.0,
			30, // HPs
			40, 70, // Attack & Defense
			70, 25, // Special Attack & Defense
			60		
		)
		{}
		#endregion
	}
	#endregion

	//Horsea Pokemon Class
	#region Horsea
	public class Horsea : Pokemon
	{
		#region Horsea Builders
		/// <summary>
		/// Horsea Builder waiting for a Nickname & a Level
		/// </summary>
		public Horsea(string nickname, int level)
		: base(
				116,
				SpecieHorsea.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Horsea Builder only waiting for a Level
		/// </summary>
		public Horsea(int level)
		: base(
				116,
				SpecieHorsea.Instance, // Pokemon Specie
				"Horsea", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Horsea Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Horsea() : base(
			116,
			SpecieHorsea.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}