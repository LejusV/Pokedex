using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Wartortle Specie to store common natural stats of all Wartortles
	#region SpecieWartortle
	public class SpecieWartortle : PokemonSpecie
	{
#nullable enable
		private static SpecieWartortle? _instance = null;
#nullable restore
        public static SpecieWartortle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWartortle();
                }
                return _instance;
            }
        }

		#region SpecieWartortle Builder
		public SpecieWartortle() : base(
			"Wartortle",
			59, // HPs
			63, 80, // Attack & Defense
			65, 80, // Special Attack & Defense
			58			
		) {}
		#endregion
	}
	#endregion

	//Wartortle Pokemon Class
	#region Wartortle
	public class Wartortle : Pokemon
	{
		#region Wartortle Builders
		/// <summary>
		/// Wartortle Builder waiting for a Nickname & a Level
		/// </summary>
		public Wartortle(string nickname, int level)
		: base(
				8,
				SpecieWartortle.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wartortle Builder only waiting for a Level
		/// </summary>
		public Wartortle(int level)
		: base(
				8,
				SpecieWartortle.Instance, // Pokemon Specie
				"Wartortle", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wartortle Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Wartortle() : base(
			8,
			SpecieWartortle.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		#endregion
	}
	#endregion
}