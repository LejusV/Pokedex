using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Shuckle Specie to store common natural stats of all Shuckles
	#region SpecieShuckle
	public class SpecieShuckle : PokemonSpecie
	{
#nullable enable
		private static SpecieShuckle? _instance = null;
#nullable restore
        public static SpecieShuckle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShuckle();
                }
                return _instance;
            }
        }

		#region SpecieShuckle Builder
		public SpecieShuckle() : base(
			"Shuckle",
			20, // HPs
			10, 230, // Attack & Defense
			10, 230, // Special Attack & Defense
			5		
		)
		{
			this._height = 6;
			this._weight = 205;
		}
		#endregion
	}
	#endregion

	//Shuckle Pokemon Class
	#region Shuckle
	public class Shuckle : Pokemon
	{
		#region Shuckle Builders
		/// <summary>
		/// Shuckle Builder waiting for a Nickname & a Level
		/// </summary>
		public Shuckle(string nickname, int level)
		: base(
				213,
				SpecieShuckle.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shuckle Builder only waiting for a Level
		/// </summary>
		public Shuckle(int level)
		: base(
				213,
				SpecieShuckle.Instance, // Pokemon Specie
				"Shuckle", level,
				Bug.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shuckle Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Shuckle() : base(
			213,
			SpecieShuckle.Instance, // Pokemon Specie
			Bug.Instance, Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}