using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Ekans Specie to store common natural stats of all Ekanss
	#region SpecieEkans
	public class SpecieEkans : PokemonSpecie
	{
#nullable enable
		private static SpecieEkans? _instance = null;
#nullable restore
        public static SpecieEkans Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEkans();
                }
                return _instance;
            }
        }

		#region SpecieEkans Builder
		public SpecieEkans() : base(
			"Ekans",
			2.0,
			6.9,
			35, // HPs
			60, 44, // Attack & Defense
			40, 54, // Special Attack & Defense
			55		
		)
		{}
		#endregion
	}
	#endregion

	//Ekans Pokemon Class
	#region Ekans
	public class Ekans : Pokemon
	{
		#region Ekans Builders
		/// <summary>
		/// Ekans Builder waiting for a Nickname & a Level
		/// </summary>
		public Ekans(string nickname, int level)
		: base(
				23,
				SpecieEkans.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ekans Builder only waiting for a Level
		/// </summary>
		public Ekans(int level)
		: base(
				23,
				SpecieEkans.Instance, // Pokemon Specie
				"Ekans", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ekans Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Ekans() : base(
			23,
			SpecieEkans.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}