using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Weepinbell Specie to store common natural stats of all Weepinbells
	#region SpecieWeepinbell
	public class SpecieWeepinbell : PokemonSpecie
	{
#nullable enable
		private static SpecieWeepinbell? _instance = null;
#nullable restore
        public static SpecieWeepinbell Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWeepinbell();
                }
                return _instance;
            }
        }

		#region SpecieWeepinbell Builder
		public SpecieWeepinbell() : base(
			"Weepinbell",
			65, // HPs
			90, 50, // Attack & Defense
			85, 45, // Special Attack & Defense
			55		
		)
		{
			this._height = 10;
			this._weight = 64;
		}
		#endregion
	}
	#endregion

	//Weepinbell Pokemon Class
	#region Weepinbell
	public class Weepinbell : Pokemon
	{
		#region Weepinbell Builders
		/// <summary>
		/// Weepinbell Builder waiting for a Nickname & a Level
		/// </summary>
		public Weepinbell(string nickname, int level)
		: base(
				70,
				SpecieWeepinbell.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Weepinbell Builder only waiting for a Level
		/// </summary>
		public Weepinbell(int level)
		: base(
				70,
				SpecieWeepinbell.Instance, // Pokemon Specie
				"Weepinbell", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Weepinbell Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Weepinbell() : base(
			70,
			SpecieWeepinbell.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}