using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Burmy Specie to store common natural stats of all Burmys
	#region SpecieBurmy
	public class SpecieBurmy : PokemonSpecie
	{
#nullable enable
		private static SpecieBurmy? _instance = null;
#nullable restore
        public static SpecieBurmy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBurmy();
                }
                return _instance;
            }
        }

		#region SpecieBurmy Builder
		public SpecieBurmy() : base(
			"Burmy",
			40, // HPs
			29, 45, // Attack & Defense
			29, 45, // Special Attack & Defense
			36			
		) {}
		#endregion
	}
	#endregion

	//Burmy Pokemon Class
	#region Burmy
	public class Burmy : Pokemon
	{
		#region Burmy Builders
		/// <summary>
		/// Burmy Builder waiting for a Nickname & a Level
		/// </summary>
		public Burmy(string nickname, int level)
		: base(
				412,
				SpecieBurmy.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Burmy Builder only waiting for a Level
		/// </summary>
		public Burmy(int level)
		: base(
				412,
				SpecieBurmy.Instance, // Pokemon Specie
				"Burmy", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Burmy Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Burmy() : base(
			412,
			SpecieBurmy.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
		#endregion
	}
	#endregion
}