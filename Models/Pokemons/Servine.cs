using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Servine Specie to store common natural stats of all Servines
	#region SpecieServine
	public class SpecieServine : PokemonSpecie
	{
#nullable enable
		private static SpecieServine? _instance = null;
#nullable restore
        public static SpecieServine Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieServine();
                }
                return _instance;
            }
        }

		#region SpecieServine Builder
		public SpecieServine() : base(
			"Servine",
			0.8,
			16.0,
			60, // HPs
			60, 75, // Attack & Defense
			60, 75, // Special Attack & Defense
			83		
		)
		{}
		#endregion
	}
	#endregion

	//Servine Pokemon Class
	#region Servine
	public class Servine : Pokemon
	{
		#region Servine Builders
		/// <summary>
		/// Servine Builder waiting for a Nickname & a Level
		/// </summary>
		public Servine(string nickname, int level)
		: base(
				496,
				SpecieServine.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Servine Builder only waiting for a Level
		/// </summary>
		public Servine(int level)
		: base(
				496,
				SpecieServine.Instance, // Pokemon Specie
				"Servine", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Servine Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Servine() : base(
			496,
			SpecieServine.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}