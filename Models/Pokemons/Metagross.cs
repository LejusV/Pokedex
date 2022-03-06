using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Metagross Specie to store common natural stats of all Metagrosss
	#region SpecieMetagross
	public class SpecieMetagross : PokemonSpecie
	{
#nullable enable
		private static SpecieMetagross? _instance = null;
#nullable restore
        public static SpecieMetagross Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMetagross();
                }
                return _instance;
            }
        }

		#region SpecieMetagross Builder
		public SpecieMetagross() : base(
			"Metagross",
			80, // HPs
			135, 130, // Attack & Defense
			95, 90, // Special Attack & Defense
			70		
		)
		{
			this._height = 16;
			this._weight = 5500;
		}
		#endregion
	}
	#endregion

	//Metagross Pokemon Class
	#region Metagross
	public class Metagross : Pokemon
	{
		#region Metagross Builders
		/// <summary>
		/// Metagross Builder waiting for a Nickname & a Level
		/// </summary>
		public Metagross(string nickname, int level)
		: base(
				376,
				SpecieMetagross.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Metagross Builder only waiting for a Level
		/// </summary>
		public Metagross(int level)
		: base(
				376,
				SpecieMetagross.Instance, // Pokemon Specie
				"Metagross", level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Metagross Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Metagross() : base(
			376,
			SpecieMetagross.Instance, // Pokemon Specie
			Steel.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}