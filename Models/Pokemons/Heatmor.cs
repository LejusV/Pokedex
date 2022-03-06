using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Heatmor Specie to store common natural stats of all Heatmors
	#region SpecieHeatmor
	public class SpecieHeatmor : PokemonSpecie
	{
#nullable enable
		private static SpecieHeatmor? _instance = null;
#nullable restore
        public static SpecieHeatmor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHeatmor();
                }
                return _instance;
            }
        }

		#region SpecieHeatmor Builder
		public SpecieHeatmor() : base(
			"Heatmor",
			85, // HPs
			97, 66, // Attack & Defense
			105, 66, // Special Attack & Defense
			65		
		)
		{
			this._height = 14;
			this._weight = 580;
		}
		#endregion
	}
	#endregion

	//Heatmor Pokemon Class
	#region Heatmor
	public class Heatmor : Pokemon
	{
		#region Heatmor Builders
		/// <summary>
		/// Heatmor Builder waiting for a Nickname & a Level
		/// </summary>
		public Heatmor(string nickname, int level)
		: base(
				631,
				SpecieHeatmor.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Heatmor Builder only waiting for a Level
		/// </summary>
		public Heatmor(int level)
		: base(
				631,
				SpecieHeatmor.Instance, // Pokemon Specie
				"Heatmor", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Heatmor Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Heatmor() : base(
			631,
			SpecieHeatmor.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}