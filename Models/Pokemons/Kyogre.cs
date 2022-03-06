using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Kyogre Specie to store common natural stats of all Kyogres
	#region SpecieKyogre
	public class SpecieKyogre : PokemonSpecie
	{
#nullable enable
		private static SpecieKyogre? _instance = null;
#nullable restore
        public static SpecieKyogre Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKyogre();
                }
                return _instance;
            }
        }

		#region SpecieKyogre Builder
		public SpecieKyogre() : base(
			"Kyogre",
			4.5,
			352.0,
			100, // HPs
			100, 90, // Attack & Defense
			150, 140, // Special Attack & Defense
			90		
		)
		{}
		#endregion
	}
	#endregion

	//Kyogre Pokemon Class
	#region Kyogre
	public class Kyogre : Pokemon
	{
		#region Kyogre Builders
		/// <summary>
		/// Kyogre Builder waiting for a Nickname & a Level
		/// </summary>
		public Kyogre(string nickname, int level)
		: base(
				382,
				SpecieKyogre.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kyogre Builder only waiting for a Level
		/// </summary>
		public Kyogre(int level)
		: base(
				382,
				SpecieKyogre.Instance, // Pokemon Specie
				"Kyogre", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kyogre Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Kyogre() : base(
			382,
			SpecieKyogre.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}