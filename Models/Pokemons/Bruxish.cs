using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Bruxish Specie to store common natural stats of all Bruxishs
	#region SpecieBruxish
	public class SpecieBruxish : PokemonSpecie
	{
#nullable enable
		private static SpecieBruxish? _instance = null;
#nullable restore
        public static SpecieBruxish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBruxish();
                }
                return _instance;
            }
        }

		#region SpecieBruxish Builder
		public SpecieBruxish() : base(
			"Bruxish",
			68, // HPs
			105, 70, // Attack & Defense
			70, 70, // Special Attack & Defense
			92			
		) {}
		#endregion
	}
	#endregion

	//Bruxish Pokemon Class
	#region Bruxish
	public class Bruxish : Pokemon
	{
		#region Bruxish Builders
		/// <summary>
		/// Bruxish Builder waiting for a Nickname & a Level
		/// </summary>
		public Bruxish(string nickname, int level)
		: base(
				779,
				SpecieBruxish.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bruxish Builder only waiting for a Level
		/// </summary>
		public Bruxish(int level)
		: base(
				779,
				SpecieBruxish.Instance, // Pokemon Specie
				"Bruxish", level,
				Water.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bruxish Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Bruxish() : base(
			779,
			SpecieBruxish.Instance, // Pokemon Specie
			Water.Instance, Psychic.Instance			
		) {}
		#endregion
	}
	#endregion
}