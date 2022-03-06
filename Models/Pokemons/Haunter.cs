using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Haunter Specie to store common natural stats of all Haunters
	#region SpecieHaunter
	public class SpecieHaunter : PokemonSpecie
	{
#nullable enable
		private static SpecieHaunter? _instance = null;
#nullable restore
        public static SpecieHaunter Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHaunter();
                }
                return _instance;
            }
        }

		#region SpecieHaunter Builder
		public SpecieHaunter() : base(
			"Haunter",
			45, // HPs
			50, 45, // Attack & Defense
			115, 55, // Special Attack & Defense
			95		
		)
		{
			this._height = 16;
			this._weight = 1;
		}
		#endregion
	}
	#endregion

	//Haunter Pokemon Class
	#region Haunter
	public class Haunter : Pokemon
	{
		#region Haunter Builders
		/// <summary>
		/// Haunter Builder waiting for a Nickname & a Level
		/// </summary>
		public Haunter(string nickname, int level)
		: base(
				93,
				SpecieHaunter.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Haunter Builder only waiting for a Level
		/// </summary>
		public Haunter(int level)
		: base(
				93,
				SpecieHaunter.Instance, // Pokemon Specie
				"Haunter", level,
				Ghost.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Haunter Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Haunter() : base(
			93,
			SpecieHaunter.Instance, // Pokemon Specie
			Ghost.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}