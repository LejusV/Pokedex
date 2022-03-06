using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Girafarig Specie to store common natural stats of all Girafarigs
	#region SpecieGirafarig
	public class SpecieGirafarig : PokemonSpecie
	{
#nullable enable
		private static SpecieGirafarig? _instance = null;
#nullable restore
        public static SpecieGirafarig Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGirafarig();
                }
                return _instance;
            }
        }

		#region SpecieGirafarig Builder
		public SpecieGirafarig() : base(
			"Girafarig",
			70, // HPs
			80, 65, // Attack & Defense
			90, 65, // Special Attack & Defense
			85		
		)
		{
			this._height = 15;
			this._weight = 415;
		}
		#endregion
	}
	#endregion

	//Girafarig Pokemon Class
	#region Girafarig
	public class Girafarig : Pokemon
	{
		#region Girafarig Builders
		/// <summary>
		/// Girafarig Builder waiting for a Nickname & a Level
		/// </summary>
		public Girafarig(string nickname, int level)
		: base(
				203,
				SpecieGirafarig.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Girafarig Builder only waiting for a Level
		/// </summary>
		public Girafarig(int level)
		: base(
				203,
				SpecieGirafarig.Instance, // Pokemon Specie
				"Girafarig", level,
				Normal.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Girafarig Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Girafarig() : base(
			203,
			SpecieGirafarig.Instance, // Pokemon Specie
			Normal.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}