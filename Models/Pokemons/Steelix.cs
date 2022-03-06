using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Steelix Specie to store common natural stats of all Steelixs
	#region SpecieSteelix
	public class SpecieSteelix : PokemonSpecie
	{
#nullable enable
		private static SpecieSteelix? _instance = null;
#nullable restore
        public static SpecieSteelix Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSteelix();
                }
                return _instance;
            }
        }

		#region SpecieSteelix Builder
		public SpecieSteelix() : base(
			"Steelix",
			75, // HPs
			85, 200, // Attack & Defense
			55, 65, // Special Attack & Defense
			30		
		)
		{
			this._height = 92;
			this._weight = 4000;
		}
		#endregion
	}
	#endregion

	//Steelix Pokemon Class
	#region Steelix
	public class Steelix : Pokemon
	{
		#region Steelix Builders
		/// <summary>
		/// Steelix Builder waiting for a Nickname & a Level
		/// </summary>
		public Steelix(string nickname, int level)
		: base(
				208,
				SpecieSteelix.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Steelix Builder only waiting for a Level
		/// </summary>
		public Steelix(int level)
		: base(
				208,
				SpecieSteelix.Instance, // Pokemon Specie
				"Steelix", level,
				Steel.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Steelix Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Steelix() : base(
			208,
			SpecieSteelix.Instance, // Pokemon Specie
			Steel.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}