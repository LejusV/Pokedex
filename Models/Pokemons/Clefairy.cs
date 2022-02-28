using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Clefairy Specie to store common natural stats of all Clefairys
	#region SpecieClefairy
	public class SpecieClefairy : PokemonSpecie
	{
#nullable enable
		private static SpecieClefairy? _instance = null;
#nullable restore
        public static SpecieClefairy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieClefairy();
                }
                return _instance;
            }
        }

		#region SpecieClefairy Builder
		public SpecieClefairy() : base(
			"Clefairy",
			70, // HPs
			45, 48, // Attack & Defense
			60, 65, // Special Attack & Defense
			35			
		) {}
		#endregion
	}
	#endregion

	//Clefairy Pokemon Class
	#region Clefairy
	public class Clefairy : Pokemon
	{
		#region Clefairy Builders
		/// <summary>
		/// Clefairy Builder waiting for a Nickname & a Level
		/// </summary>
		public Clefairy(string nickname, int level)
		: base(
				35,
				SpecieClefairy.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clefairy Builder only waiting for a Level
		/// </summary>
		public Clefairy(int level)
		: base(
				35,
				SpecieClefairy.Instance, // Pokemon Specie
				"Clefairy", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clefairy Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Clefairy() : base(
			35,
			SpecieClefairy.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
		#endregion
	}
	#endregion
}