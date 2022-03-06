using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Dialga Specie to store common natural stats of all Dialgas
	#region SpecieDialga
	public class SpecieDialga : PokemonSpecie
	{
#nullable enable
		private static SpecieDialga? _instance = null;
#nullable restore
        public static SpecieDialga Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDialga();
                }
                return _instance;
            }
        }

		#region SpecieDialga Builder
		public SpecieDialga() : base(
			"Dialga",
			5.4,
			683.0,
			100, // HPs
			120, 120, // Attack & Defense
			150, 100, // Special Attack & Defense
			90		
		)
		{}
		#endregion
	}
	#endregion

	//Dialga Pokemon Class
	#region Dialga
	public class Dialga : Pokemon
	{
		#region Dialga Builders
		/// <summary>
		/// Dialga Builder waiting for a Nickname & a Level
		/// </summary>
		public Dialga(string nickname, int level)
		: base(
				483,
				SpecieDialga.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dialga Builder only waiting for a Level
		/// </summary>
		public Dialga(int level)
		: base(
				483,
				SpecieDialga.Instance, // Pokemon Specie
				"Dialga", level,
				Steel.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dialga Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Dialga() : base(
			483,
			SpecieDialga.Instance, // Pokemon Specie
			Steel.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}