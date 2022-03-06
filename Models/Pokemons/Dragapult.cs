using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Dragapult Specie to store common natural stats of all Dragapults
	#region SpecieDragapult
	public class SpecieDragapult : PokemonSpecie
	{
#nullable enable
		private static SpecieDragapult? _instance = null;
#nullable restore
        public static SpecieDragapult Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDragapult();
                }
                return _instance;
            }
        }

		#region SpecieDragapult Builder
		public SpecieDragapult() : base(
			"Dragapult",
			88, // HPs
			120, 75, // Attack & Defense
			100, 75, // Special Attack & Defense
			142		
		)
		{
			this._height = 30;
			this._weight = 500;
		}
		#endregion
	}
	#endregion

	//Dragapult Pokemon Class
	#region Dragapult
	public class Dragapult : Pokemon
	{
		#region Dragapult Builders
		/// <summary>
		/// Dragapult Builder waiting for a Nickname & a Level
		/// </summary>
		public Dragapult(string nickname, int level)
		: base(
				887,
				SpecieDragapult.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dragapult Builder only waiting for a Level
		/// </summary>
		public Dragapult(int level)
		: base(
				887,
				SpecieDragapult.Instance, // Pokemon Specie
				"Dragapult", level,
				Dragon.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dragapult Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Dragapult() : base(
			887,
			SpecieDragapult.Instance, // Pokemon Specie
			Dragon.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}