using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Misdreavus Specie to store common natural stats of all Misdreavuss
	#region SpecieMisdreavus
	public class SpecieMisdreavus : PokemonSpecie
	{
#nullable enable
		private static SpecieMisdreavus? _instance = null;
#nullable restore
        public static SpecieMisdreavus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMisdreavus();
                }
                return _instance;
            }
        }

		#region SpecieMisdreavus Builder
		public SpecieMisdreavus() : base(
			"Misdreavus",
			60, // HPs
			60, 60, // Attack & Defense
			85, 85, // Special Attack & Defense
			85		
		)
		{
			this._height = 7;
			this._weight = 10;
		}
		#endregion
	}
	#endregion

	//Misdreavus Pokemon Class
	#region Misdreavus
	public class Misdreavus : Pokemon
	{
		#region Misdreavus Builders
		/// <summary>
		/// Misdreavus Builder waiting for a Nickname & a Level
		/// </summary>
		public Misdreavus(string nickname, int level)
		: base(
				200,
				SpecieMisdreavus.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Misdreavus Builder only waiting for a Level
		/// </summary>
		public Misdreavus(int level)
		: base(
				200,
				SpecieMisdreavus.Instance, // Pokemon Specie
				"Misdreavus", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Misdreavus Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Misdreavus() : base(
			200,
			SpecieMisdreavus.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}