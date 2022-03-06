using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Conkeldurr Specie to store common natural stats of all Conkeldurrs
	#region SpecieConkeldurr
	public class SpecieConkeldurr : PokemonSpecie
	{
#nullable enable
		private static SpecieConkeldurr? _instance = null;
#nullable restore
        public static SpecieConkeldurr Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieConkeldurr();
                }
                return _instance;
            }
        }

		#region SpecieConkeldurr Builder
		public SpecieConkeldurr() : base(
			"Conkeldurr",
			105, // HPs
			140, 95, // Attack & Defense
			55, 65, // Special Attack & Defense
			45		
		)
		{
			this._height = 14;
			this._weight = 870;
		}
		#endregion
	}
	#endregion

	//Conkeldurr Pokemon Class
	#region Conkeldurr
	public class Conkeldurr : Pokemon
	{
		#region Conkeldurr Builders
		/// <summary>
		/// Conkeldurr Builder waiting for a Nickname & a Level
		/// </summary>
		public Conkeldurr(string nickname, int level)
		: base(
				534,
				SpecieConkeldurr.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Conkeldurr Builder only waiting for a Level
		/// </summary>
		public Conkeldurr(int level)
		: base(
				534,
				SpecieConkeldurr.Instance, // Pokemon Specie
				"Conkeldurr", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Conkeldurr Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Conkeldurr() : base(
			534,
			SpecieConkeldurr.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}