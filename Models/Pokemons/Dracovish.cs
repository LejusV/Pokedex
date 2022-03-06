using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Dracovish Specie to store common natural stats of all Dracovishs
	#region SpecieDracovish
	public class SpecieDracovish : PokemonSpecie
	{
#nullable enable
		private static SpecieDracovish? _instance = null;
#nullable restore
        public static SpecieDracovish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDracovish();
                }
                return _instance;
            }
        }

		#region SpecieDracovish Builder
		public SpecieDracovish() : base(
			"Dracovish",
			90, // HPs
			90, 100, // Attack & Defense
			70, 80, // Special Attack & Defense
			75		
		)
		{
			this._height = 23;
			this._weight = 2150;
		}
		#endregion
	}
	#endregion

	//Dracovish Pokemon Class
	#region Dracovish
	public class Dracovish : Pokemon
	{
		#region Dracovish Builders
		/// <summary>
		/// Dracovish Builder waiting for a Nickname & a Level
		/// </summary>
		public Dracovish(string nickname, int level)
		: base(
				882,
				SpecieDracovish.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dracovish Builder only waiting for a Level
		/// </summary>
		public Dracovish(int level)
		: base(
				882,
				SpecieDracovish.Instance, // Pokemon Specie
				"Dracovish", level,
				Water.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dracovish Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Dracovish() : base(
			882,
			SpecieDracovish.Instance, // Pokemon Specie
			Water.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}