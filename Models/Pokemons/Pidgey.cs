using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Pidgey Specie to store common natural stats of all Pidgeys
	#region SpeciePidgey
	public class SpeciePidgey : PokemonSpecie
	{
#nullable enable
		private static SpeciePidgey? _instance = null;
#nullable restore
        public static SpeciePidgey Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePidgey();
                }
                return _instance;
            }
        }

		#region SpeciePidgey Builder
		public SpeciePidgey() : base(
			"Pidgey",
			40, // HPs
			45, 40, // Attack & Defense
			35, 35, // Special Attack & Defense
			56		
		)
		{
			this._height = 3;
			this._weight = 18;
		}
		#endregion
	}
	#endregion

	//Pidgey Pokemon Class
	#region Pidgey
	public class Pidgey : Pokemon
	{
		#region Pidgey Builders
		/// <summary>
		/// Pidgey Builder waiting for a Nickname & a Level
		/// </summary>
		public Pidgey(string nickname, int level)
		: base(
				16,
				SpeciePidgey.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pidgey Builder only waiting for a Level
		/// </summary>
		public Pidgey(int level)
		: base(
				16,
				SpeciePidgey.Instance, // Pokemon Specie
				"Pidgey", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pidgey Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Pidgey() : base(
			16,
			SpeciePidgey.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}