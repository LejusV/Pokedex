using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Barraskewda Specie to store common natural stats of all Barraskewdas
	#region SpecieBarraskewda
	public class SpecieBarraskewda : PokemonSpecie
	{
#nullable enable
		private static SpecieBarraskewda? _instance = null;
#nullable restore
        public static SpecieBarraskewda Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBarraskewda();
                }
                return _instance;
            }
        }

		#region SpecieBarraskewda Builder
		public SpecieBarraskewda() : base(
			"Barraskewda",
			61, // HPs
			123, 60, // Attack & Defense
			60, 50, // Special Attack & Defense
			136			
		) {}
		#endregion
	}
	#endregion

	//Barraskewda Pokemon Class
	#region Barraskewda
	public class Barraskewda : Pokemon
	{
		#region Barraskewda Builders
		/// <summary>
		/// Barraskewda Builder waiting for a Nickname & a Level
		/// </summary>
		public Barraskewda(string nickname, int level)
		: base(
				847,
				SpecieBarraskewda.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Barraskewda Builder only waiting for a Level
		/// </summary>
		public Barraskewda(int level)
		: base(
				847,
				SpecieBarraskewda.Instance, // Pokemon Specie
				"Barraskewda", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Barraskewda Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Barraskewda() : base(
			847,
			SpecieBarraskewda.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		#endregion
	}
	#endregion
}