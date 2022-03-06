using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Plusle Specie to store common natural stats of all Plusles
	#region SpeciePlusle
	public class SpeciePlusle : PokemonSpecie
	{
#nullable enable
		private static SpeciePlusle? _instance = null;
#nullable restore
        public static SpeciePlusle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePlusle();
                }
                return _instance;
            }
        }

		#region SpeciePlusle Builder
		public SpeciePlusle() : base(
			"Plusle",
			60, // HPs
			50, 40, // Attack & Defense
			85, 75, // Special Attack & Defense
			95		
		)
		{
			this._height = 4;
			this._weight = 42;
		}
		#endregion
	}
	#endregion

	//Plusle Pokemon Class
	#region Plusle
	public class Plusle : Pokemon
	{
		#region Plusle Builders
		/// <summary>
		/// Plusle Builder waiting for a Nickname & a Level
		/// </summary>
		public Plusle(string nickname, int level)
		: base(
				311,
				SpeciePlusle.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Plusle Builder only waiting for a Level
		/// </summary>
		public Plusle(int level)
		: base(
				311,
				SpeciePlusle.Instance, // Pokemon Specie
				"Plusle", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Plusle Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Plusle() : base(
			311,
			SpeciePlusle.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}