using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Kecleon Specie to store common natural stats of all Kecleons
	#region SpecieKecleon
	public class SpecieKecleon : PokemonSpecie
	{
#nullable enable
		private static SpecieKecleon? _instance = null;
#nullable restore
        public static SpecieKecleon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKecleon();
                }
                return _instance;
            }
        }

		#region SpecieKecleon Builder
		public SpecieKecleon() : base(
			"Kecleon",
			1.0,
			22.0,
			60, // HPs
			90, 70, // Attack & Defense
			60, 120, // Special Attack & Defense
			40		
		)
		{}
		#endregion
	}
	#endregion

	//Kecleon Pokemon Class
	#region Kecleon
	public class Kecleon : Pokemon
	{
		#region Kecleon Builders
		/// <summary>
		/// Kecleon Builder waiting for a Nickname & a Level
		/// </summary>
		public Kecleon(string nickname, int level)
		: base(
				352,
				SpecieKecleon.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kecleon Builder only waiting for a Level
		/// </summary>
		public Kecleon(int level)
		: base(
				352,
				SpecieKecleon.Instance, // Pokemon Specie
				"Kecleon", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kecleon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Kecleon() : base(
			352,
			SpecieKecleon.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}