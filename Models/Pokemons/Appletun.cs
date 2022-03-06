using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Appletun Specie to store common natural stats of all Appletuns
	#region SpecieAppletun
	public class SpecieAppletun : PokemonSpecie
	{
#nullable enable
		private static SpecieAppletun? _instance = null;
#nullable restore
        public static SpecieAppletun Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAppletun();
                }
                return _instance;
            }
        }

		#region SpecieAppletun Builder
		public SpecieAppletun() : base(
			"Appletun",
			110, // HPs
			85, 80, // Attack & Defense
			100, 80, // Special Attack & Defense
			30		
		)
		{
			this._height = 4;
			this._weight = 130;
		}
		#endregion
	}
	#endregion

	//Appletun Pokemon Class
	#region Appletun
	public class Appletun : Pokemon
	{
		#region Appletun Builders
		/// <summary>
		/// Appletun Builder waiting for a Nickname & a Level
		/// </summary>
		public Appletun(string nickname, int level)
		: base(
				842,
				SpecieAppletun.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Appletun Builder only waiting for a Level
		/// </summary>
		public Appletun(int level)
		: base(
				842,
				SpecieAppletun.Instance, // Pokemon Specie
				"Appletun", level,
				Grass.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Appletun Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Appletun() : base(
			842,
			SpecieAppletun.Instance, // Pokemon Specie
			Grass.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}