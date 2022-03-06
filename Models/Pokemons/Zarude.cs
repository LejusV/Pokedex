using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Zarude Specie to store common natural stats of all Zarudes
	#region SpecieZarude
	public class SpecieZarude : PokemonSpecie
	{
#nullable enable
		private static SpecieZarude? _instance = null;
#nullable restore
        public static SpecieZarude Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZarude();
                }
                return _instance;
            }
        }

		#region SpecieZarude Builder
		public SpecieZarude() : base(
			"Zarude",
			1.8,
			70.0,
			105, // HPs
			120, 105, // Attack & Defense
			70, 95, // Special Attack & Defense
			105		
		)
		{}
		#endregion
	}
	#endregion

	//Zarude Pokemon Class
	#region Zarude
	public class Zarude : Pokemon
	{
		#region Zarude Builders
		/// <summary>
		/// Zarude Builder waiting for a Nickname & a Level
		/// </summary>
		public Zarude(string nickname, int level)
		: base(
				893,
				SpecieZarude.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zarude Builder only waiting for a Level
		/// </summary>
		public Zarude(int level)
		: base(
				893,
				SpecieZarude.Instance, // Pokemon Specie
				"Zarude", level,
				Dark.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zarude Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Zarude() : base(
			893,
			SpecieZarude.Instance, // Pokemon Specie
			Dark.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}