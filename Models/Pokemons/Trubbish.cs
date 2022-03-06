using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Trubbish Specie to store common natural stats of all Trubbishs
	#region SpecieTrubbish
	public class SpecieTrubbish : PokemonSpecie
	{
#nullable enable
		private static SpecieTrubbish? _instance = null;
#nullable restore
        public static SpecieTrubbish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTrubbish();
                }
                return _instance;
            }
        }

		#region SpecieTrubbish Builder
		public SpecieTrubbish() : base(
			"Trubbish",
			0.6,
			31.0,
			50, // HPs
			50, 62, // Attack & Defense
			40, 62, // Special Attack & Defense
			65		
		)
		{}
		#endregion
	}
	#endregion

	//Trubbish Pokemon Class
	#region Trubbish
	public class Trubbish : Pokemon
	{
		#region Trubbish Builders
		/// <summary>
		/// Trubbish Builder waiting for a Nickname & a Level
		/// </summary>
		public Trubbish(string nickname, int level)
		: base(
				568,
				SpecieTrubbish.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Trubbish Builder only waiting for a Level
		/// </summary>
		public Trubbish(int level)
		: base(
				568,
				SpecieTrubbish.Instance, // Pokemon Specie
				"Trubbish", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Trubbish Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Trubbish() : base(
			568,
			SpecieTrubbish.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}