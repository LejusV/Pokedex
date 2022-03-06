using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Slowking Specie to store common natural stats of all Slowkings
	#region SpecieSlowking
	public class SpecieSlowking : PokemonSpecie
	{
#nullable enable
		private static SpecieSlowking? _instance = null;
#nullable restore
        public static SpecieSlowking Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSlowking();
                }
                return _instance;
            }
        }

		#region SpecieSlowking Builder
		public SpecieSlowking() : base(
			"Slowking",
			95, // HPs
			75, 80, // Attack & Defense
			100, 110, // Special Attack & Defense
			30		
		)
		{
			this._height = 20;
			this._weight = 795;
		}
		#endregion
	}
	#endregion

	//Slowking Pokemon Class
	#region Slowking
	public class Slowking : Pokemon
	{
		#region Slowking Builders
		/// <summary>
		/// Slowking Builder waiting for a Nickname & a Level
		/// </summary>
		public Slowking(string nickname, int level)
		: base(
				199,
				SpecieSlowking.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slowking Builder only waiting for a Level
		/// </summary>
		public Slowking(int level)
		: base(
				199,
				SpecieSlowking.Instance, // Pokemon Specie
				"Slowking", level,
				Water.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slowking Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Slowking() : base(
			199,
			SpecieSlowking.Instance, // Pokemon Specie
			Water.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}