using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Drifloon Specie to store common natural stats of all Drifloons
	#region SpecieDrifloon
	public class SpecieDrifloon : PokemonSpecie
	{
#nullable enable
		private static SpecieDrifloon? _instance = null;
#nullable restore
        public static SpecieDrifloon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDrifloon();
                }
                return _instance;
            }
        }

		#region SpecieDrifloon Builder
		public SpecieDrifloon() : base(
			"Drifloon",
			90, // HPs
			50, 34, // Attack & Defense
			60, 44, // Special Attack & Defense
			70		
		)
		{
			this._height = 4;
			this._weight = 12;
		}
		#endregion
	}
	#endregion

	//Drifloon Pokemon Class
	#region Drifloon
	public class Drifloon : Pokemon
	{
		#region Drifloon Builders
		/// <summary>
		/// Drifloon Builder waiting for a Nickname & a Level
		/// </summary>
		public Drifloon(string nickname, int level)
		: base(
				425,
				SpecieDrifloon.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drifloon Builder only waiting for a Level
		/// </summary>
		public Drifloon(int level)
		: base(
				425,
				SpecieDrifloon.Instance, // Pokemon Specie
				"Drifloon", level,
				Ghost.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drifloon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Drifloon() : base(
			425,
			SpecieDrifloon.Instance, // Pokemon Specie
			Ghost.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}