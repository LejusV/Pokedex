using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mr-Rime Specie to store common natural stats of all Mr-Rimes
	#region SpecieMr-Rime
	public class SpecieMrRime : PokemonSpecie
	{
#nullable enable
		private static SpecieMrRime? _instance = null;
#nullable restore
        public static SpecieMrRime Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMrRime();
                }
                return _instance;
            }
        }

		#region SpecieMr-Rime Builder
		public SpecieMrRime() : base(
			"Mr-Rime",
			80, // HPs
			85, 75, // Attack & Defense
			110, 100, // Special Attack & Defense
			70			
		) {}
		#endregion
	}
	#endregion

	//Mr-Rime Pokemon Class
	#region Mr-Rime
	public class MrRime : Pokemon
	{
		#region Mr-Rime Builders
		/// <summary>
		/// Mr-Rime Builder waiting for a Nickname & a Level
		/// </summary>
		public MrRime(string nickname, int level)
		: base(
				866,
				SpecieMrRime.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mr-Rime Builder only waiting for a Level
		/// </summary>
		public MrRime(int level)
		: base(
				866,
				SpecieMrRime.Instance, // Pokemon Specie
				"Mr-Rime", level,
				Ice.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mr-Rime Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public MrRime() : base(
			866,
			SpecieMrRime.Instance, // Pokemon Specie
			Ice.Instance, Psychic.Instance			
		) {}
		#endregion
	}
	#endregion
}