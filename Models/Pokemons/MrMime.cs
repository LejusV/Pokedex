using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mr-Mime Specie to store common natural stats of all Mr-Mimes
	#region SpecieMr-Mime
	public class SpecieMrMime : PokemonSpecie
	{
#nullable enable
		private static SpecieMrMime? _instance = null;
#nullable restore
        public static SpecieMrMime Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMrMime();
                }
                return _instance;
            }
        }

		#region SpecieMr-Mime Builder
		public SpecieMrMime() : base(
			"Mr-Mime",
			40, // HPs
			45, 65, // Attack & Defense
			100, 120, // Special Attack & Defense
			90			
		) {}
		#endregion
	}
	#endregion

	//Mr-Mime Pokemon Class
	#region Mr-Mime
	public class MrMime : Pokemon
	{
		#region Mr-Mime Builders
		/// <summary>
		/// Mr-Mime Builder waiting for a Nickname & a Level
		/// </summary>
		public MrMime(string nickname, int level)
		: base(
				122,
				SpecieMrMime.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mr-Mime Builder only waiting for a Level
		/// </summary>
		public MrMime(int level)
		: base(
				122,
				SpecieMrMime.Instance, // Pokemon Specie
				"Mr-Mime", level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mr-Mime Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public MrMime() : base(
			122,
			SpecieMrMime.Instance, // Pokemon Specie
			Psychic.Instance, Fairy.Instance			
		) {}
		#endregion
	}
	#endregion
}