using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Skwovet Specie to store common natural stats of all Skwovets
	#region SpecieSkwovet
	public class SpecieSkwovet : PokemonSpecie
	{
#nullable enable
		private static SpecieSkwovet? _instance = null;
#nullable restore
        public static SpecieSkwovet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSkwovet();
                }
                return _instance;
            }
        }

		#region SpecieSkwovet Builder
		public SpecieSkwovet() : base(
			"Skwovet",
			70, // HPs
			55, 55, // Attack & Defense
			35, 35, // Special Attack & Defense
			25		
		)
		{
			this._height = 3;
			this._weight = 25;
		}
		#endregion
	}
	#endregion

	//Skwovet Pokemon Class
	#region Skwovet
	public class Skwovet : Pokemon
	{
		#region Skwovet Builders
		/// <summary>
		/// Skwovet Builder waiting for a Nickname & a Level
		/// </summary>
		public Skwovet(string nickname, int level)
		: base(
				819,
				SpecieSkwovet.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skwovet Builder only waiting for a Level
		/// </summary>
		public Skwovet(int level)
		: base(
				819,
				SpecieSkwovet.Instance, // Pokemon Specie
				"Skwovet", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skwovet Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Skwovet() : base(
			819,
			SpecieSkwovet.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}