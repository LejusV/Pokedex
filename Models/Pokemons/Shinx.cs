using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Shinx Specie to store common natural stats of all Shinxs
	#region SpecieShinx
	public class SpecieShinx : PokemonSpecie
	{
#nullable enable
		private static SpecieShinx? _instance = null;
#nullable restore
        public static SpecieShinx Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShinx();
                }
                return _instance;
            }
        }

		#region SpecieShinx Builder
		public SpecieShinx() : base(
			"Shinx",
			45, // HPs
			65, 34, // Attack & Defense
			40, 34, // Special Attack & Defense
			45		
		)
		{
			this._height = 5;
			this._weight = 95;
		}
		#endregion
	}
	#endregion

	//Shinx Pokemon Class
	#region Shinx
	public class Shinx : Pokemon
	{
		#region Shinx Builders
		/// <summary>
		/// Shinx Builder waiting for a Nickname & a Level
		/// </summary>
		public Shinx(string nickname, int level)
		: base(
				403,
				SpecieShinx.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shinx Builder only waiting for a Level
		/// </summary>
		public Shinx(int level)
		: base(
				403,
				SpecieShinx.Instance, // Pokemon Specie
				"Shinx", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shinx Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Shinx() : base(
			403,
			SpecieShinx.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}