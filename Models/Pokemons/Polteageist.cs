using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Polteageist Specie to store common natural stats of all Polteageists
	#region SpeciePolteageist
	public class SpeciePolteageist : PokemonSpecie
	{
#nullable enable
		private static SpeciePolteageist? _instance = null;
#nullable restore
        public static SpeciePolteageist Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePolteageist();
                }
                return _instance;
            }
        }

		#region SpeciePolteageist Builder
		public SpeciePolteageist() : base(
			"Polteageist",
			0.2,
			0.4,
			60, // HPs
			65, 65, // Attack & Defense
			134, 114, // Special Attack & Defense
			70		
		)
		{}
		#endregion
	}
	#endregion

	//Polteageist Pokemon Class
	#region Polteageist
	public class Polteageist : Pokemon
	{
		#region Polteageist Builders
		/// <summary>
		/// Polteageist Builder waiting for a Nickname & a Level
		/// </summary>
		public Polteageist(string nickname, int level)
		: base(
				855,
				SpeciePolteageist.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Polteageist Builder only waiting for a Level
		/// </summary>
		public Polteageist(int level)
		: base(
				855,
				SpeciePolteageist.Instance, // Pokemon Specie
				"Polteageist", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Polteageist Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Polteageist() : base(
			855,
			SpeciePolteageist.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}