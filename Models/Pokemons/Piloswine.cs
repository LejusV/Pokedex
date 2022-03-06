using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Piloswine Specie to store common natural stats of all Piloswines
	#region SpeciePiloswine
	public class SpeciePiloswine : PokemonSpecie
	{
#nullable enable
		private static SpeciePiloswine? _instance = null;
#nullable restore
        public static SpeciePiloswine Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePiloswine();
                }
                return _instance;
            }
        }

		#region SpeciePiloswine Builder
		public SpeciePiloswine() : base(
			"Piloswine",
			1.1,
			55.8,
			100, // HPs
			100, 80, // Attack & Defense
			60, 60, // Special Attack & Defense
			50		
		)
		{}
		#endregion
	}
	#endregion

	//Piloswine Pokemon Class
	#region Piloswine
	public class Piloswine : Pokemon
	{
		#region Piloswine Builders
		/// <summary>
		/// Piloswine Builder waiting for a Nickname & a Level
		/// </summary>
		public Piloswine(string nickname, int level)
		: base(
				221,
				SpeciePiloswine.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Piloswine Builder only waiting for a Level
		/// </summary>
		public Piloswine(int level)
		: base(
				221,
				SpeciePiloswine.Instance, // Pokemon Specie
				"Piloswine", level,
				Ice.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Piloswine Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Piloswine() : base(
			221,
			SpeciePiloswine.Instance, // Pokemon Specie
			Ice.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}