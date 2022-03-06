using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Leafeon Specie to store common natural stats of all Leafeons
	#region SpecieLeafeon
	public class SpecieLeafeon : PokemonSpecie
	{
#nullable enable
		private static SpecieLeafeon? _instance = null;
#nullable restore
        public static SpecieLeafeon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLeafeon();
                }
                return _instance;
            }
        }

		#region SpecieLeafeon Builder
		public SpecieLeafeon() : base(
			"Leafeon",
			65, // HPs
			110, 130, // Attack & Defense
			60, 65, // Special Attack & Defense
			95		
		)
		{
			this._height = 10;
			this._weight = 255;
		}
		#endregion
	}
	#endregion

	//Leafeon Pokemon Class
	#region Leafeon
	public class Leafeon : Pokemon
	{
		#region Leafeon Builders
		/// <summary>
		/// Leafeon Builder waiting for a Nickname & a Level
		/// </summary>
		public Leafeon(string nickname, int level)
		: base(
				470,
				SpecieLeafeon.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Leafeon Builder only waiting for a Level
		/// </summary>
		public Leafeon(int level)
		: base(
				470,
				SpecieLeafeon.Instance, // Pokemon Specie
				"Leafeon", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Leafeon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Leafeon() : base(
			470,
			SpecieLeafeon.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}