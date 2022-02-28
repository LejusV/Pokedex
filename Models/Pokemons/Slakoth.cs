using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Slakoth Specie to store common natural stats of all Slakoths
	#region SpecieSlakoth
	public class SpecieSlakoth : PokemonSpecie
	{
#nullable enable
		private static SpecieSlakoth? _instance = null;
#nullable restore
        public static SpecieSlakoth Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSlakoth();
                }
                return _instance;
            }
        }

		#region SpecieSlakoth Builder
		public SpecieSlakoth() : base(
			"Slakoth",
			60, // HPs
			60, 60, // Attack & Defense
			35, 35, // Special Attack & Defense
			30			
		) {}
		#endregion
	}
	#endregion

	//Slakoth Pokemon Class
	#region Slakoth
	public class Slakoth : Pokemon
	{
		#region Slakoth Builders
		/// <summary>
		/// Slakoth Builder waiting for a Nickname & a Level
		/// </summary>
		public Slakoth(string nickname, int level)
		: base(
				287,
				SpecieSlakoth.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slakoth Builder only waiting for a Level
		/// </summary>
		public Slakoth(int level)
		: base(
				287,
				SpecieSlakoth.Instance, // Pokemon Specie
				"Slakoth", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slakoth Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Slakoth() : base(
			287,
			SpecieSlakoth.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		#endregion
	}
	#endregion
}