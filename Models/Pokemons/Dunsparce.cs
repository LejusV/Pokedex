using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dunsparce Specie to store common natural stats of all Dunsparces
	#region SpecieDunsparce
	public class SpecieDunsparce : PokemonSpecie
	{
#nullable enable
		private static SpecieDunsparce? _instance = null;
#nullable restore
        public static SpecieDunsparce Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDunsparce();
                }
                return _instance;
            }
        }

		#region SpecieDunsparce Builder
		public SpecieDunsparce() : base(
			"Dunsparce",
			100, // HPs
			70, 70, // Attack & Defense
			65, 65, // Special Attack & Defense
			45			
		) {}
		#endregion
	}
	#endregion

	//Dunsparce Pokemon Class
	#region Dunsparce
	public class Dunsparce : Pokemon
	{
		#region Dunsparce Builders
		/// <summary>
		/// Dunsparce Builder waiting for a Nickname & a Level
		/// </summary>
		public Dunsparce(string nickname, int level)
		: base(
				206,
				SpecieDunsparce.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dunsparce Builder only waiting for a Level
		/// </summary>
		public Dunsparce(int level)
		: base(
				206,
				SpecieDunsparce.Instance, // Pokemon Specie
				"Dunsparce", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dunsparce Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Dunsparce() : base(
			206,
			SpecieDunsparce.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		#endregion
	}
	#endregion
}