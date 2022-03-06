using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Empoleon Specie to store common natural stats of all Empoleons
	#region SpecieEmpoleon
	public class SpecieEmpoleon : PokemonSpecie
	{
#nullable enable
		private static SpecieEmpoleon? _instance = null;
#nullable restore
        public static SpecieEmpoleon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEmpoleon();
                }
                return _instance;
            }
        }

		#region SpecieEmpoleon Builder
		public SpecieEmpoleon() : base(
			"Empoleon",
			84, // HPs
			86, 88, // Attack & Defense
			111, 101, // Special Attack & Defense
			60		
		)
		{
			this._height = 17;
			this._weight = 845;
		}
		#endregion
	}
	#endregion

	//Empoleon Pokemon Class
	#region Empoleon
	public class Empoleon : Pokemon
	{
		#region Empoleon Builders
		/// <summary>
		/// Empoleon Builder waiting for a Nickname & a Level
		/// </summary>
		public Empoleon(string nickname, int level)
		: base(
				395,
				SpecieEmpoleon.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Empoleon Builder only waiting for a Level
		/// </summary>
		public Empoleon(int level)
		: base(
				395,
				SpecieEmpoleon.Instance, // Pokemon Specie
				"Empoleon", level,
				Water.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Empoleon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Empoleon() : base(
			395,
			SpecieEmpoleon.Instance, // Pokemon Specie
			Water.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}