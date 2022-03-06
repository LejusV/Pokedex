using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Karrablast Specie to store common natural stats of all Karrablasts
	#region SpecieKarrablast
	public class SpecieKarrablast : PokemonSpecie
	{
#nullable enable
		private static SpecieKarrablast? _instance = null;
#nullable restore
        public static SpecieKarrablast Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKarrablast();
                }
                return _instance;
            }
        }

		#region SpecieKarrablast Builder
		public SpecieKarrablast() : base(
			"Karrablast",
			0.5,
			5.9,
			50, // HPs
			75, 45, // Attack & Defense
			40, 45, // Special Attack & Defense
			60		
		)
		{}
		#endregion
	}
	#endregion

	//Karrablast Pokemon Class
	#region Karrablast
	public class Karrablast : Pokemon
	{
		#region Karrablast Builders
		/// <summary>
		/// Karrablast Builder waiting for a Nickname & a Level
		/// </summary>
		public Karrablast(string nickname, int level)
		: base(
				588,
				SpecieKarrablast.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Karrablast Builder only waiting for a Level
		/// </summary>
		public Karrablast(int level)
		: base(
				588,
				SpecieKarrablast.Instance, // Pokemon Specie
				"Karrablast", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Karrablast Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Karrablast() : base(
			588,
			SpecieKarrablast.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}