using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Togepi Specie to store common natural stats of all Togepis
	#region SpecieTogepi
	public class SpecieTogepi : PokemonSpecie
	{
#nullable enable
		private static SpecieTogepi? _instance = null;
#nullable restore
        public static SpecieTogepi Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTogepi();
                }
                return _instance;
            }
        }

		#region SpecieTogepi Builder
		public SpecieTogepi() : base(
			"Togepi",
			35, // HPs
			20, 65, // Attack & Defense
			40, 65, // Special Attack & Defense
			20		
		)
		{
			this._height = 3;
			this._weight = 15;
		}
		#endregion
	}
	#endregion

	//Togepi Pokemon Class
	#region Togepi
	public class Togepi : Pokemon
	{
		#region Togepi Builders
		/// <summary>
		/// Togepi Builder waiting for a Nickname & a Level
		/// </summary>
		public Togepi(string nickname, int level)
		: base(
				175,
				SpecieTogepi.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Togepi Builder only waiting for a Level
		/// </summary>
		public Togepi(int level)
		: base(
				175,
				SpecieTogepi.Instance, // Pokemon Specie
				"Togepi", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Togepi Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Togepi() : base(
			175,
			SpecieTogepi.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}