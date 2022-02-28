using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Bisharp Specie to store common natural stats of all Bisharps
	#region SpecieBisharp
	public class SpecieBisharp : PokemonSpecie
	{
#nullable enable
		private static SpecieBisharp? _instance = null;
#nullable restore
        public static SpecieBisharp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBisharp();
                }
                return _instance;
            }
        }

		#region SpecieBisharp Builder
		public SpecieBisharp() : base(
			"Bisharp",
			65, // HPs
			125, 100, // Attack & Defense
			60, 70, // Special Attack & Defense
			70			
		) {}
		#endregion
	}
	#endregion

	//Bisharp Pokemon Class
	#region Bisharp
	public class Bisharp : Pokemon
	{
		#region Bisharp Builders
		/// <summary>
		/// Bisharp Builder waiting for a Nickname & a Level
		/// </summary>
		public Bisharp(string nickname, int level)
		: base(
				625,
				SpecieBisharp.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bisharp Builder only waiting for a Level
		/// </summary>
		public Bisharp(int level)
		: base(
				625,
				SpecieBisharp.Instance, // Pokemon Specie
				"Bisharp", level,
				Dark.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bisharp Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Bisharp() : base(
			625,
			SpecieBisharp.Instance, // Pokemon Specie
			Dark.Instance, Steel.Instance			
		) {}
		#endregion
	}
	#endregion
}