using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Unown Specie to store common natural stats of all Unowns
	#region SpecieUnown
	public class SpecieUnown : PokemonSpecie
	{
#nullable enable
		private static SpecieUnown? _instance = null;
#nullable restore
        public static SpecieUnown Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieUnown();
                }
                return _instance;
            }
        }

		#region SpecieUnown Builder
		public SpecieUnown() : base(
			"Unown",
			48, // HPs
			72, 48, // Attack & Defense
			72, 48, // Special Attack & Defense
			48		
		)
		{
			this._height = 5;
			this._weight = 50;
		}
		#endregion
	}
	#endregion

	//Unown Pokemon Class
	#region Unown
	public class Unown : Pokemon
	{
		#region Unown Builders
		/// <summary>
		/// Unown Builder waiting for a Nickname & a Level
		/// </summary>
		public Unown(string nickname, int level)
		: base(
				201,
				SpecieUnown.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Unown Builder only waiting for a Level
		/// </summary>
		public Unown(int level)
		: base(
				201,
				SpecieUnown.Instance, // Pokemon Specie
				"Unown", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Unown Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Unown() : base(
			201,
			SpecieUnown.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}