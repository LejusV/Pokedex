using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Kricketune Specie to store common natural stats of all Kricketunes
	#region SpecieKricketune
	public class SpecieKricketune : PokemonSpecie
	{
#nullable enable
		private static SpecieKricketune? _instance = null;
#nullable restore
        public static SpecieKricketune Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKricketune();
                }
                return _instance;
            }
        }

		#region SpecieKricketune Builder
		public SpecieKricketune() : base(
			"Kricketune",
			77, // HPs
			85, 51, // Attack & Defense
			55, 51, // Special Attack & Defense
			65		
		)
		{
			this._height = 10;
			this._weight = 255;
		}
		#endregion
	}
	#endregion

	//Kricketune Pokemon Class
	#region Kricketune
	public class Kricketune : Pokemon
	{
		#region Kricketune Builders
		/// <summary>
		/// Kricketune Builder waiting for a Nickname & a Level
		/// </summary>
		public Kricketune(string nickname, int level)
		: base(
				402,
				SpecieKricketune.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kricketune Builder only waiting for a Level
		/// </summary>
		public Kricketune(int level)
		: base(
				402,
				SpecieKricketune.Instance, // Pokemon Specie
				"Kricketune", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kricketune Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Kricketune() : base(
			402,
			SpecieKricketune.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}