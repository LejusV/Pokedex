using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Honedge Specie to store common natural stats of all Honedges
	#region SpecieHonedge
	public class SpecieHonedge : PokemonSpecie
	{
#nullable enable
		private static SpecieHonedge? _instance = null;
#nullable restore
        public static SpecieHonedge Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHonedge();
                }
                return _instance;
            }
        }

		#region SpecieHonedge Builder
		public SpecieHonedge() : base(
			"Honedge",
			45, // HPs
			80, 100, // Attack & Defense
			35, 37, // Special Attack & Defense
			28			
		) {}
		#endregion
	}
	#endregion

	//Honedge Pokemon Class
	#region Honedge
	public class Honedge : Pokemon
	{
		#region Honedge Builders
		/// <summary>
		/// Honedge Builder waiting for a Nickname & a Level
		/// </summary>
		public Honedge(string nickname, int level)
		: base(
				679,
				SpecieHonedge.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Honedge Builder only waiting for a Level
		/// </summary>
		public Honedge(int level)
		: base(
				679,
				SpecieHonedge.Instance, // Pokemon Specie
				"Honedge", level,
				Steel.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Honedge Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Honedge() : base(
			679,
			SpecieHonedge.Instance, // Pokemon Specie
			Steel.Instance, Ghost.Instance			
		) {}
		#endregion
	}
	#endregion
}