using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Zorua Specie to store common natural stats of all Zoruas
	#region SpecieZorua
	public class SpecieZorua : PokemonSpecie
	{
#nullable enable
		private static SpecieZorua? _instance = null;
#nullable restore
        public static SpecieZorua Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZorua();
                }
                return _instance;
            }
        }

		#region SpecieZorua Builder
		public SpecieZorua() : base(
			"Zorua",
			40, // HPs
			65, 40, // Attack & Defense
			80, 40, // Special Attack & Defense
			65		
		)
		{
			this._height = 7;
			this._weight = 125;
		}
		#endregion
	}
	#endregion

	//Zorua Pokemon Class
	#region Zorua
	public class Zorua : Pokemon
	{
		#region Zorua Builders
		/// <summary>
		/// Zorua Builder waiting for a Nickname & a Level
		/// </summary>
		public Zorua(string nickname, int level)
		: base(
				570,
				SpecieZorua.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zorua Builder only waiting for a Level
		/// </summary>
		public Zorua(int level)
		: base(
				570,
				SpecieZorua.Instance, // Pokemon Specie
				"Zorua", level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zorua Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Zorua() : base(
			570,
			SpecieZorua.Instance, // Pokemon Specie
			Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}