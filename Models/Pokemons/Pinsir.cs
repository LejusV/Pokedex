using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Pinsir Specie to store common natural stats of all Pinsirs
	#region SpeciePinsir
	public class SpeciePinsir : PokemonSpecie
	{
#nullable enable
		private static SpeciePinsir? _instance = null;
#nullable restore
        public static SpeciePinsir Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePinsir();
                }
                return _instance;
            }
        }

		#region SpeciePinsir Builder
		public SpeciePinsir() : base(
			"Pinsir",
			65, // HPs
			125, 100, // Attack & Defense
			55, 70, // Special Attack & Defense
			85		
		)
		{
			this._height = 15;
			this._weight = 550;
		}
		#endregion
	}
	#endregion

	//Pinsir Pokemon Class
	#region Pinsir
	public class Pinsir : Pokemon
	{
		#region Pinsir Builders
		/// <summary>
		/// Pinsir Builder waiting for a Nickname & a Level
		/// </summary>
		public Pinsir(string nickname, int level)
		: base(
				127,
				SpeciePinsir.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pinsir Builder only waiting for a Level
		/// </summary>
		public Pinsir(int level)
		: base(
				127,
				SpeciePinsir.Instance, // Pokemon Specie
				"Pinsir", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pinsir Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Pinsir() : base(
			127,
			SpeciePinsir.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}