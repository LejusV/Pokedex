using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Amoonguss Specie to store common natural stats of all Amoongusss
	#region SpecieAmoonguss
	public class SpecieAmoonguss : PokemonSpecie
	{
#nullable enable
		private static SpecieAmoonguss? _instance = null;
#nullable restore
        public static SpecieAmoonguss Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAmoonguss();
                }
                return _instance;
            }
        }

		#region SpecieAmoonguss Builder
		public SpecieAmoonguss() : base(
			"Amoonguss",
			114, // HPs
			85, 70, // Attack & Defense
			85, 80, // Special Attack & Defense
			30			
		) {}
		#endregion
	}
	#endregion

	//Amoonguss Pokemon Class
	#region Amoonguss
	public class Amoonguss : Pokemon
	{
		#region Amoonguss Builders
		/// <summary>
		/// Amoonguss Builder waiting for a Nickname & a Level
		/// </summary>
		public Amoonguss(string nickname, int level)
		: base(
				591,
				SpecieAmoonguss.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Amoonguss Builder only waiting for a Level
		/// </summary>
		public Amoonguss(int level)
		: base(
				591,
				SpecieAmoonguss.Instance, // Pokemon Specie
				"Amoonguss", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Amoonguss Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Amoonguss() : base(
			591,
			SpecieAmoonguss.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
		#endregion
	}
	#endregion
}