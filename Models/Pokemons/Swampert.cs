using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Swampert Specie to store common natural stats of all Swamperts
	#region SpecieSwampert
	public class SpecieSwampert : PokemonSpecie
	{
#nullable enable
		private static SpecieSwampert? _instance = null;
#nullable restore
        public static SpecieSwampert Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSwampert();
                }
                return _instance;
            }
        }

		#region SpecieSwampert Builder
		public SpecieSwampert() : base(
			"Swampert",
			100, // HPs
			110, 90, // Attack & Defense
			85, 90, // Special Attack & Defense
			60		
		)
		{
			this._height = 15;
			this._weight = 819;
		}
		#endregion
	}
	#endregion

	//Swampert Pokemon Class
	#region Swampert
	public class Swampert : Pokemon
	{
		#region Swampert Builders
		/// <summary>
		/// Swampert Builder waiting for a Nickname & a Level
		/// </summary>
		public Swampert(string nickname, int level)
		: base(
				260,
				SpecieSwampert.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swampert Builder only waiting for a Level
		/// </summary>
		public Swampert(int level)
		: base(
				260,
				SpecieSwampert.Instance, // Pokemon Specie
				"Swampert", level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swampert Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Swampert() : base(
			260,
			SpecieSwampert.Instance, // Pokemon Specie
			Water.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}