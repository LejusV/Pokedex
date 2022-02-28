using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Morgrem Specie to store common natural stats of all Morgrems
	#region SpecieMorgrem
	public class SpecieMorgrem : PokemonSpecie
	{
#nullable enable
		private static SpecieMorgrem? _instance = null;
#nullable restore
        public static SpecieMorgrem Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMorgrem();
                }
                return _instance;
            }
        }

		#region SpecieMorgrem Builder
		public SpecieMorgrem() : base(
			"Morgrem",
			65, // HPs
			60, 45, // Attack & Defense
			75, 55, // Special Attack & Defense
			70			
		) {}
		#endregion
	}
	#endregion

	//Morgrem Pokemon Class
	#region Morgrem
	public class Morgrem : Pokemon
	{
		#region Morgrem Builders
		/// <summary>
		/// Morgrem Builder waiting for a Nickname & a Level
		/// </summary>
		public Morgrem(string nickname, int level)
		: base(
				860,
				SpecieMorgrem.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Morgrem Builder only waiting for a Level
		/// </summary>
		public Morgrem(int level)
		: base(
				860,
				SpecieMorgrem.Instance, // Pokemon Specie
				"Morgrem", level,
				Dark.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Morgrem Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Morgrem() : base(
			860,
			SpecieMorgrem.Instance, // Pokemon Specie
			Dark.Instance, Fairy.Instance			
		) {}
		#endregion
	}
	#endregion
}