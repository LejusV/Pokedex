using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Rotom Specie to store common natural stats of all Rotoms
	#region SpecieRotom
	public class SpecieRotom : PokemonSpecie
	{
#nullable enable
		private static SpecieRotom? _instance = null;
#nullable restore
        public static SpecieRotom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRotom();
                }
                return _instance;
            }
        }

		#region SpecieRotom Builder
		public SpecieRotom() : base(
			"Rotom",
			50, // HPs
			50, 77, // Attack & Defense
			95, 77, // Special Attack & Defense
			91		
		)
		{
			this._height = 3;
			this._weight = 3;
		}
		#endregion
	}
	#endregion

	//Rotom Pokemon Class
	#region Rotom
	public class Rotom : Pokemon
	{
		#region Rotom Builders
		/// <summary>
		/// Rotom Builder waiting for a Nickname & a Level
		/// </summary>
		public Rotom(string nickname, int level)
		: base(
				479,
				SpecieRotom.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rotom Builder only waiting for a Level
		/// </summary>
		public Rotom(int level)
		: base(
				479,
				SpecieRotom.Instance, // Pokemon Specie
				"Rotom", level,
				Electric.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rotom Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Rotom() : base(
			479,
			SpecieRotom.Instance, // Pokemon Specie
			Electric.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}