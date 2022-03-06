using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Shieldon Specie to store common natural stats of all Shieldons
	#region SpecieShieldon
	public class SpecieShieldon : PokemonSpecie
	{
#nullable enable
		private static SpecieShieldon? _instance = null;
#nullable restore
        public static SpecieShieldon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShieldon();
                }
                return _instance;
            }
        }

		#region SpecieShieldon Builder
		public SpecieShieldon() : base(
			"Shieldon",
			0.5,
			57.0,
			30, // HPs
			42, 118, // Attack & Defense
			42, 88, // Special Attack & Defense
			30		
		)
		{}
		#endregion
	}
	#endregion

	//Shieldon Pokemon Class
	#region Shieldon
	public class Shieldon : Pokemon
	{
		#region Shieldon Builders
		/// <summary>
		/// Shieldon Builder waiting for a Nickname & a Level
		/// </summary>
		public Shieldon(string nickname, int level)
		: base(
				410,
				SpecieShieldon.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shieldon Builder only waiting for a Level
		/// </summary>
		public Shieldon(int level)
		: base(
				410,
				SpecieShieldon.Instance, // Pokemon Specie
				"Shieldon", level,
				Rock.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shieldon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Shieldon() : base(
			410,
			SpecieShieldon.Instance, // Pokemon Specie
			Rock.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}