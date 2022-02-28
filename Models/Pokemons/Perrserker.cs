using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Perrserker Specie to store common natural stats of all Perrserkers
	#region SpeciePerrserker
	public class SpeciePerrserker : PokemonSpecie
	{
#nullable enable
		private static SpeciePerrserker? _instance = null;
#nullable restore
        public static SpeciePerrserker Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePerrserker();
                }
                return _instance;
            }
        }

		#region SpeciePerrserker Builder
		public SpeciePerrserker() : base(
			"Perrserker",
			70, // HPs
			110, 100, // Attack & Defense
			50, 60, // Special Attack & Defense
			50			
		) {}
		#endregion
	}
	#endregion

	//Perrserker Pokemon Class
	#region Perrserker
	public class Perrserker : Pokemon
	{
		#region Perrserker Builders
		/// <summary>
		/// Perrserker Builder waiting for a Nickname & a Level
		/// </summary>
		public Perrserker(string nickname, int level)
		: base(
				863,
				SpeciePerrserker.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Perrserker Builder only waiting for a Level
		/// </summary>
		public Perrserker(int level)
		: base(
				863,
				SpeciePerrserker.Instance, // Pokemon Specie
				"Perrserker", level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Perrserker Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Perrserker() : base(
			863,
			SpeciePerrserker.Instance, // Pokemon Specie
			Steel.Instance			
		) {}
		#endregion
	}
	#endregion
}