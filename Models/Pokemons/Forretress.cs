using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Forretress Specie to store common natural stats of all Forretresss
	#region SpecieForretress
	public class SpecieForretress : PokemonSpecie
	{
#nullable enable
		private static SpecieForretress? _instance = null;
#nullable restore
        public static SpecieForretress Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieForretress();
                }
                return _instance;
            }
        }

		#region SpecieForretress Builder
		public SpecieForretress() : base(
			"Forretress",
			75, // HPs
			90, 140, // Attack & Defense
			60, 60, // Special Attack & Defense
			40			
		) {}
		#endregion
	}
	#endregion

	//Forretress Pokemon Class
	#region Forretress
	public class Forretress : Pokemon
	{
		#region Forretress Builders
		/// <summary>
		/// Forretress Builder waiting for a Nickname & a Level
		/// </summary>
		public Forretress(string nickname, int level)
		: base(
				205,
				SpecieForretress.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Forretress Builder only waiting for a Level
		/// </summary>
		public Forretress(int level)
		: base(
				205,
				SpecieForretress.Instance, // Pokemon Specie
				"Forretress", level,
				Bug.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Forretress Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Forretress() : base(
			205,
			SpecieForretress.Instance, // Pokemon Specie
			Bug.Instance, Steel.Instance			
		) {}
		#endregion
	}
	#endregion
}