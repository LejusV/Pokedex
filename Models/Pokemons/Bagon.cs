using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Bagon Specie to store common natural stats of all Bagons
	#region SpecieBagon
	public class SpecieBagon : PokemonSpecie
	{
#nullable enable
		private static SpecieBagon? _instance = null;
#nullable restore
        public static SpecieBagon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBagon();
                }
                return _instance;
            }
        }

		#region SpecieBagon Builder
		public SpecieBagon() : base(
			"Bagon",
			45, // HPs
			75, 60, // Attack & Defense
			40, 30, // Special Attack & Defense
			50		
		)
		{
			this._height = 6;
			this._weight = 421;
		}
		#endregion
	}
	#endregion

	//Bagon Pokemon Class
	#region Bagon
	public class Bagon : Pokemon
	{
		#region Bagon Builders
		/// <summary>
		/// Bagon Builder waiting for a Nickname & a Level
		/// </summary>
		public Bagon(string nickname, int level)
		: base(
				371,
				SpecieBagon.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bagon Builder only waiting for a Level
		/// </summary>
		public Bagon(int level)
		: base(
				371,
				SpecieBagon.Instance, // Pokemon Specie
				"Bagon", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bagon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Bagon() : base(
			371,
			SpecieBagon.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}