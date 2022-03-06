using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Taillow Specie to store common natural stats of all Taillows
	#region SpecieTaillow
	public class SpecieTaillow : PokemonSpecie
	{
#nullable enable
		private static SpecieTaillow? _instance = null;
#nullable restore
        public static SpecieTaillow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTaillow();
                }
                return _instance;
            }
        }

		#region SpecieTaillow Builder
		public SpecieTaillow() : base(
			"Taillow",
			0.3,
			2.3,
			40, // HPs
			55, 30, // Attack & Defense
			30, 30, // Special Attack & Defense
			85		
		)
		{}
		#endregion
	}
	#endregion

	//Taillow Pokemon Class
	#region Taillow
	public class Taillow : Pokemon
	{
		#region Taillow Builders
		/// <summary>
		/// Taillow Builder waiting for a Nickname & a Level
		/// </summary>
		public Taillow(string nickname, int level)
		: base(
				276,
				SpecieTaillow.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Taillow Builder only waiting for a Level
		/// </summary>
		public Taillow(int level)
		: base(
				276,
				SpecieTaillow.Instance, // Pokemon Specie
				"Taillow", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Taillow Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Taillow() : base(
			276,
			SpecieTaillow.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}