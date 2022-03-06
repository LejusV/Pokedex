using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Pheromosa Specie to store common natural stats of all Pheromosas
	#region SpeciePheromosa
	public class SpeciePheromosa : PokemonSpecie
	{
#nullable enable
		private static SpeciePheromosa? _instance = null;
#nullable restore
        public static SpeciePheromosa Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePheromosa();
                }
                return _instance;
            }
        }

		#region SpeciePheromosa Builder
		public SpeciePheromosa() : base(
			"Pheromosa",
			1.8,
			25.0,
			71, // HPs
			137, 37, // Attack & Defense
			137, 37, // Special Attack & Defense
			151		
		)
		{}
		#endregion
	}
	#endregion

	//Pheromosa Pokemon Class
	#region Pheromosa
	public class Pheromosa : Pokemon
	{
		#region Pheromosa Builders
		/// <summary>
		/// Pheromosa Builder waiting for a Nickname & a Level
		/// </summary>
		public Pheromosa(string nickname, int level)
		: base(
				795,
				SpeciePheromosa.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pheromosa Builder only waiting for a Level
		/// </summary>
		public Pheromosa(int level)
		: base(
				795,
				SpeciePheromosa.Instance, // Pokemon Specie
				"Pheromosa", level,
				Bug.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pheromosa Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Pheromosa() : base(
			795,
			SpeciePheromosa.Instance, // Pokemon Specie
			Bug.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}