using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Huntail Specie to store common natural stats of all Huntails
	#region SpecieHuntail
	public class SpecieHuntail : PokemonSpecie
	{
#nullable enable
		private static SpecieHuntail? _instance = null;
#nullable restore
        public static SpecieHuntail Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHuntail();
                }
                return _instance;
            }
        }

		#region SpecieHuntail Builder
		public SpecieHuntail() : base(
			"Huntail",
			55, // HPs
			104, 105, // Attack & Defense
			94, 75, // Special Attack & Defense
			52			
		) {}
		#endregion
	}
	#endregion

	//Huntail Pokemon Class
	#region Huntail
	public class Huntail : Pokemon
	{
		#region Huntail Builders
		/// <summary>
		/// Huntail Builder waiting for a Nickname & a Level
		/// </summary>
		public Huntail(string nickname, int level)
		: base(
				367,
				SpecieHuntail.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Huntail Builder only waiting for a Level
		/// </summary>
		public Huntail(int level)
		: base(
				367,
				SpecieHuntail.Instance, // Pokemon Specie
				"Huntail", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Huntail Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Huntail() : base(
			367,
			SpecieHuntail.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		#endregion
	}
	#endregion
}