using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Granbull Specie to store common natural stats of all Granbulls
	#region SpecieGranbull
	public class SpecieGranbull : PokemonSpecie
	{
#nullable enable
		private static SpecieGranbull? _instance = null;
#nullable restore
        public static SpecieGranbull Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGranbull();
                }
                return _instance;
            }
        }

		#region SpecieGranbull Builder
		public SpecieGranbull() : base(
			"Granbull",
			90, // HPs
			120, 75, // Attack & Defense
			60, 60, // Special Attack & Defense
			45			
		) {}
		#endregion
	}
	#endregion

	//Granbull Pokemon Class
	#region Granbull
	public class Granbull : Pokemon
	{
		#region Granbull Builders
		/// <summary>
		/// Granbull Builder waiting for a Nickname & a Level
		/// </summary>
		public Granbull(string nickname, int level)
		: base(
				210,
				SpecieGranbull.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Granbull Builder only waiting for a Level
		/// </summary>
		public Granbull(int level)
		: base(
				210,
				SpecieGranbull.Instance, // Pokemon Specie
				"Granbull", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Granbull Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Granbull() : base(
			210,
			SpecieGranbull.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
		#endregion
	}
	#endregion
}