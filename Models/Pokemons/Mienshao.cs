using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mienshao Specie to store common natural stats of all Mienshaos
	#region SpecieMienshao
	public class SpecieMienshao : PokemonSpecie
	{
#nullable enable
		private static SpecieMienshao? _instance = null;
#nullable restore
        public static SpecieMienshao Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMienshao();
                }
                return _instance;
            }
        }

		#region SpecieMienshao Builder
		public SpecieMienshao() : base(
			"Mienshao",
			65, // HPs
			125, 60, // Attack & Defense
			95, 60, // Special Attack & Defense
			105			
		) {}
		#endregion
	}
	#endregion

	//Mienshao Pokemon Class
	#region Mienshao
	public class Mienshao : Pokemon
	{
		#region Mienshao Builders
		/// <summary>
		/// Mienshao Builder waiting for a Nickname & a Level
		/// </summary>
		public Mienshao(string nickname, int level)
		: base(
				620,
				SpecieMienshao.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mienshao Builder only waiting for a Level
		/// </summary>
		public Mienshao(int level)
		: base(
				620,
				SpecieMienshao.Instance, // Pokemon Specie
				"Mienshao", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mienshao Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Mienshao() : base(
			620,
			SpecieMienshao.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		#endregion
	}
	#endregion
}