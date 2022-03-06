using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Vivillon Specie to store common natural stats of all Vivillons
	#region SpecieVivillon
	public class SpecieVivillon : PokemonSpecie
	{
#nullable enable
		private static SpecieVivillon? _instance = null;
#nullable restore
        public static SpecieVivillon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVivillon();
                }
                return _instance;
            }
        }

		#region SpecieVivillon Builder
		public SpecieVivillon() : base(
			"Vivillon",
			80, // HPs
			52, 50, // Attack & Defense
			90, 50, // Special Attack & Defense
			89		
		)
		{
			this._height = 12;
			this._weight = 170;
		}
		#endregion
	}
	#endregion

	//Vivillon Pokemon Class
	#region Vivillon
	public class Vivillon : Pokemon
	{
		#region Vivillon Builders
		/// <summary>
		/// Vivillon Builder waiting for a Nickname & a Level
		/// </summary>
		public Vivillon(string nickname, int level)
		: base(
				666,
				SpecieVivillon.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vivillon Builder only waiting for a Level
		/// </summary>
		public Vivillon(int level)
		: base(
				666,
				SpecieVivillon.Instance, // Pokemon Specie
				"Vivillon", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vivillon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Vivillon() : base(
			666,
			SpecieVivillon.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}