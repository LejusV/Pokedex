using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Smeargle Specie to store common natural stats of all Smeargles
	#region SpecieSmeargle
	public class SpecieSmeargle : PokemonSpecie
	{
#nullable enable
		private static SpecieSmeargle? _instance = null;
#nullable restore
        public static SpecieSmeargle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSmeargle();
                }
                return _instance;
            }
        }

		#region SpecieSmeargle Builder
		public SpecieSmeargle() : base(
			"Smeargle",
			1.2,
			58.0,
			55, // HPs
			20, 35, // Attack & Defense
			20, 45, // Special Attack & Defense
			75		
		)
		{}
		#endregion
	}
	#endregion

	//Smeargle Pokemon Class
	#region Smeargle
	public class Smeargle : Pokemon
	{
		#region Smeargle Builders
		/// <summary>
		/// Smeargle Builder waiting for a Nickname & a Level
		/// </summary>
		public Smeargle(string nickname, int level)
		: base(
				235,
				SpecieSmeargle.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Smeargle Builder only waiting for a Level
		/// </summary>
		public Smeargle(int level)
		: base(
				235,
				SpecieSmeargle.Instance, // Pokemon Specie
				"Smeargle", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Smeargle Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Smeargle() : base(
			235,
			SpecieSmeargle.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}