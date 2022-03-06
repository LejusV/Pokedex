using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Wooloo Specie to store common natural stats of all Wooloos
	#region SpecieWooloo
	public class SpecieWooloo : PokemonSpecie
	{
#nullable enable
		private static SpecieWooloo? _instance = null;
#nullable restore
        public static SpecieWooloo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWooloo();
                }
                return _instance;
            }
        }

		#region SpecieWooloo Builder
		public SpecieWooloo() : base(
			"Wooloo",
			42, // HPs
			40, 55, // Attack & Defense
			40, 45, // Special Attack & Defense
			48		
		)
		{
			this._height = 6;
			this._weight = 60;
		}
		#endregion
	}
	#endregion

	//Wooloo Pokemon Class
	#region Wooloo
	public class Wooloo : Pokemon
	{
		#region Wooloo Builders
		/// <summary>
		/// Wooloo Builder waiting for a Nickname & a Level
		/// </summary>
		public Wooloo(string nickname, int level)
		: base(
				831,
				SpecieWooloo.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wooloo Builder only waiting for a Level
		/// </summary>
		public Wooloo(int level)
		: base(
				831,
				SpecieWooloo.Instance, // Pokemon Specie
				"Wooloo", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wooloo Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Wooloo() : base(
			831,
			SpecieWooloo.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}