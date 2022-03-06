using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Mismagius Specie to store common natural stats of all Mismagiuss
	#region SpecieMismagius
	public class SpecieMismagius : PokemonSpecie
	{
#nullable enable
		private static SpecieMismagius? _instance = null;
#nullable restore
        public static SpecieMismagius Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMismagius();
                }
                return _instance;
            }
        }

		#region SpecieMismagius Builder
		public SpecieMismagius() : base(
			"Mismagius",
			60, // HPs
			60, 60, // Attack & Defense
			105, 105, // Special Attack & Defense
			105		
		)
		{
			this._height = 9;
			this._weight = 44;
		}
		#endregion
	}
	#endregion

	//Mismagius Pokemon Class
	#region Mismagius
	public class Mismagius : Pokemon
	{
		#region Mismagius Builders
		/// <summary>
		/// Mismagius Builder waiting for a Nickname & a Level
		/// </summary>
		public Mismagius(string nickname, int level)
		: base(
				429,
				SpecieMismagius.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mismagius Builder only waiting for a Level
		/// </summary>
		public Mismagius(int level)
		: base(
				429,
				SpecieMismagius.Instance, // Pokemon Specie
				"Mismagius", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mismagius Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Mismagius() : base(
			429,
			SpecieMismagius.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}