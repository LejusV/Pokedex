using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Pawniard Specie to store common natural stats of all Pawniards
	#region SpeciePawniard
	public class SpeciePawniard : PokemonSpecie
	{
#nullable enable
		private static SpeciePawniard? _instance = null;
#nullable restore
        public static SpeciePawniard Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePawniard();
                }
                return _instance;
            }
        }

		#region SpeciePawniard Builder
		public SpeciePawniard() : base(
			"Pawniard",
			45, // HPs
			85, 70, // Attack & Defense
			40, 40, // Special Attack & Defense
			60		
		)
		{
			this._height = 5;
			this._weight = 102;
		}
		#endregion
	}
	#endregion

	//Pawniard Pokemon Class
	#region Pawniard
	public class Pawniard : Pokemon
	{
		#region Pawniard Builders
		/// <summary>
		/// Pawniard Builder waiting for a Nickname & a Level
		/// </summary>
		public Pawniard(string nickname, int level)
		: base(
				624,
				SpeciePawniard.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pawniard Builder only waiting for a Level
		/// </summary>
		public Pawniard(int level)
		: base(
				624,
				SpeciePawniard.Instance, // Pokemon Specie
				"Pawniard", level,
				Dark.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pawniard Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Pawniard() : base(
			624,
			SpeciePawniard.Instance, // Pokemon Specie
			Dark.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}