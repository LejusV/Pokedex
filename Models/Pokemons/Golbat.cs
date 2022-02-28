using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Golbat Specie to store common natural stats of all Golbats
	#region SpecieGolbat
	public class SpecieGolbat : PokemonSpecie
	{
#nullable enable
		private static SpecieGolbat? _instance = null;
#nullable restore
        public static SpecieGolbat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGolbat();
                }
                return _instance;
            }
        }

		#region SpecieGolbat Builder
		public SpecieGolbat() : base(
			"Golbat",
			75, // HPs
			80, 70, // Attack & Defense
			65, 75, // Special Attack & Defense
			90			
		) {}
		#endregion
	}
	#endregion

	//Golbat Pokemon Class
	#region Golbat
	public class Golbat : Pokemon
	{
		#region Golbat Builders
		/// <summary>
		/// Golbat Builder waiting for a Nickname & a Level
		/// </summary>
		public Golbat(string nickname, int level)
		: base(
				42,
				SpecieGolbat.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golbat Builder only waiting for a Level
		/// </summary>
		public Golbat(int level)
		: base(
				42,
				SpecieGolbat.Instance, // Pokemon Specie
				"Golbat", level,
				Poison.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golbat Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Golbat() : base(
			42,
			SpecieGolbat.Instance, // Pokemon Specie
			Poison.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}