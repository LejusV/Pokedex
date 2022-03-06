using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Impidimp Specie to store common natural stats of all Impidimps
	#region SpecieImpidimp
	public class SpecieImpidimp : PokemonSpecie
	{
#nullable enable
		private static SpecieImpidimp? _instance = null;
#nullable restore
        public static SpecieImpidimp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieImpidimp();
                }
                return _instance;
            }
        }

		#region SpecieImpidimp Builder
		public SpecieImpidimp() : base(
			"Impidimp",
			45, // HPs
			45, 30, // Attack & Defense
			55, 40, // Special Attack & Defense
			50		
		)
		{
			this._height = 4;
			this._weight = 55;
		}
		#endregion
	}
	#endregion

	//Impidimp Pokemon Class
	#region Impidimp
	public class Impidimp : Pokemon
	{
		#region Impidimp Builders
		/// <summary>
		/// Impidimp Builder waiting for a Nickname & a Level
		/// </summary>
		public Impidimp(string nickname, int level)
		: base(
				859,
				SpecieImpidimp.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Impidimp Builder only waiting for a Level
		/// </summary>
		public Impidimp(int level)
		: base(
				859,
				SpecieImpidimp.Instance, // Pokemon Specie
				"Impidimp", level,
				Dark.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Impidimp Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Impidimp() : base(
			859,
			SpecieImpidimp.Instance, // Pokemon Specie
			Dark.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}