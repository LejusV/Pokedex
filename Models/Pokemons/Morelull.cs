using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Morelull Specie to store common natural stats of all Morelulls
	#region SpecieMorelull
	public class SpecieMorelull : PokemonSpecie
	{
#nullable enable
		private static SpecieMorelull? _instance = null;
#nullable restore
        public static SpecieMorelull Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMorelull();
                }
                return _instance;
            }
        }

		#region SpecieMorelull Builder
		public SpecieMorelull() : base(
			"Morelull",
			40, // HPs
			35, 55, // Attack & Defense
			65, 75, // Special Attack & Defense
			15		
		)
		{
			this._height = 2;
			this._weight = 15;
		}
		#endregion
	}
	#endregion

	//Morelull Pokemon Class
	#region Morelull
	public class Morelull : Pokemon
	{
		#region Morelull Builders
		/// <summary>
		/// Morelull Builder waiting for a Nickname & a Level
		/// </summary>
		public Morelull(string nickname, int level)
		: base(
				755,
				SpecieMorelull.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Morelull Builder only waiting for a Level
		/// </summary>
		public Morelull(int level)
		: base(
				755,
				SpecieMorelull.Instance, // Pokemon Specie
				"Morelull", level,
				Grass.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Morelull Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Morelull() : base(
			755,
			SpecieMorelull.Instance, // Pokemon Specie
			Grass.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}