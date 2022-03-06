using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Minccino Specie to store common natural stats of all Minccinos
	#region SpecieMinccino
	public class SpecieMinccino : PokemonSpecie
	{
#nullable enable
		private static SpecieMinccino? _instance = null;
#nullable restore
        public static SpecieMinccino Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMinccino();
                }
                return _instance;
            }
        }

		#region SpecieMinccino Builder
		public SpecieMinccino() : base(
			"Minccino",
			55, // HPs
			50, 40, // Attack & Defense
			40, 40, // Special Attack & Defense
			75		
		)
		{
			this._height = 4;
			this._weight = 58;
		}
		#endregion
	}
	#endregion

	//Minccino Pokemon Class
	#region Minccino
	public class Minccino : Pokemon
	{
		#region Minccino Builders
		/// <summary>
		/// Minccino Builder waiting for a Nickname & a Level
		/// </summary>
		public Minccino(string nickname, int level)
		: base(
				572,
				SpecieMinccino.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Minccino Builder only waiting for a Level
		/// </summary>
		public Minccino(int level)
		: base(
				572,
				SpecieMinccino.Instance, // Pokemon Specie
				"Minccino", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Minccino Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Minccino() : base(
			572,
			SpecieMinccino.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}