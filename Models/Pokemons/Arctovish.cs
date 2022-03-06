using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Arctovish Specie to store common natural stats of all Arctovishs
	#region SpecieArctovish
	public class SpecieArctovish : PokemonSpecie
	{
#nullable enable
		private static SpecieArctovish? _instance = null;
#nullable restore
        public static SpecieArctovish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieArctovish();
                }
                return _instance;
            }
        }

		#region SpecieArctovish Builder
		public SpecieArctovish() : base(
			"Arctovish",
			90, // HPs
			90, 100, // Attack & Defense
			80, 90, // Special Attack & Defense
			55		
		)
		{
			this._height = 20;
			this._weight = 1750;
		}
		#endregion
	}
	#endregion

	//Arctovish Pokemon Class
	#region Arctovish
	public class Arctovish : Pokemon
	{
		#region Arctovish Builders
		/// <summary>
		/// Arctovish Builder waiting for a Nickname & a Level
		/// </summary>
		public Arctovish(string nickname, int level)
		: base(
				883,
				SpecieArctovish.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arctovish Builder only waiting for a Level
		/// </summary>
		public Arctovish(int level)
		: base(
				883,
				SpecieArctovish.Instance, // Pokemon Specie
				"Arctovish", level,
				Water.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arctovish Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Arctovish() : base(
			883,
			SpecieArctovish.Instance, // Pokemon Specie
			Water.Instance, Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}