using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Carkol Specie to store common natural stats of all Carkols
	#region SpecieCarkol
	public class SpecieCarkol : PokemonSpecie
	{
#nullable enable
		private static SpecieCarkol? _instance = null;
#nullable restore
        public static SpecieCarkol Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCarkol();
                }
                return _instance;
            }
        }

		#region SpecieCarkol Builder
		public SpecieCarkol() : base(
			"Carkol",
			80, // HPs
			60, 90, // Attack & Defense
			60, 70, // Special Attack & Defense
			50		
		)
		{
			this._height = 11;
			this._weight = 780;
		}
		#endregion
	}
	#endregion

	//Carkol Pokemon Class
	#region Carkol
	public class Carkol : Pokemon
	{
		#region Carkol Builders
		/// <summary>
		/// Carkol Builder waiting for a Nickname & a Level
		/// </summary>
		public Carkol(string nickname, int level)
		: base(
				838,
				SpecieCarkol.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carkol Builder only waiting for a Level
		/// </summary>
		public Carkol(int level)
		: base(
				838,
				SpecieCarkol.Instance, // Pokemon Specie
				"Carkol", level,
				Rock.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carkol Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Carkol() : base(
			838,
			SpecieCarkol.Instance, // Pokemon Specie
			Rock.Instance, Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}