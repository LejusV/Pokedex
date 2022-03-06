using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Carnivine Specie to store common natural stats of all Carnivines
	#region SpecieCarnivine
	public class SpecieCarnivine : PokemonSpecie
	{
#nullable enable
		private static SpecieCarnivine? _instance = null;
#nullable restore
        public static SpecieCarnivine Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCarnivine();
                }
                return _instance;
            }
        }

		#region SpecieCarnivine Builder
		public SpecieCarnivine() : base(
			"Carnivine",
			1.4,
			27.0,
			74, // HPs
			100, 72, // Attack & Defense
			90, 72, // Special Attack & Defense
			46		
		)
		{}
		#endregion
	}
	#endregion

	//Carnivine Pokemon Class
	#region Carnivine
	public class Carnivine : Pokemon
	{
		#region Carnivine Builders
		/// <summary>
		/// Carnivine Builder waiting for a Nickname & a Level
		/// </summary>
		public Carnivine(string nickname, int level)
		: base(
				455,
				SpecieCarnivine.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carnivine Builder only waiting for a Level
		/// </summary>
		public Carnivine(int level)
		: base(
				455,
				SpecieCarnivine.Instance, // Pokemon Specie
				"Carnivine", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carnivine Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Carnivine() : base(
			455,
			SpecieCarnivine.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}