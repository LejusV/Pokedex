using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Starly Specie to store common natural stats of all Starlys
	#region SpecieStarly
	public class SpecieStarly : PokemonSpecie
	{
#nullable enable
		private static SpecieStarly? _instance = null;
#nullable restore
        public static SpecieStarly Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieStarly();
                }
                return _instance;
            }
        }

		#region SpecieStarly Builder
		public SpecieStarly() : base(
			"Starly",
			40, // HPs
			55, 30, // Attack & Defense
			30, 30, // Special Attack & Defense
			60		
		)
		{
			this._height = 3;
			this._weight = 20;
		}
		#endregion
	}
	#endregion

	//Starly Pokemon Class
	#region Starly
	public class Starly : Pokemon
	{
		#region Starly Builders
		/// <summary>
		/// Starly Builder waiting for a Nickname & a Level
		/// </summary>
		public Starly(string nickname, int level)
		: base(
				396,
				SpecieStarly.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Starly Builder only waiting for a Level
		/// </summary>
		public Starly(int level)
		: base(
				396,
				SpecieStarly.Instance, // Pokemon Specie
				"Starly", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Starly Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Starly() : base(
			396,
			SpecieStarly.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}