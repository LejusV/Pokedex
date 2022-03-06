using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Crabrawler Specie to store common natural stats of all Crabrawlers
	#region SpecieCrabrawler
	public class SpecieCrabrawler : PokemonSpecie
	{
#nullable enable
		private static SpecieCrabrawler? _instance = null;
#nullable restore
        public static SpecieCrabrawler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCrabrawler();
                }
                return _instance;
            }
        }

		#region SpecieCrabrawler Builder
		public SpecieCrabrawler() : base(
			"Crabrawler",
			0.6,
			7.0,
			47, // HPs
			82, 57, // Attack & Defense
			42, 47, // Special Attack & Defense
			63		
		)
		{}
		#endregion
	}
	#endregion

	//Crabrawler Pokemon Class
	#region Crabrawler
	public class Crabrawler : Pokemon
	{
		#region Crabrawler Builders
		/// <summary>
		/// Crabrawler Builder waiting for a Nickname & a Level
		/// </summary>
		public Crabrawler(string nickname, int level)
		: base(
				739,
				SpecieCrabrawler.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crabrawler Builder only waiting for a Level
		/// </summary>
		public Crabrawler(int level)
		: base(
				739,
				SpecieCrabrawler.Instance, // Pokemon Specie
				"Crabrawler", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crabrawler Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Crabrawler() : base(
			739,
			SpecieCrabrawler.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}