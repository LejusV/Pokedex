using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cherrim Specie to store common natural stats of all Cherrims
	#region SpecieCherrim
	public class SpecieCherrim : PokemonSpecie
	{
#nullable enable
		private static SpecieCherrim? _instance = null;
#nullable restore
        public static SpecieCherrim Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCherrim();
                }
                return _instance;
            }
        }

		#region SpecieCherrim Builder
		public SpecieCherrim() : base(
			"Cherrim",
			70, // HPs
			60, 70, // Attack & Defense
			87, 78, // Special Attack & Defense
			85			
		) {}
		#endregion
	}
	#endregion

	//Cherrim Pokemon Class
	#region Cherrim
	public class Cherrim : Pokemon
	{
		#region Cherrim Builders
		/// <summary>
		/// Cherrim Builder waiting for a Nickname & a Level
		/// </summary>
		public Cherrim(string nickname, int level)
		: base(
				421,
				SpecieCherrim.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cherrim Builder only waiting for a Level
		/// </summary>
		public Cherrim(int level)
		: base(
				421,
				SpecieCherrim.Instance, // Pokemon Specie
				"Cherrim", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cherrim Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Cherrim() : base(
			421,
			SpecieCherrim.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		#endregion
	}
	#endregion
}