using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Heatran Specie to store common natural stats of all Heatrans
	#region SpecieHeatran
	public class SpecieHeatran : PokemonSpecie
	{
#nullable enable
		private static SpecieHeatran? _instance = null;
#nullable restore
        public static SpecieHeatran Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHeatran();
                }
                return _instance;
            }
        }

		#region SpecieHeatran Builder
		public SpecieHeatran() : base(
			"Heatran",
			91, // HPs
			90, 106, // Attack & Defense
			130, 106, // Special Attack & Defense
			77		
		)
		{
			this._height = 17;
			this._weight = 4300;
		}
		#endregion
	}
	#endregion

	//Heatran Pokemon Class
	#region Heatran
	public class Heatran : Pokemon
	{
		#region Heatran Builders
		/// <summary>
		/// Heatran Builder waiting for a Nickname & a Level
		/// </summary>
		public Heatran(string nickname, int level)
		: base(
				485,
				SpecieHeatran.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Heatran Builder only waiting for a Level
		/// </summary>
		public Heatran(int level)
		: base(
				485,
				SpecieHeatran.Instance, // Pokemon Specie
				"Heatran", level,
				Fire.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Heatran Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Heatran() : base(
			485,
			SpecieHeatran.Instance, // Pokemon Specie
			Fire.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}