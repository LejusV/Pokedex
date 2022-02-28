using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tauros Specie to store common natural stats of all Tauross
	#region SpecieTauros
	public class SpecieTauros : PokemonSpecie
	{
#nullable enable
		private static SpecieTauros? _instance = null;
#nullable restore
        public static SpecieTauros Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTauros();
                }
                return _instance;
            }
        }

		#region SpecieTauros Builder
		public SpecieTauros() : base(
			"Tauros",
			75, // HPs
			100, 95, // Attack & Defense
			40, 70, // Special Attack & Defense
			110			
		) {}
		#endregion
	}
	#endregion

	//Tauros Pokemon Class
	#region Tauros
	public class Tauros : Pokemon
	{
		#region Tauros Builders
		/// <summary>
		/// Tauros Builder waiting for a Nickname & a Level
		/// </summary>
		public Tauros(string nickname, int level)
		: base(
				128,
				SpecieTauros.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tauros Builder only waiting for a Level
		/// </summary>
		public Tauros(int level)
		: base(
				128,
				SpecieTauros.Instance, // Pokemon Specie
				"Tauros", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tauros Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Tauros() : base(
			128,
			SpecieTauros.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		#endregion
	}
	#endregion
}