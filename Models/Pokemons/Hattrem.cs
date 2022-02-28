using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Hattrem Specie to store common natural stats of all Hattrems
	#region SpecieHattrem
	public class SpecieHattrem : PokemonSpecie
	{
#nullable enable
		private static SpecieHattrem? _instance = null;
#nullable restore
        public static SpecieHattrem Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHattrem();
                }
                return _instance;
            }
        }

		#region SpecieHattrem Builder
		public SpecieHattrem() : base(
			"Hattrem",
			57, // HPs
			40, 65, // Attack & Defense
			86, 73, // Special Attack & Defense
			49			
		) {}
		#endregion
	}
	#endregion

	//Hattrem Pokemon Class
	#region Hattrem
	public class Hattrem : Pokemon
	{
		#region Hattrem Builders
		/// <summary>
		/// Hattrem Builder waiting for a Nickname & a Level
		/// </summary>
		public Hattrem(string nickname, int level)
		: base(
				857,
				SpecieHattrem.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hattrem Builder only waiting for a Level
		/// </summary>
		public Hattrem(int level)
		: base(
				857,
				SpecieHattrem.Instance, // Pokemon Specie
				"Hattrem", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hattrem Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Hattrem() : base(
			857,
			SpecieHattrem.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		#endregion
	}
	#endregion
}