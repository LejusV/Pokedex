using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Shuppet Specie to store common natural stats of all Shuppets
	#region SpecieShuppet
	public class SpecieShuppet : PokemonSpecie
	{
#nullable enable
		private static SpecieShuppet? _instance = null;
#nullable restore
        public static SpecieShuppet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShuppet();
                }
                return _instance;
            }
        }

		#region SpecieShuppet Builder
		public SpecieShuppet() : base(
			"Shuppet",
			44, // HPs
			75, 35, // Attack & Defense
			63, 33, // Special Attack & Defense
			45			
		) {}
		#endregion
	}
	#endregion

	//Shuppet Pokemon Class
	#region Shuppet
	public class Shuppet : Pokemon
	{
		#region Shuppet Builders
		/// <summary>
		/// Shuppet Builder waiting for a Nickname & a Level
		/// </summary>
		public Shuppet(string nickname, int level)
		: base(
				353,
				SpecieShuppet.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shuppet Builder only waiting for a Level
		/// </summary>
		public Shuppet(int level)
		: base(
				353,
				SpecieShuppet.Instance, // Pokemon Specie
				"Shuppet", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shuppet Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Shuppet() : base(
			353,
			SpecieShuppet.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
		#endregion
	}
	#endregion
}