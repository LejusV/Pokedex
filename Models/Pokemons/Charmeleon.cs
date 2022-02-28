using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Charmeleon Specie to store common natural stats of all Charmeleons
	#region SpecieCharmeleon
	public class SpecieCharmeleon : PokemonSpecie
	{
#nullable enable
		private static SpecieCharmeleon? _instance = null;
#nullable restore
        public static SpecieCharmeleon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCharmeleon();
                }
                return _instance;
            }
        }

		#region SpecieCharmeleon Builder
		public SpecieCharmeleon() : base(
			"Charmeleon",
			58, // HPs
			64, 58, // Attack & Defense
			80, 65, // Special Attack & Defense
			80			
		) {}
		#endregion
	}
	#endregion

	//Charmeleon Pokemon Class
	#region Charmeleon
	public class Charmeleon : Pokemon
	{
		#region Charmeleon Builders
		/// <summary>
		/// Charmeleon Builder waiting for a Nickname & a Level
		/// </summary>
		public Charmeleon(string nickname, int level)
		: base(
				5,
				SpecieCharmeleon.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Charmeleon Builder only waiting for a Level
		/// </summary>
		public Charmeleon(int level)
		: base(
				5,
				SpecieCharmeleon.Instance, // Pokemon Specie
				"Charmeleon", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Charmeleon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Charmeleon() : base(
			5,
			SpecieCharmeleon.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		#endregion
	}
	#endregion
}