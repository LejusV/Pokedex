using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Charizard Specie to store common natural stats of all Charizards
	#region SpecieCharizard
	public class SpecieCharizard : PokemonSpecie
	{
#nullable enable
		private static SpecieCharizard? _instance = null;
#nullable restore
        public static SpecieCharizard Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCharizard();
                }
                return _instance;
            }
        }

		#region SpecieCharizard Builder
		public SpecieCharizard() : base(
			"Charizard",
			78, // HPs
			84, 78, // Attack & Defense
			109, 85, // Special Attack & Defense
			100			
		) {}
		#endregion
	}
	#endregion

	//Charizard Pokemon Class
	#region Charizard
	public class Charizard : Pokemon
	{
		#region Charizard Builders
		/// <summary>
		/// Charizard Builder waiting for a Nickname & a Level
		/// </summary>
		public Charizard(string nickname, int level)
		: base(
				6,
				SpecieCharizard.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Charizard Builder only waiting for a Level
		/// </summary>
		public Charizard(int level)
		: base(
				6,
				SpecieCharizard.Instance, // Pokemon Specie
				"Charizard", level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Charizard Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Charizard() : base(
			6,
			SpecieCharizard.Instance, // Pokemon Specie
			Fire.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}