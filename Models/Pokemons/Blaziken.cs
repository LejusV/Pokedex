using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Blaziken Specie to store common natural stats of all Blazikens
	#region SpecieBlaziken
	public class SpecieBlaziken : PokemonSpecie
	{
#nullable enable
		private static SpecieBlaziken? _instance = null;
#nullable restore
        public static SpecieBlaziken Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBlaziken();
                }
                return _instance;
            }
        }

		#region SpecieBlaziken Builder
		public SpecieBlaziken() : base(
			"Blaziken",
			80, // HPs
			120, 70, // Attack & Defense
			110, 70, // Special Attack & Defense
			80		
		)
		{
			this._height = 19;
			this._weight = 520;
		}
		#endregion
	}
	#endregion

	//Blaziken Pokemon Class
	#region Blaziken
	public class Blaziken : Pokemon
	{
		#region Blaziken Builders
		/// <summary>
		/// Blaziken Builder waiting for a Nickname & a Level
		/// </summary>
		public Blaziken(string nickname, int level)
		: base(
				257,
				SpecieBlaziken.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blaziken Builder only waiting for a Level
		/// </summary>
		public Blaziken(int level)
		: base(
				257,
				SpecieBlaziken.Instance, // Pokemon Specie
				"Blaziken", level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blaziken Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Blaziken() : base(
			257,
			SpecieBlaziken.Instance, // Pokemon Specie
			Fire.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}