using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Fletchinder Specie to store common natural stats of all Fletchinders
	#region SpecieFletchinder
	public class SpecieFletchinder : PokemonSpecie
	{
#nullable enable
		private static SpecieFletchinder? _instance = null;
#nullable restore
        public static SpecieFletchinder Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFletchinder();
                }
                return _instance;
            }
        }

		#region SpecieFletchinder Builder
		public SpecieFletchinder() : base(
			"Fletchinder",
			62, // HPs
			73, 55, // Attack & Defense
			56, 52, // Special Attack & Defense
			84			
		) {}
		#endregion
	}
	#endregion

	//Fletchinder Pokemon Class
	#region Fletchinder
	public class Fletchinder : Pokemon
	{
		#region Fletchinder Builders
		/// <summary>
		/// Fletchinder Builder waiting for a Nickname & a Level
		/// </summary>
		public Fletchinder(string nickname, int level)
		: base(
				662,
				SpecieFletchinder.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fletchinder Builder only waiting for a Level
		/// </summary>
		public Fletchinder(int level)
		: base(
				662,
				SpecieFletchinder.Instance, // Pokemon Specie
				"Fletchinder", level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fletchinder Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Fletchinder() : base(
			662,
			SpecieFletchinder.Instance, // Pokemon Specie
			Fire.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}