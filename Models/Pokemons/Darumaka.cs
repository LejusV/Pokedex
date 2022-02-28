using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Darumaka Specie to store common natural stats of all Darumakas
	#region SpecieDarumaka
	public class SpecieDarumaka : PokemonSpecie
	{
#nullable enable
		private static SpecieDarumaka? _instance = null;
#nullable restore
        public static SpecieDarumaka Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDarumaka();
                }
                return _instance;
            }
        }

		#region SpecieDarumaka Builder
		public SpecieDarumaka() : base(
			"Darumaka",
			70, // HPs
			90, 45, // Attack & Defense
			15, 45, // Special Attack & Defense
			50			
		) {}
		#endregion
	}
	#endregion

	//Darumaka Pokemon Class
	#region Darumaka
	public class Darumaka : Pokemon
	{
		#region Darumaka Builders
		/// <summary>
		/// Darumaka Builder waiting for a Nickname & a Level
		/// </summary>
		public Darumaka(string nickname, int level)
		: base(
				554,
				SpecieDarumaka.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Darumaka Builder only waiting for a Level
		/// </summary>
		public Darumaka(int level)
		: base(
				554,
				SpecieDarumaka.Instance, // Pokemon Specie
				"Darumaka", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Darumaka Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Darumaka() : base(
			554,
			SpecieDarumaka.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		#endregion
	}
	#endregion
}