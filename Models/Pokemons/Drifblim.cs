using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Drifblim Specie to store common natural stats of all Drifblims
	#region SpecieDrifblim
	public class SpecieDrifblim : PokemonSpecie
	{
#nullable enable
		private static SpecieDrifblim? _instance = null;
#nullable restore
        public static SpecieDrifblim Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDrifblim();
                }
                return _instance;
            }
        }

		#region SpecieDrifblim Builder
		public SpecieDrifblim() : base(
			"Drifblim",
			150, // HPs
			80, 44, // Attack & Defense
			90, 54, // Special Attack & Defense
			80			
		) {}
		#endregion
	}
	#endregion

	//Drifblim Pokemon Class
	#region Drifblim
	public class Drifblim : Pokemon
	{
		#region Drifblim Builders
		/// <summary>
		/// Drifblim Builder waiting for a Nickname & a Level
		/// </summary>
		public Drifblim(string nickname, int level)
		: base(
				426,
				SpecieDrifblim.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drifblim Builder only waiting for a Level
		/// </summary>
		public Drifblim(int level)
		: base(
				426,
				SpecieDrifblim.Instance, // Pokemon Specie
				"Drifblim", level,
				Ghost.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drifblim Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Drifblim() : base(
			426,
			SpecieDrifblim.Instance, // Pokemon Specie
			Ghost.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}