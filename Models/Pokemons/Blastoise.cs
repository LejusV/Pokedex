using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Blastoise Specie to store common natural stats of all Blastoises
	#region SpecieBlastoise
	public class SpecieBlastoise : PokemonSpecie
	{
#nullable enable
		private static SpecieBlastoise? _instance = null;
#nullable restore
        public static SpecieBlastoise Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBlastoise();
                }
                return _instance;
            }
        }

		#region SpecieBlastoise Builder
		public SpecieBlastoise() : base(
			"Blastoise",
			79, // HPs
			83, 100, // Attack & Defense
			85, 105, // Special Attack & Defense
			78			
		) {}
		#endregion
	}
	#endregion

	//Blastoise Pokemon Class
	#region Blastoise
	public class Blastoise : Pokemon
	{
		#region Blastoise Builders
		/// <summary>
		/// Blastoise Builder waiting for a Nickname & a Level
		/// </summary>
		public Blastoise(string nickname, int level)
		: base(
				9,
				SpecieBlastoise.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blastoise Builder only waiting for a Level
		/// </summary>
		public Blastoise(int level)
		: base(
				9,
				SpecieBlastoise.Instance, // Pokemon Specie
				"Blastoise", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blastoise Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Blastoise() : base(
			9,
			SpecieBlastoise.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		#endregion
	}
	#endregion
}