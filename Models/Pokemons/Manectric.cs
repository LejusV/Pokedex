using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Manectric Specie to store common natural stats of all Manectrics
	#region SpecieManectric
	public class SpecieManectric : PokemonSpecie
	{
#nullable enable
		private static SpecieManectric? _instance = null;
#nullable restore
        public static SpecieManectric Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieManectric();
                }
                return _instance;
            }
        }

		#region SpecieManectric Builder
		public SpecieManectric() : base(
			"Manectric",
			70, // HPs
			75, 60, // Attack & Defense
			105, 60, // Special Attack & Defense
			105			
		) {}
		#endregion
	}
	#endregion

	//Manectric Pokemon Class
	#region Manectric
	public class Manectric : Pokemon
	{
		#region Manectric Builders
		/// <summary>
		/// Manectric Builder waiting for a Nickname & a Level
		/// </summary>
		public Manectric(string nickname, int level)
		: base(
				310,
				SpecieManectric.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Manectric Builder only waiting for a Level
		/// </summary>
		public Manectric(int level)
		: base(
				310,
				SpecieManectric.Instance, // Pokemon Specie
				"Manectric", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Manectric Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Manectric() : base(
			310,
			SpecieManectric.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		#endregion
	}
	#endregion
}