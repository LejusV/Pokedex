using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Entei Specie to store common natural stats of all Enteis
	#region SpecieEntei
	public class SpecieEntei : PokemonSpecie
	{
#nullable enable
		private static SpecieEntei? _instance = null;
#nullable restore
        public static SpecieEntei Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEntei();
                }
                return _instance;
            }
        }

		#region SpecieEntei Builder
		public SpecieEntei() : base(
			"Entei",
			115, // HPs
			115, 85, // Attack & Defense
			90, 75, // Special Attack & Defense
			100			
		) {}
		#endregion
	}
	#endregion

	//Entei Pokemon Class
	#region Entei
	public class Entei : Pokemon
	{
		#region Entei Builders
		/// <summary>
		/// Entei Builder waiting for a Nickname & a Level
		/// </summary>
		public Entei(string nickname, int level)
		: base(
				244,
				SpecieEntei.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Entei Builder only waiting for a Level
		/// </summary>
		public Entei(int level)
		: base(
				244,
				SpecieEntei.Instance, // Pokemon Specie
				"Entei", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Entei Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Entei() : base(
			244,
			SpecieEntei.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		#endregion
	}
	#endregion
}