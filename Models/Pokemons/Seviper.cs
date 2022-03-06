using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Seviper Specie to store common natural stats of all Sevipers
	#region SpecieSeviper
	public class SpecieSeviper : PokemonSpecie
	{
#nullable enable
		private static SpecieSeviper? _instance = null;
#nullable restore
        public static SpecieSeviper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSeviper();
                }
                return _instance;
            }
        }

		#region SpecieSeviper Builder
		public SpecieSeviper() : base(
			"Seviper",
			73, // HPs
			100, 60, // Attack & Defense
			100, 60, // Special Attack & Defense
			65		
		)
		{
			this._height = 27;
			this._weight = 525;
		}
		#endregion
	}
	#endregion

	//Seviper Pokemon Class
	#region Seviper
	public class Seviper : Pokemon
	{
		#region Seviper Builders
		/// <summary>
		/// Seviper Builder waiting for a Nickname & a Level
		/// </summary>
		public Seviper(string nickname, int level)
		: base(
				336,
				SpecieSeviper.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seviper Builder only waiting for a Level
		/// </summary>
		public Seviper(int level)
		: base(
				336,
				SpecieSeviper.Instance, // Pokemon Specie
				"Seviper", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seviper Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Seviper() : base(
			336,
			SpecieSeviper.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}