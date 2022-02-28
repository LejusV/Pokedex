using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Fletchling Specie to store common natural stats of all Fletchlings
	#region SpecieFletchling
	public class SpecieFletchling : PokemonSpecie
	{
#nullable enable
		private static SpecieFletchling? _instance = null;
#nullable restore
        public static SpecieFletchling Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFletchling();
                }
                return _instance;
            }
        }

		#region SpecieFletchling Builder
		public SpecieFletchling() : base(
			"Fletchling",
			45, // HPs
			50, 43, // Attack & Defense
			40, 38, // Special Attack & Defense
			62			
		) {}
		#endregion
	}
	#endregion

	//Fletchling Pokemon Class
	#region Fletchling
	public class Fletchling : Pokemon
	{
		#region Fletchling Builders
		/// <summary>
		/// Fletchling Builder waiting for a Nickname & a Level
		/// </summary>
		public Fletchling(string nickname, int level)
		: base(
				661,
				SpecieFletchling.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fletchling Builder only waiting for a Level
		/// </summary>
		public Fletchling(int level)
		: base(
				661,
				SpecieFletchling.Instance, // Pokemon Specie
				"Fletchling", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fletchling Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Fletchling() : base(
			661,
			SpecieFletchling.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}