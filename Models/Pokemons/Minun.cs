using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Minun Specie to store common natural stats of all Minuns
	#region SpecieMinun
	public class SpecieMinun : PokemonSpecie
	{
#nullable enable
		private static SpecieMinun? _instance = null;
#nullable restore
        public static SpecieMinun Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMinun();
                }
                return _instance;
            }
        }

		#region SpecieMinun Builder
		public SpecieMinun() : base(
			"Minun",
			0.4,
			4.2,
			60, // HPs
			40, 50, // Attack & Defense
			75, 85, // Special Attack & Defense
			95		
		)
		{}
		#endregion
	}
	#endregion

	//Minun Pokemon Class
	#region Minun
	public class Minun : Pokemon
	{
		#region Minun Builders
		/// <summary>
		/// Minun Builder waiting for a Nickname & a Level
		/// </summary>
		public Minun(string nickname, int level)
		: base(
				312,
				SpecieMinun.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Minun Builder only waiting for a Level
		/// </summary>
		public Minun(int level)
		: base(
				312,
				SpecieMinun.Instance, // Pokemon Specie
				"Minun", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Minun Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Minun() : base(
			312,
			SpecieMinun.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}