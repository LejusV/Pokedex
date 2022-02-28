using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Zweilous Specie to store common natural stats of all Zweilouss
	#region SpecieZweilous
	public class SpecieZweilous : PokemonSpecie
	{
#nullable enable
		private static SpecieZweilous? _instance = null;
#nullable restore
        public static SpecieZweilous Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZweilous();
                }
                return _instance;
            }
        }

		#region SpecieZweilous Builder
		public SpecieZweilous() : base(
			"Zweilous",
			72, // HPs
			85, 70, // Attack & Defense
			65, 70, // Special Attack & Defense
			58			
		) {}
		#endregion
	}
	#endregion

	//Zweilous Pokemon Class
	#region Zweilous
	public class Zweilous : Pokemon
	{
		#region Zweilous Builders
		/// <summary>
		/// Zweilous Builder waiting for a Nickname & a Level
		/// </summary>
		public Zweilous(string nickname, int level)
		: base(
				634,
				SpecieZweilous.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zweilous Builder only waiting for a Level
		/// </summary>
		public Zweilous(int level)
		: base(
				634,
				SpecieZweilous.Instance, // Pokemon Specie
				"Zweilous", level,
				Dark.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zweilous Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Zweilous() : base(
			634,
			SpecieZweilous.Instance, // Pokemon Specie
			Dark.Instance, Dragon.Instance			
		) {}
		#endregion
	}
	#endregion
}