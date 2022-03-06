using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Ferroseed Specie to store common natural stats of all Ferroseeds
	#region SpecieFerroseed
	public class SpecieFerroseed : PokemonSpecie
	{
#nullable enable
		private static SpecieFerroseed? _instance = null;
#nullable restore
        public static SpecieFerroseed Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFerroseed();
                }
                return _instance;
            }
        }

		#region SpecieFerroseed Builder
		public SpecieFerroseed() : base(
			"Ferroseed",
			0.6,
			18.8,
			44, // HPs
			50, 91, // Attack & Defense
			24, 86, // Special Attack & Defense
			10		
		)
		{}
		#endregion
	}
	#endregion

	//Ferroseed Pokemon Class
	#region Ferroseed
	public class Ferroseed : Pokemon
	{
		#region Ferroseed Builders
		/// <summary>
		/// Ferroseed Builder waiting for a Nickname & a Level
		/// </summary>
		public Ferroseed(string nickname, int level)
		: base(
				597,
				SpecieFerroseed.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ferroseed Builder only waiting for a Level
		/// </summary>
		public Ferroseed(int level)
		: base(
				597,
				SpecieFerroseed.Instance, // Pokemon Specie
				"Ferroseed", level,
				Grass.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ferroseed Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Ferroseed() : base(
			597,
			SpecieFerroseed.Instance, // Pokemon Specie
			Grass.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}