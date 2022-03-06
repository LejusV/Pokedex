using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Noibat Specie to store common natural stats of all Noibats
	#region SpecieNoibat
	public class SpecieNoibat : PokemonSpecie
	{
#nullable enable
		private static SpecieNoibat? _instance = null;
#nullable restore
        public static SpecieNoibat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNoibat();
                }
                return _instance;
            }
        }

		#region SpecieNoibat Builder
		public SpecieNoibat() : base(
			"Noibat",
			40, // HPs
			30, 35, // Attack & Defense
			45, 40, // Special Attack & Defense
			55		
		)
		{
			this._height = 5;
			this._weight = 80;
		}
		#endregion
	}
	#endregion

	//Noibat Pokemon Class
	#region Noibat
	public class Noibat : Pokemon
	{
		#region Noibat Builders
		/// <summary>
		/// Noibat Builder waiting for a Nickname & a Level
		/// </summary>
		public Noibat(string nickname, int level)
		: base(
				714,
				SpecieNoibat.Instance, // Pokemon Specie
				nickname, level,
				Flying.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Noibat Builder only waiting for a Level
		/// </summary>
		public Noibat(int level)
		: base(
				714,
				SpecieNoibat.Instance, // Pokemon Specie
				"Noibat", level,
				Flying.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Noibat Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Noibat() : base(
			714,
			SpecieNoibat.Instance, // Pokemon Specie
			Flying.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}