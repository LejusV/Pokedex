using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Banette Specie to store common natural stats of all Banettes
	#region SpecieBanette
	public class SpecieBanette : PokemonSpecie
	{
#nullable enable
		private static SpecieBanette? _instance = null;
#nullable restore
        public static SpecieBanette Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBanette();
                }
                return _instance;
            }
        }

		#region SpecieBanette Builder
		public SpecieBanette() : base(
			"Banette",
			64, // HPs
			115, 65, // Attack & Defense
			83, 63, // Special Attack & Defense
			65			
		) {}
		#endregion
	}
	#endregion

	//Banette Pokemon Class
	#region Banette
	public class Banette : Pokemon
	{
		#region Banette Builders
		/// <summary>
		/// Banette Builder waiting for a Nickname & a Level
		/// </summary>
		public Banette(string nickname, int level)
		: base(
				354,
				SpecieBanette.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Banette Builder only waiting for a Level
		/// </summary>
		public Banette(int level)
		: base(
				354,
				SpecieBanette.Instance, // Pokemon Specie
				"Banette", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Banette Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Banette() : base(
			354,
			SpecieBanette.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
		#endregion
	}
	#endregion
}