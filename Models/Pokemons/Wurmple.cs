using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Wurmple Specie to store common natural stats of all Wurmples
	#region SpecieWurmple
	public class SpecieWurmple : PokemonSpecie
	{
#nullable enable
		private static SpecieWurmple? _instance = null;
#nullable restore
        public static SpecieWurmple Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWurmple();
                }
                return _instance;
            }
        }

		#region SpecieWurmple Builder
		public SpecieWurmple() : base(
			"Wurmple",
			0.3,
			3.6,
			45, // HPs
			45, 35, // Attack & Defense
			20, 30, // Special Attack & Defense
			20		
		)
		{}
		#endregion
	}
	#endregion

	//Wurmple Pokemon Class
	#region Wurmple
	public class Wurmple : Pokemon
	{
		#region Wurmple Builders
		/// <summary>
		/// Wurmple Builder waiting for a Nickname & a Level
		/// </summary>
		public Wurmple(string nickname, int level)
		: base(
				265,
				SpecieWurmple.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wurmple Builder only waiting for a Level
		/// </summary>
		public Wurmple(int level)
		: base(
				265,
				SpecieWurmple.Instance, // Pokemon Specie
				"Wurmple", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wurmple Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Wurmple() : base(
			265,
			SpecieWurmple.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}