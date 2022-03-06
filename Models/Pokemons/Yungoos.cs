using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Yungoos Specie to store common natural stats of all Yungooss
	#region SpecieYungoos
	public class SpecieYungoos : PokemonSpecie
	{
#nullable enable
		private static SpecieYungoos? _instance = null;
#nullable restore
        public static SpecieYungoos Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieYungoos();
                }
                return _instance;
            }
        }

		#region SpecieYungoos Builder
		public SpecieYungoos() : base(
			"Yungoos",
			48, // HPs
			70, 30, // Attack & Defense
			30, 30, // Special Attack & Defense
			45		
		)
		{
			this._height = 4;
			this._weight = 60;
		}
		#endregion
	}
	#endregion

	//Yungoos Pokemon Class
	#region Yungoos
	public class Yungoos : Pokemon
	{
		#region Yungoos Builders
		/// <summary>
		/// Yungoos Builder waiting for a Nickname & a Level
		/// </summary>
		public Yungoos(string nickname, int level)
		: base(
				734,
				SpecieYungoos.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yungoos Builder only waiting for a Level
		/// </summary>
		public Yungoos(int level)
		: base(
				734,
				SpecieYungoos.Instance, // Pokemon Specie
				"Yungoos", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yungoos Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Yungoos() : base(
			734,
			SpecieYungoos.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}