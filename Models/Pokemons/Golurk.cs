using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Golurk Specie to store common natural stats of all Golurks
	#region SpecieGolurk
	public class SpecieGolurk : PokemonSpecie
	{
#nullable enable
		private static SpecieGolurk? _instance = null;
#nullable restore
        public static SpecieGolurk Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGolurk();
                }
                return _instance;
            }
        }

		#region SpecieGolurk Builder
		public SpecieGolurk() : base(
			"Golurk",
			89, // HPs
			124, 80, // Attack & Defense
			55, 80, // Special Attack & Defense
			55			
		) {}
		#endregion
	}
	#endregion

	//Golurk Pokemon Class
	#region Golurk
	public class Golurk : Pokemon
	{
		#region Golurk Builders
		/// <summary>
		/// Golurk Builder waiting for a Nickname & a Level
		/// </summary>
		public Golurk(string nickname, int level)
		: base(
				623,
				SpecieGolurk.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golurk Builder only waiting for a Level
		/// </summary>
		public Golurk(int level)
		: base(
				623,
				SpecieGolurk.Instance, // Pokemon Specie
				"Golurk", level,
				Ground.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golurk Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Golurk() : base(
			623,
			SpecieGolurk.Instance, // Pokemon Specie
			Ground.Instance, Ghost.Instance			
		) {}
		#endregion
	}
	#endregion
}