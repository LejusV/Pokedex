using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Heliolisk Specie to store common natural stats of all Heliolisks
	#region SpecieHeliolisk
	public class SpecieHeliolisk : PokemonSpecie
	{
#nullable enable
		private static SpecieHeliolisk? _instance = null;
#nullable restore
        public static SpecieHeliolisk Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHeliolisk();
                }
                return _instance;
            }
        }

		#region SpecieHeliolisk Builder
		public SpecieHeliolisk() : base(
			"Heliolisk",
			62, // HPs
			55, 52, // Attack & Defense
			109, 94, // Special Attack & Defense
			109			
		) {}
		#endregion
	}
	#endregion

	//Heliolisk Pokemon Class
	#region Heliolisk
	public class Heliolisk : Pokemon
	{
		#region Heliolisk Builders
		/// <summary>
		/// Heliolisk Builder waiting for a Nickname & a Level
		/// </summary>
		public Heliolisk(string nickname, int level)
		: base(
				695,
				SpecieHeliolisk.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Heliolisk Builder only waiting for a Level
		/// </summary>
		public Heliolisk(int level)
		: base(
				695,
				SpecieHeliolisk.Instance, // Pokemon Specie
				"Heliolisk", level,
				Electric.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Heliolisk Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Heliolisk() : base(
			695,
			SpecieHeliolisk.Instance, // Pokemon Specie
			Electric.Instance, Normal.Instance			
		) {}
		#endregion
	}
	#endregion
}