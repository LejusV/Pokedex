using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Parasect Specie to store common natural stats of all Parasects
	#region SpecieParasect
	public class SpecieParasect : PokemonSpecie
	{
#nullable enable
		private static SpecieParasect? _instance = null;
#nullable restore
        public static SpecieParasect Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieParasect();
                }
                return _instance;
            }
        }

		#region SpecieParasect Builder
		public SpecieParasect() : base(
			"Parasect",
			60, // HPs
			95, 80, // Attack & Defense
			60, 80, // Special Attack & Defense
			30		
		)
		{
			this._height = 10;
			this._weight = 295;
		}
		#endregion
	}
	#endregion

	//Parasect Pokemon Class
	#region Parasect
	public class Parasect : Pokemon
	{
		#region Parasect Builders
		/// <summary>
		/// Parasect Builder waiting for a Nickname & a Level
		/// </summary>
		public Parasect(string nickname, int level)
		: base(
				47,
				SpecieParasect.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Parasect Builder only waiting for a Level
		/// </summary>
		public Parasect(int level)
		: base(
				47,
				SpecieParasect.Instance, // Pokemon Specie
				"Parasect", level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Parasect Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Parasect() : base(
			47,
			SpecieParasect.Instance, // Pokemon Specie
			Bug.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}