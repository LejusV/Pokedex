using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Mandibuzz Specie to store common natural stats of all Mandibuzzs
	#region SpecieMandibuzz
	public class SpecieMandibuzz : PokemonSpecie
	{
#nullable enable
		private static SpecieMandibuzz? _instance = null;
#nullable restore
        public static SpecieMandibuzz Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMandibuzz();
                }
                return _instance;
            }
        }

		#region SpecieMandibuzz Builder
		public SpecieMandibuzz() : base(
			"Mandibuzz",
			110, // HPs
			65, 105, // Attack & Defense
			55, 95, // Special Attack & Defense
			80		
		)
		{
			this._height = 12;
			this._weight = 395;
		}
		#endregion
	}
	#endregion

	//Mandibuzz Pokemon Class
	#region Mandibuzz
	public class Mandibuzz : Pokemon
	{
		#region Mandibuzz Builders
		/// <summary>
		/// Mandibuzz Builder waiting for a Nickname & a Level
		/// </summary>
		public Mandibuzz(string nickname, int level)
		: base(
				630,
				SpecieMandibuzz.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mandibuzz Builder only waiting for a Level
		/// </summary>
		public Mandibuzz(int level)
		: base(
				630,
				SpecieMandibuzz.Instance, // Pokemon Specie
				"Mandibuzz", level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mandibuzz Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Mandibuzz() : base(
			630,
			SpecieMandibuzz.Instance, // Pokemon Specie
			Dark.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}