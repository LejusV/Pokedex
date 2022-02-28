using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Grapploct Specie to store common natural stats of all Grapplocts
	#region SpecieGrapploct
	public class SpecieGrapploct : PokemonSpecie
	{
#nullable enable
		private static SpecieGrapploct? _instance = null;
#nullable restore
        public static SpecieGrapploct Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGrapploct();
                }
                return _instance;
            }
        }

		#region SpecieGrapploct Builder
		public SpecieGrapploct() : base(
			"Grapploct",
			80, // HPs
			118, 90, // Attack & Defense
			70, 80, // Special Attack & Defense
			42			
		) {}
		#endregion
	}
	#endregion

	//Grapploct Pokemon Class
	#region Grapploct
	public class Grapploct : Pokemon
	{
		#region Grapploct Builders
		/// <summary>
		/// Grapploct Builder waiting for a Nickname & a Level
		/// </summary>
		public Grapploct(string nickname, int level)
		: base(
				853,
				SpecieGrapploct.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grapploct Builder only waiting for a Level
		/// </summary>
		public Grapploct(int level)
		: base(
				853,
				SpecieGrapploct.Instance, // Pokemon Specie
				"Grapploct", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grapploct Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Grapploct() : base(
			853,
			SpecieGrapploct.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		#endregion
	}
	#endregion
}