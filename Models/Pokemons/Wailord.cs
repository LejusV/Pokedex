using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Wailord Specie to store common natural stats of all Wailords
	#region SpecieWailord
	public class SpecieWailord : PokemonSpecie
	{
#nullable enable
		private static SpecieWailord? _instance = null;
#nullable restore
        public static SpecieWailord Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWailord();
                }
                return _instance;
            }
        }

		#region SpecieWailord Builder
		public SpecieWailord() : base(
			"Wailord",
			170, // HPs
			90, 45, // Attack & Defense
			90, 45, // Special Attack & Defense
			60		
		)
		{
			this._height = 145;
			this._weight = 3980;
		}
		#endregion
	}
	#endregion

	//Wailord Pokemon Class
	#region Wailord
	public class Wailord : Pokemon
	{
		#region Wailord Builders
		/// <summary>
		/// Wailord Builder waiting for a Nickname & a Level
		/// </summary>
		public Wailord(string nickname, int level)
		: base(
				321,
				SpecieWailord.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wailord Builder only waiting for a Level
		/// </summary>
		public Wailord(int level)
		: base(
				321,
				SpecieWailord.Instance, // Pokemon Specie
				"Wailord", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wailord Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Wailord() : base(
			321,
			SpecieWailord.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}