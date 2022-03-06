using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Sneasel Specie to store common natural stats of all Sneasels
	#region SpecieSneasel
	public class SpecieSneasel : PokemonSpecie
	{
#nullable enable
		private static SpecieSneasel? _instance = null;
#nullable restore
        public static SpecieSneasel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSneasel();
                }
                return _instance;
            }
        }

		#region SpecieSneasel Builder
		public SpecieSneasel() : base(
			"Sneasel",
			55, // HPs
			95, 55, // Attack & Defense
			35, 75, // Special Attack & Defense
			115		
		)
		{
			this._height = 9;
			this._weight = 280;
		}
		#endregion
	}
	#endregion

	//Sneasel Pokemon Class
	#region Sneasel
	public class Sneasel : Pokemon
	{
		#region Sneasel Builders
		/// <summary>
		/// Sneasel Builder waiting for a Nickname & a Level
		/// </summary>
		public Sneasel(string nickname, int level)
		: base(
				215,
				SpecieSneasel.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sneasel Builder only waiting for a Level
		/// </summary>
		public Sneasel(int level)
		: base(
				215,
				SpecieSneasel.Instance, // Pokemon Specie
				"Sneasel", level,
				Dark.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sneasel Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Sneasel() : base(
			215,
			SpecieSneasel.Instance, // Pokemon Specie
			Dark.Instance, Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}