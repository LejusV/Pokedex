using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Pidgeot Specie to store common natural stats of all Pidgeots
	#region SpeciePidgeot
	public class SpeciePidgeot : PokemonSpecie
	{
#nullable enable
		private static SpeciePidgeot? _instance = null;
#nullable restore
        public static SpeciePidgeot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePidgeot();
                }
                return _instance;
            }
        }

		#region SpeciePidgeot Builder
		public SpeciePidgeot() : base(
			"Pidgeot",
			83, // HPs
			80, 75, // Attack & Defense
			70, 70, // Special Attack & Defense
			101		
		)
		{
			this._height = 15;
			this._weight = 395;
		}
		#endregion
	}
	#endregion

	//Pidgeot Pokemon Class
	#region Pidgeot
	public class Pidgeot : Pokemon
	{
		#region Pidgeot Builders
		/// <summary>
		/// Pidgeot Builder waiting for a Nickname & a Level
		/// </summary>
		public Pidgeot(string nickname, int level)
		: base(
				18,
				SpeciePidgeot.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pidgeot Builder only waiting for a Level
		/// </summary>
		public Pidgeot(int level)
		: base(
				18,
				SpeciePidgeot.Instance, // Pokemon Specie
				"Pidgeot", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pidgeot Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Pidgeot() : base(
			18,
			SpeciePidgeot.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}