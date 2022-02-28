using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sunkern Specie to store common natural stats of all Sunkerns
	#region SpecieSunkern
	public class SpecieSunkern : PokemonSpecie
	{
#nullable enable
		private static SpecieSunkern? _instance = null;
#nullable restore
        public static SpecieSunkern Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSunkern();
                }
                return _instance;
            }
        }

		#region SpecieSunkern Builder
		public SpecieSunkern() : base(
			"Sunkern",
			30, // HPs
			30, 30, // Attack & Defense
			30, 30, // Special Attack & Defense
			30			
		) {}
		#endregion
	}
	#endregion

	//Sunkern Pokemon Class
	#region Sunkern
	public class Sunkern : Pokemon
	{
		#region Sunkern Builders
		/// <summary>
		/// Sunkern Builder waiting for a Nickname & a Level
		/// </summary>
		public Sunkern(string nickname, int level)
		: base(
				191,
				SpecieSunkern.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sunkern Builder only waiting for a Level
		/// </summary>
		public Sunkern(int level)
		: base(
				191,
				SpecieSunkern.Instance, // Pokemon Specie
				"Sunkern", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sunkern Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Sunkern() : base(
			191,
			SpecieSunkern.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		#endregion
	}
	#endregion
}