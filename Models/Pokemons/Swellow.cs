using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Swellow Specie to store common natural stats of all Swellows
	#region SpecieSwellow
	public class SpecieSwellow : PokemonSpecie
	{
#nullable enable
		private static SpecieSwellow? _instance = null;
#nullable restore
        public static SpecieSwellow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSwellow();
                }
                return _instance;
            }
        }

		#region SpecieSwellow Builder
		public SpecieSwellow() : base(
			"Swellow",
			0.7,
			19.8,
			60, // HPs
			85, 60, // Attack & Defense
			75, 50, // Special Attack & Defense
			125		
		)
		{}
		#endregion
	}
	#endregion

	//Swellow Pokemon Class
	#region Swellow
	public class Swellow : Pokemon
	{
		#region Swellow Builders
		/// <summary>
		/// Swellow Builder waiting for a Nickname & a Level
		/// </summary>
		public Swellow(string nickname, int level)
		: base(
				277,
				SpecieSwellow.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swellow Builder only waiting for a Level
		/// </summary>
		public Swellow(int level)
		: base(
				277,
				SpecieSwellow.Instance, // Pokemon Specie
				"Swellow", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swellow Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Swellow() : base(
			277,
			SpecieSwellow.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}