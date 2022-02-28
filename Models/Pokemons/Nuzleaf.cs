using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Nuzleaf Specie to store common natural stats of all Nuzleafs
	#region SpecieNuzleaf
	public class SpecieNuzleaf : PokemonSpecie
	{
#nullable enable
		private static SpecieNuzleaf? _instance = null;
#nullable restore
        public static SpecieNuzleaf Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNuzleaf();
                }
                return _instance;
            }
        }

		#region SpecieNuzleaf Builder
		public SpecieNuzleaf() : base(
			"Nuzleaf",
			70, // HPs
			70, 40, // Attack & Defense
			60, 40, // Special Attack & Defense
			60			
		) {}
		#endregion
	}
	#endregion

	//Nuzleaf Pokemon Class
	#region Nuzleaf
	public class Nuzleaf : Pokemon
	{
		#region Nuzleaf Builders
		/// <summary>
		/// Nuzleaf Builder waiting for a Nickname & a Level
		/// </summary>
		public Nuzleaf(string nickname, int level)
		: base(
				274,
				SpecieNuzleaf.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nuzleaf Builder only waiting for a Level
		/// </summary>
		public Nuzleaf(int level)
		: base(
				274,
				SpecieNuzleaf.Instance, // Pokemon Specie
				"Nuzleaf", level,
				Grass.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nuzleaf Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Nuzleaf() : base(
			274,
			SpecieNuzleaf.Instance, // Pokemon Specie
			Grass.Instance, Dark.Instance			
		) {}
		#endregion
	}
	#endregion
}