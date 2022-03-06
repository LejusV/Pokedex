using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Mankey Specie to store common natural stats of all Mankeys
	#region SpecieMankey
	public class SpecieMankey : PokemonSpecie
	{
#nullable enable
		private static SpecieMankey? _instance = null;
#nullable restore
        public static SpecieMankey Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMankey();
                }
                return _instance;
            }
        }

		#region SpecieMankey Builder
		public SpecieMankey() : base(
			"Mankey",
			0.5,
			28.0,
			40, // HPs
			80, 35, // Attack & Defense
			35, 45, // Special Attack & Defense
			70		
		)
		{}
		#endregion
	}
	#endregion

	//Mankey Pokemon Class
	#region Mankey
	public class Mankey : Pokemon
	{
		#region Mankey Builders
		/// <summary>
		/// Mankey Builder waiting for a Nickname & a Level
		/// </summary>
		public Mankey(string nickname, int level)
		: base(
				56,
				SpecieMankey.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mankey Builder only waiting for a Level
		/// </summary>
		public Mankey(int level)
		: base(
				56,
				SpecieMankey.Instance, // Pokemon Specie
				"Mankey", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mankey Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Mankey() : base(
			56,
			SpecieMankey.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}