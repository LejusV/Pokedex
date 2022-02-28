using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Eevee Specie to store common natural stats of all Eevees
	#region SpecieEevee
	public class SpecieEevee : PokemonSpecie
	{
#nullable enable
		private static SpecieEevee? _instance = null;
#nullable restore
        public static SpecieEevee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEevee();
                }
                return _instance;
            }
        }

		#region SpecieEevee Builder
		public SpecieEevee() : base(
			"Eevee",
			55, // HPs
			55, 50, // Attack & Defense
			45, 65, // Special Attack & Defense
			55			
		) {}
		#endregion
	}
	#endregion

	//Eevee Pokemon Class
	#region Eevee
	public class Eevee : Pokemon
	{
		#region Eevee Builders
		/// <summary>
		/// Eevee Builder waiting for a Nickname & a Level
		/// </summary>
		public Eevee(string nickname, int level)
		: base(
				133,
				SpecieEevee.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eevee Builder only waiting for a Level
		/// </summary>
		public Eevee(int level)
		: base(
				133,
				SpecieEevee.Instance, // Pokemon Specie
				"Eevee", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eevee Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Eevee() : base(
			133,
			SpecieEevee.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		#endregion
	}
	#endregion
}