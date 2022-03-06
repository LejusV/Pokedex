using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Venonat Specie to store common natural stats of all Venonats
	#region SpecieVenonat
	public class SpecieVenonat : PokemonSpecie
	{
#nullable enable
		private static SpecieVenonat? _instance = null;
#nullable restore
        public static SpecieVenonat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVenonat();
                }
                return _instance;
            }
        }

		#region SpecieVenonat Builder
		public SpecieVenonat() : base(
			"Venonat",
			1.0,
			30.0,
			60, // HPs
			55, 50, // Attack & Defense
			40, 55, // Special Attack & Defense
			45		
		)
		{}
		#endregion
	}
	#endregion

	//Venonat Pokemon Class
	#region Venonat
	public class Venonat : Pokemon
	{
		#region Venonat Builders
		/// <summary>
		/// Venonat Builder waiting for a Nickname & a Level
		/// </summary>
		public Venonat(string nickname, int level)
		: base(
				48,
				SpecieVenonat.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Venonat Builder only waiting for a Level
		/// </summary>
		public Venonat(int level)
		: base(
				48,
				SpecieVenonat.Instance, // Pokemon Specie
				"Venonat", level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Venonat Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Venonat() : base(
			48,
			SpecieVenonat.Instance, // Pokemon Specie
			Bug.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}