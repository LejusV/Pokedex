using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Dragonair Specie to store common natural stats of all Dragonairs
	#region SpecieDragonair
	public class SpecieDragonair : PokemonSpecie
	{
#nullable enable
		private static SpecieDragonair? _instance = null;
#nullable restore
        public static SpecieDragonair Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDragonair();
                }
                return _instance;
            }
        }

		#region SpecieDragonair Builder
		public SpecieDragonair() : base(
			"Dragonair",
			61, // HPs
			84, 65, // Attack & Defense
			70, 70, // Special Attack & Defense
			70		
		)
		{
			this._height = 40;
			this._weight = 165;
		}
		#endregion
	}
	#endregion

	//Dragonair Pokemon Class
	#region Dragonair
	public class Dragonair : Pokemon
	{
		#region Dragonair Builders
		/// <summary>
		/// Dragonair Builder waiting for a Nickname & a Level
		/// </summary>
		public Dragonair(string nickname, int level)
		: base(
				148,
				SpecieDragonair.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dragonair Builder only waiting for a Level
		/// </summary>
		public Dragonair(int level)
		: base(
				148,
				SpecieDragonair.Instance, // Pokemon Specie
				"Dragonair", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dragonair Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Dragonair() : base(
			148,
			SpecieDragonair.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}