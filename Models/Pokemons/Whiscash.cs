using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Whiscash Specie to store common natural stats of all Whiscashs
	#region SpecieWhiscash
	public class SpecieWhiscash : PokemonSpecie
	{
#nullable enable
		private static SpecieWhiscash? _instance = null;
#nullable restore
        public static SpecieWhiscash Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWhiscash();
                }
                return _instance;
            }
        }

		#region SpecieWhiscash Builder
		public SpecieWhiscash() : base(
			"Whiscash",
			110, // HPs
			78, 73, // Attack & Defense
			76, 71, // Special Attack & Defense
			60			
		) {}
		#endregion
	}
	#endregion

	//Whiscash Pokemon Class
	#region Whiscash
	public class Whiscash : Pokemon
	{
		#region Whiscash Builders
		/// <summary>
		/// Whiscash Builder waiting for a Nickname & a Level
		/// </summary>
		public Whiscash(string nickname, int level)
		: base(
				340,
				SpecieWhiscash.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Whiscash Builder only waiting for a Level
		/// </summary>
		public Whiscash(int level)
		: base(
				340,
				SpecieWhiscash.Instance, // Pokemon Specie
				"Whiscash", level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Whiscash Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Whiscash() : base(
			340,
			SpecieWhiscash.Instance, // Pokemon Specie
			Water.Instance, Ground.Instance			
		) {}
		#endregion
	}
	#endregion
}