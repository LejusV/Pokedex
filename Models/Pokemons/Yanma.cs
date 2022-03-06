using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Yanma Specie to store common natural stats of all Yanmas
	#region SpecieYanma
	public class SpecieYanma : PokemonSpecie
	{
#nullable enable
		private static SpecieYanma? _instance = null;
#nullable restore
        public static SpecieYanma Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieYanma();
                }
                return _instance;
            }
        }

		#region SpecieYanma Builder
		public SpecieYanma() : base(
			"Yanma",
			1.2,
			38.0,
			65, // HPs
			65, 45, // Attack & Defense
			75, 45, // Special Attack & Defense
			95		
		)
		{}
		#endregion
	}
	#endregion

	//Yanma Pokemon Class
	#region Yanma
	public class Yanma : Pokemon
	{
		#region Yanma Builders
		/// <summary>
		/// Yanma Builder waiting for a Nickname & a Level
		/// </summary>
		public Yanma(string nickname, int level)
		: base(
				193,
				SpecieYanma.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yanma Builder only waiting for a Level
		/// </summary>
		public Yanma(int level)
		: base(
				193,
				SpecieYanma.Instance, // Pokemon Specie
				"Yanma", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yanma Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Yanma() : base(
			193,
			SpecieYanma.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}