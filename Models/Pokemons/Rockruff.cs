using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Rockruff Specie to store common natural stats of all Rockruffs
	#region SpecieRockruff
	public class SpecieRockruff : PokemonSpecie
	{
#nullable enable
		private static SpecieRockruff? _instance = null;
#nullable restore
        public static SpecieRockruff Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRockruff();
                }
                return _instance;
            }
        }

		#region SpecieRockruff Builder
		public SpecieRockruff() : base(
			"Rockruff",
			45, // HPs
			65, 40, // Attack & Defense
			30, 40, // Special Attack & Defense
			60			
		) {}
		#endregion
	}
	#endregion

	//Rockruff Pokemon Class
	#region Rockruff
	public class Rockruff : Pokemon
	{
		#region Rockruff Builders
		/// <summary>
		/// Rockruff Builder waiting for a Nickname & a Level
		/// </summary>
		public Rockruff(string nickname, int level)
		: base(
				744,
				SpecieRockruff.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rockruff Builder only waiting for a Level
		/// </summary>
		public Rockruff(int level)
		: base(
				744,
				SpecieRockruff.Instance, // Pokemon Specie
				"Rockruff", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rockruff Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Rockruff() : base(
			744,
			SpecieRockruff.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
		#endregion
	}
	#endregion
}