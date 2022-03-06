using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Yanmega Specie to store common natural stats of all Yanmegas
	#region SpecieYanmega
	public class SpecieYanmega : PokemonSpecie
	{
#nullable enable
		private static SpecieYanmega? _instance = null;
#nullable restore
        public static SpecieYanmega Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieYanmega();
                }
                return _instance;
            }
        }

		#region SpecieYanmega Builder
		public SpecieYanmega() : base(
			"Yanmega",
			86, // HPs
			76, 86, // Attack & Defense
			116, 56, // Special Attack & Defense
			95		
		)
		{
			this._height = 19;
			this._weight = 515;
		}
		#endregion
	}
	#endregion

	//Yanmega Pokemon Class
	#region Yanmega
	public class Yanmega : Pokemon
	{
		#region Yanmega Builders
		/// <summary>
		/// Yanmega Builder waiting for a Nickname & a Level
		/// </summary>
		public Yanmega(string nickname, int level)
		: base(
				469,
				SpecieYanmega.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yanmega Builder only waiting for a Level
		/// </summary>
		public Yanmega(int level)
		: base(
				469,
				SpecieYanmega.Instance, // Pokemon Specie
				"Yanmega", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yanmega Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Yanmega() : base(
			469,
			SpecieYanmega.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}