using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Fennekin Specie to store common natural stats of all Fennekins
	#region SpecieFennekin
	public class SpecieFennekin : PokemonSpecie
	{
#nullable enable
		private static SpecieFennekin? _instance = null;
#nullable restore
        public static SpecieFennekin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFennekin();
                }
                return _instance;
            }
        }

		#region SpecieFennekin Builder
		public SpecieFennekin() : base(
			"Fennekin",
			40, // HPs
			45, 40, // Attack & Defense
			62, 60, // Special Attack & Defense
			60		
		)
		{
			this._height = 4;
			this._weight = 94;
		}
		#endregion
	}
	#endregion

	//Fennekin Pokemon Class
	#region Fennekin
	public class Fennekin : Pokemon
	{
		#region Fennekin Builders
		/// <summary>
		/// Fennekin Builder waiting for a Nickname & a Level
		/// </summary>
		public Fennekin(string nickname, int level)
		: base(
				653,
				SpecieFennekin.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fennekin Builder only waiting for a Level
		/// </summary>
		public Fennekin(int level)
		: base(
				653,
				SpecieFennekin.Instance, // Pokemon Specie
				"Fennekin", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fennekin Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Fennekin() : base(
			653,
			SpecieFennekin.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}