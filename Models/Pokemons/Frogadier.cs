using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Frogadier Specie to store common natural stats of all Frogadiers
	#region SpecieFrogadier
	public class SpecieFrogadier : PokemonSpecie
	{
#nullable enable
		private static SpecieFrogadier? _instance = null;
#nullable restore
        public static SpecieFrogadier Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFrogadier();
                }
                return _instance;
            }
        }

		#region SpecieFrogadier Builder
		public SpecieFrogadier() : base(
			"Frogadier",
			54, // HPs
			63, 52, // Attack & Defense
			83, 56, // Special Attack & Defense
			97		
		)
		{
			this._height = 6;
			this._weight = 109;
		}
		#endregion
	}
	#endregion

	//Frogadier Pokemon Class
	#region Frogadier
	public class Frogadier : Pokemon
	{
		#region Frogadier Builders
		/// <summary>
		/// Frogadier Builder waiting for a Nickname & a Level
		/// </summary>
		public Frogadier(string nickname, int level)
		: base(
				657,
				SpecieFrogadier.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Frogadier Builder only waiting for a Level
		/// </summary>
		public Frogadier(int level)
		: base(
				657,
				SpecieFrogadier.Instance, // Pokemon Specie
				"Frogadier", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Frogadier Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Frogadier() : base(
			657,
			SpecieFrogadier.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}