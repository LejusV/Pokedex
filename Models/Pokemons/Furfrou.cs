using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Furfrou Specie to store common natural stats of all Furfrous
	#region SpecieFurfrou
	public class SpecieFurfrou : PokemonSpecie
	{
#nullable enable
		private static SpecieFurfrou? _instance = null;
#nullable restore
        public static SpecieFurfrou Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFurfrou();
                }
                return _instance;
            }
        }

		#region SpecieFurfrou Builder
		public SpecieFurfrou() : base(
			"Furfrou",
			75, // HPs
			80, 60, // Attack & Defense
			65, 90, // Special Attack & Defense
			102		
		)
		{
			this._height = 12;
			this._weight = 280;
		}
		#endregion
	}
	#endregion

	//Furfrou Pokemon Class
	#region Furfrou
	public class Furfrou : Pokemon
	{
		#region Furfrou Builders
		/// <summary>
		/// Furfrou Builder waiting for a Nickname & a Level
		/// </summary>
		public Furfrou(string nickname, int level)
		: base(
				676,
				SpecieFurfrou.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Furfrou Builder only waiting for a Level
		/// </summary>
		public Furfrou(int level)
		: base(
				676,
				SpecieFurfrou.Instance, // Pokemon Specie
				"Furfrou", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Furfrou Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Furfrou() : base(
			676,
			SpecieFurfrou.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}