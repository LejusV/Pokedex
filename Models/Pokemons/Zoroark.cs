using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Zoroark Specie to store common natural stats of all Zoroarks
	#region SpecieZoroark
	public class SpecieZoroark : PokemonSpecie
	{
#nullable enable
		private static SpecieZoroark? _instance = null;
#nullable restore
        public static SpecieZoroark Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZoroark();
                }
                return _instance;
            }
        }

		#region SpecieZoroark Builder
		public SpecieZoroark() : base(
			"Zoroark",
			1.6,
			81.1,
			60, // HPs
			105, 60, // Attack & Defense
			120, 60, // Special Attack & Defense
			105		
		)
		{}
		#endregion
	}
	#endregion

	//Zoroark Pokemon Class
	#region Zoroark
	public class Zoroark : Pokemon
	{
		#region Zoroark Builders
		/// <summary>
		/// Zoroark Builder waiting for a Nickname & a Level
		/// </summary>
		public Zoroark(string nickname, int level)
		: base(
				571,
				SpecieZoroark.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zoroark Builder only waiting for a Level
		/// </summary>
		public Zoroark(int level)
		: base(
				571,
				SpecieZoroark.Instance, // Pokemon Specie
				"Zoroark", level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zoroark Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Zoroark() : base(
			571,
			SpecieZoroark.Instance, // Pokemon Specie
			Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}