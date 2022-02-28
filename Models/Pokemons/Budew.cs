using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Budew Specie to store common natural stats of all Budews
	#region SpecieBudew
	public class SpecieBudew : PokemonSpecie
	{
#nullable enable
		private static SpecieBudew? _instance = null;
#nullable restore
        public static SpecieBudew Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBudew();
                }
                return _instance;
            }
        }

		#region SpecieBudew Builder
		public SpecieBudew() : base(
			"Budew",
			40, // HPs
			30, 35, // Attack & Defense
			50, 70, // Special Attack & Defense
			55			
		) {}
		#endregion
	}
	#endregion

	//Budew Pokemon Class
	#region Budew
	public class Budew : Pokemon
	{
		#region Budew Builders
		/// <summary>
		/// Budew Builder waiting for a Nickname & a Level
		/// </summary>
		public Budew(string nickname, int level)
		: base(
				406,
				SpecieBudew.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Budew Builder only waiting for a Level
		/// </summary>
		public Budew(int level)
		: base(
				406,
				SpecieBudew.Instance, // Pokemon Specie
				"Budew", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Budew Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Budew() : base(
			406,
			SpecieBudew.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
		#endregion
	}
	#endregion
}