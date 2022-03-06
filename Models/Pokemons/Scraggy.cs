using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Scraggy Specie to store common natural stats of all Scraggys
	#region SpecieScraggy
	public class SpecieScraggy : PokemonSpecie
	{
#nullable enable
		private static SpecieScraggy? _instance = null;
#nullable restore
        public static SpecieScraggy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieScraggy();
                }
                return _instance;
            }
        }

		#region SpecieScraggy Builder
		public SpecieScraggy() : base(
			"Scraggy",
			0.6,
			11.8,
			50, // HPs
			75, 70, // Attack & Defense
			35, 70, // Special Attack & Defense
			48		
		)
		{}
		#endregion
	}
	#endregion

	//Scraggy Pokemon Class
	#region Scraggy
	public class Scraggy : Pokemon
	{
		#region Scraggy Builders
		/// <summary>
		/// Scraggy Builder waiting for a Nickname & a Level
		/// </summary>
		public Scraggy(string nickname, int level)
		: base(
				559,
				SpecieScraggy.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scraggy Builder only waiting for a Level
		/// </summary>
		public Scraggy(int level)
		: base(
				559,
				SpecieScraggy.Instance, // Pokemon Specie
				"Scraggy", level,
				Dark.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scraggy Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Scraggy() : base(
			559,
			SpecieScraggy.Instance, // Pokemon Specie
			Dark.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}