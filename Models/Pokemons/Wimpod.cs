using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Wimpod Specie to store common natural stats of all Wimpods
	#region SpecieWimpod
	public class SpecieWimpod : PokemonSpecie
	{
#nullable enable
		private static SpecieWimpod? _instance = null;
#nullable restore
        public static SpecieWimpod Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWimpod();
                }
                return _instance;
            }
        }

		#region SpecieWimpod Builder
		public SpecieWimpod() : base(
			"Wimpod",
			0.5,
			12.0,
			25, // HPs
			35, 40, // Attack & Defense
			20, 30, // Special Attack & Defense
			80		
		)
		{}
		#endregion
	}
	#endregion

	//Wimpod Pokemon Class
	#region Wimpod
	public class Wimpod : Pokemon
	{
		#region Wimpod Builders
		/// <summary>
		/// Wimpod Builder waiting for a Nickname & a Level
		/// </summary>
		public Wimpod(string nickname, int level)
		: base(
				767,
				SpecieWimpod.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wimpod Builder only waiting for a Level
		/// </summary>
		public Wimpod(int level)
		: base(
				767,
				SpecieWimpod.Instance, // Pokemon Specie
				"Wimpod", level,
				Bug.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wimpod Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Wimpod() : base(
			767,
			SpecieWimpod.Instance, // Pokemon Specie
			Bug.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}