using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Grimer Specie to store common natural stats of all Grimers
	#region SpecieGrimer
	public class SpecieGrimer : PokemonSpecie
	{
#nullable enable
		private static SpecieGrimer? _instance = null;
#nullable restore
        public static SpecieGrimer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGrimer();
                }
                return _instance;
            }
        }

		#region SpecieGrimer Builder
		public SpecieGrimer() : base(
			"Grimer",
			80, // HPs
			80, 50, // Attack & Defense
			40, 50, // Special Attack & Defense
			25		
		)
		{
			this._height = 9;
			this._weight = 300;
		}
		#endregion
	}
	#endregion

	//Grimer Pokemon Class
	#region Grimer
	public class Grimer : Pokemon
	{
		#region Grimer Builders
		/// <summary>
		/// Grimer Builder waiting for a Nickname & a Level
		/// </summary>
		public Grimer(string nickname, int level)
		: base(
				88,
				SpecieGrimer.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grimer Builder only waiting for a Level
		/// </summary>
		public Grimer(int level)
		: base(
				88,
				SpecieGrimer.Instance, // Pokemon Specie
				"Grimer", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grimer Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Grimer() : base(
			88,
			SpecieGrimer.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}