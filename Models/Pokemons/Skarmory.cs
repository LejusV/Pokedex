using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Skarmory Specie to store common natural stats of all Skarmorys
	#region SpecieSkarmory
	public class SpecieSkarmory : PokemonSpecie
	{
#nullable enable
		private static SpecieSkarmory? _instance = null;
#nullable restore
        public static SpecieSkarmory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSkarmory();
                }
                return _instance;
            }
        }

		#region SpecieSkarmory Builder
		public SpecieSkarmory() : base(
			"Skarmory",
			1.7,
			50.5,
			65, // HPs
			80, 140, // Attack & Defense
			40, 70, // Special Attack & Defense
			70		
		)
		{}
		#endregion
	}
	#endregion

	//Skarmory Pokemon Class
	#region Skarmory
	public class Skarmory : Pokemon
	{
		#region Skarmory Builders
		/// <summary>
		/// Skarmory Builder waiting for a Nickname & a Level
		/// </summary>
		public Skarmory(string nickname, int level)
		: base(
				227,
				SpecieSkarmory.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skarmory Builder only waiting for a Level
		/// </summary>
		public Skarmory(int level)
		: base(
				227,
				SpecieSkarmory.Instance, // Pokemon Specie
				"Skarmory", level,
				Steel.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skarmory Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Skarmory() : base(
			227,
			SpecieSkarmory.Instance, // Pokemon Specie
			Steel.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}