using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Hitmontop Specie to store common natural stats of all Hitmontops
	#region SpecieHitmontop
	public class SpecieHitmontop : PokemonSpecie
	{
#nullable enable
		private static SpecieHitmontop? _instance = null;
#nullable restore
        public static SpecieHitmontop Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHitmontop();
                }
                return _instance;
            }
        }

		#region SpecieHitmontop Builder
		public SpecieHitmontop() : base(
			"Hitmontop",
			50, // HPs
			95, 95, // Attack & Defense
			35, 110, // Special Attack & Defense
			70		
		)
		{
			this._height = 14;
			this._weight = 480;
		}
		#endregion
	}
	#endregion

	//Hitmontop Pokemon Class
	#region Hitmontop
	public class Hitmontop : Pokemon
	{
		#region Hitmontop Builders
		/// <summary>
		/// Hitmontop Builder waiting for a Nickname & a Level
		/// </summary>
		public Hitmontop(string nickname, int level)
		: base(
				237,
				SpecieHitmontop.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hitmontop Builder only waiting for a Level
		/// </summary>
		public Hitmontop(int level)
		: base(
				237,
				SpecieHitmontop.Instance, // Pokemon Specie
				"Hitmontop", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hitmontop Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Hitmontop() : base(
			237,
			SpecieHitmontop.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}