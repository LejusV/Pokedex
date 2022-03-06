using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Geodude Specie to store common natural stats of all Geodudes
	#region SpecieGeodude
	public class SpecieGeodude : PokemonSpecie
	{
#nullable enable
		private static SpecieGeodude? _instance = null;
#nullable restore
        public static SpecieGeodude Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGeodude();
                }
                return _instance;
            }
        }

		#region SpecieGeodude Builder
		public SpecieGeodude() : base(
			"Geodude",
			0.4,
			20.0,
			40, // HPs
			80, 100, // Attack & Defense
			30, 30, // Special Attack & Defense
			20		
		)
		{}
		#endregion
	}
	#endregion

	//Geodude Pokemon Class
	#region Geodude
	public class Geodude : Pokemon
	{
		#region Geodude Builders
		/// <summary>
		/// Geodude Builder waiting for a Nickname & a Level
		/// </summary>
		public Geodude(string nickname, int level)
		: base(
				74,
				SpecieGeodude.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Geodude Builder only waiting for a Level
		/// </summary>
		public Geodude(int level)
		: base(
				74,
				SpecieGeodude.Instance, // Pokemon Specie
				"Geodude", level,
				Rock.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Geodude Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Geodude() : base(
			74,
			SpecieGeodude.Instance, // Pokemon Specie
			Rock.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}