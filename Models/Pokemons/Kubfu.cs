using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Kubfu Specie to store common natural stats of all Kubfus
	#region SpecieKubfu
	public class SpecieKubfu : PokemonSpecie
	{
#nullable enable
		private static SpecieKubfu? _instance = null;
#nullable restore
        public static SpecieKubfu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKubfu();
                }
                return _instance;
            }
        }

		#region SpecieKubfu Builder
		public SpecieKubfu() : base(
			"Kubfu",
			0.6,
			12.0,
			60, // HPs
			90, 60, // Attack & Defense
			53, 50, // Special Attack & Defense
			72		
		)
		{}
		#endregion
	}
	#endregion

	//Kubfu Pokemon Class
	#region Kubfu
	public class Kubfu : Pokemon
	{
		#region Kubfu Builders
		/// <summary>
		/// Kubfu Builder waiting for a Nickname & a Level
		/// </summary>
		public Kubfu(string nickname, int level)
		: base(
				891,
				SpecieKubfu.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kubfu Builder only waiting for a Level
		/// </summary>
		public Kubfu(int level)
		: base(
				891,
				SpecieKubfu.Instance, // Pokemon Specie
				"Kubfu", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kubfu Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Kubfu() : base(
			891,
			SpecieKubfu.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}