using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Poliwrath Specie to store common natural stats of all Poliwraths
	#region SpeciePoliwrath
	public class SpeciePoliwrath : PokemonSpecie
	{
#nullable enable
		private static SpeciePoliwrath? _instance = null;
#nullable restore
        public static SpeciePoliwrath Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePoliwrath();
                }
                return _instance;
            }
        }

		#region SpeciePoliwrath Builder
		public SpeciePoliwrath() : base(
			"Poliwrath",
			1.3,
			54.0,
			90, // HPs
			95, 95, // Attack & Defense
			70, 90, // Special Attack & Defense
			70		
		)
		{}
		#endregion
	}
	#endregion

	//Poliwrath Pokemon Class
	#region Poliwrath
	public class Poliwrath : Pokemon
	{
		#region Poliwrath Builders
		/// <summary>
		/// Poliwrath Builder waiting for a Nickname & a Level
		/// </summary>
		public Poliwrath(string nickname, int level)
		: base(
				62,
				SpeciePoliwrath.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poliwrath Builder only waiting for a Level
		/// </summary>
		public Poliwrath(int level)
		: base(
				62,
				SpeciePoliwrath.Instance, // Pokemon Specie
				"Poliwrath", level,
				Water.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poliwrath Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Poliwrath() : base(
			62,
			SpeciePoliwrath.Instance, // Pokemon Specie
			Water.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}