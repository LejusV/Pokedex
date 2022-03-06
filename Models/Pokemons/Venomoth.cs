using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Venomoth Specie to store common natural stats of all Venomoths
	#region SpecieVenomoth
	public class SpecieVenomoth : PokemonSpecie
	{
#nullable enable
		private static SpecieVenomoth? _instance = null;
#nullable restore
        public static SpecieVenomoth Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVenomoth();
                }
                return _instance;
            }
        }

		#region SpecieVenomoth Builder
		public SpecieVenomoth() : base(
			"Venomoth",
			70, // HPs
			65, 60, // Attack & Defense
			90, 75, // Special Attack & Defense
			90		
		)
		{
			this._height = 15;
			this._weight = 125;
		}
		#endregion
	}
	#endregion

	//Venomoth Pokemon Class
	#region Venomoth
	public class Venomoth : Pokemon
	{
		#region Venomoth Builders
		/// <summary>
		/// Venomoth Builder waiting for a Nickname & a Level
		/// </summary>
		public Venomoth(string nickname, int level)
		: base(
				49,
				SpecieVenomoth.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Venomoth Builder only waiting for a Level
		/// </summary>
		public Venomoth(int level)
		: base(
				49,
				SpecieVenomoth.Instance, // Pokemon Specie
				"Venomoth", level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Venomoth Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Venomoth() : base(
			49,
			SpecieVenomoth.Instance, // Pokemon Specie
			Bug.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}