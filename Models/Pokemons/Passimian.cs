using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Passimian Specie to store common natural stats of all Passimians
	#region SpeciePassimian
	public class SpeciePassimian : PokemonSpecie
	{
#nullable enable
		private static SpeciePassimian? _instance = null;
#nullable restore
        public static SpeciePassimian Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePassimian();
                }
                return _instance;
            }
        }

		#region SpeciePassimian Builder
		public SpeciePassimian() : base(
			"Passimian",
			100, // HPs
			120, 90, // Attack & Defense
			40, 60, // Special Attack & Defense
			80		
		)
		{
			this._height = 20;
			this._weight = 828;
		}
		#endregion
	}
	#endregion

	//Passimian Pokemon Class
	#region Passimian
	public class Passimian : Pokemon
	{
		#region Passimian Builders
		/// <summary>
		/// Passimian Builder waiting for a Nickname & a Level
		/// </summary>
		public Passimian(string nickname, int level)
		: base(
				766,
				SpeciePassimian.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Passimian Builder only waiting for a Level
		/// </summary>
		public Passimian(int level)
		: base(
				766,
				SpeciePassimian.Instance, // Pokemon Specie
				"Passimian", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Passimian Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Passimian() : base(
			766,
			SpeciePassimian.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}