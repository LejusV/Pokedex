using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Wigglytuff Specie to store common natural stats of all Wigglytuffs
	#region SpecieWigglytuff
	public class SpecieWigglytuff : PokemonSpecie
	{
#nullable enable
		private static SpecieWigglytuff? _instance = null;
#nullable restore
        public static SpecieWigglytuff Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWigglytuff();
                }
                return _instance;
            }
        }

		#region SpecieWigglytuff Builder
		public SpecieWigglytuff() : base(
			"Wigglytuff",
			140, // HPs
			70, 45, // Attack & Defense
			85, 50, // Special Attack & Defense
			45		
		)
		{
			this._height = 10;
			this._weight = 120;
		}
		#endregion
	}
	#endregion

	//Wigglytuff Pokemon Class
	#region Wigglytuff
	public class Wigglytuff : Pokemon
	{
		#region Wigglytuff Builders
		/// <summary>
		/// Wigglytuff Builder waiting for a Nickname & a Level
		/// </summary>
		public Wigglytuff(string nickname, int level)
		: base(
				40,
				SpecieWigglytuff.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wigglytuff Builder only waiting for a Level
		/// </summary>
		public Wigglytuff(int level)
		: base(
				40,
				SpecieWigglytuff.Instance, // Pokemon Specie
				"Wigglytuff", level,
				Normal.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wigglytuff Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Wigglytuff() : base(
			40,
			SpecieWigglytuff.Instance, // Pokemon Specie
			Normal.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}