using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Brionne Specie to store common natural stats of all Brionnes
	#region SpecieBrionne
	public class SpecieBrionne : PokemonSpecie
	{
#nullable enable
		private static SpecieBrionne? _instance = null;
#nullable restore
        public static SpecieBrionne Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBrionne();
                }
                return _instance;
            }
        }

		#region SpecieBrionne Builder
		public SpecieBrionne() : base(
			"Brionne",
			60, // HPs
			69, 69, // Attack & Defense
			91, 81, // Special Attack & Defense
			50			
		) {}
		#endregion
	}
	#endregion

	//Brionne Pokemon Class
	#region Brionne
	public class Brionne : Pokemon
	{
		#region Brionne Builders
		/// <summary>
		/// Brionne Builder waiting for a Nickname & a Level
		/// </summary>
		public Brionne(string nickname, int level)
		: base(
				729,
				SpecieBrionne.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Brionne Builder only waiting for a Level
		/// </summary>
		public Brionne(int level)
		: base(
				729,
				SpecieBrionne.Instance, // Pokemon Specie
				"Brionne", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Brionne Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Brionne() : base(
			729,
			SpecieBrionne.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		#endregion
	}
	#endregion
}