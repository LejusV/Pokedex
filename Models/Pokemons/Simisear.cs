using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Simisear Specie to store common natural stats of all Simisears
	#region SpecieSimisear
	public class SpecieSimisear : PokemonSpecie
	{
#nullable enable
		private static SpecieSimisear? _instance = null;
#nullable restore
        public static SpecieSimisear Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSimisear();
                }
                return _instance;
            }
        }

		#region SpecieSimisear Builder
		public SpecieSimisear() : base(
			"Simisear",
			75, // HPs
			98, 63, // Attack & Defense
			98, 63, // Special Attack & Defense
			101		
		)
		{
			this._height = 10;
			this._weight = 280;
		}
		#endregion
	}
	#endregion

	//Simisear Pokemon Class
	#region Simisear
	public class Simisear : Pokemon
	{
		#region Simisear Builders
		/// <summary>
		/// Simisear Builder waiting for a Nickname & a Level
		/// </summary>
		public Simisear(string nickname, int level)
		: base(
				514,
				SpecieSimisear.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Simisear Builder only waiting for a Level
		/// </summary>
		public Simisear(int level)
		: base(
				514,
				SpecieSimisear.Instance, // Pokemon Specie
				"Simisear", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Simisear Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Simisear() : base(
			514,
			SpecieSimisear.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}