using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Nickit Specie to store common natural stats of all Nickits
	#region SpecieNickit
	public class SpecieNickit : PokemonSpecie
	{
#nullable enable
		private static SpecieNickit? _instance = null;
#nullable restore
        public static SpecieNickit Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNickit();
                }
                return _instance;
            }
        }

		#region SpecieNickit Builder
		public SpecieNickit() : base(
			"Nickit",
			0.6,
			8.9,
			40, // HPs
			28, 28, // Attack & Defense
			47, 52, // Special Attack & Defense
			50		
		)
		{}
		#endregion
	}
	#endregion

	//Nickit Pokemon Class
	#region Nickit
	public class Nickit : Pokemon
	{
		#region Nickit Builders
		/// <summary>
		/// Nickit Builder waiting for a Nickname & a Level
		/// </summary>
		public Nickit(string nickname, int level)
		: base(
				827,
				SpecieNickit.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nickit Builder only waiting for a Level
		/// </summary>
		public Nickit(int level)
		: base(
				827,
				SpecieNickit.Instance, // Pokemon Specie
				"Nickit", level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nickit Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Nickit() : base(
			827,
			SpecieNickit.Instance, // Pokemon Specie
			Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}