using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Zekrom Specie to store common natural stats of all Zekroms
	#region SpecieZekrom
	public class SpecieZekrom : PokemonSpecie
	{
#nullable enable
		private static SpecieZekrom? _instance = null;
#nullable restore
        public static SpecieZekrom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZekrom();
                }
                return _instance;
            }
        }

		#region SpecieZekrom Builder
		public SpecieZekrom() : base(
			"Zekrom",
			2.9,
			345.0,
			100, // HPs
			150, 120, // Attack & Defense
			120, 100, // Special Attack & Defense
			90		
		)
		{}
		#endregion
	}
	#endregion

	//Zekrom Pokemon Class
	#region Zekrom
	public class Zekrom : Pokemon
	{
		#region Zekrom Builders
		/// <summary>
		/// Zekrom Builder waiting for a Nickname & a Level
		/// </summary>
		public Zekrom(string nickname, int level)
		: base(
				644,
				SpecieZekrom.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zekrom Builder only waiting for a Level
		/// </summary>
		public Zekrom(int level)
		: base(
				644,
				SpecieZekrom.Instance, // Pokemon Specie
				"Zekrom", level,
				Dragon.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zekrom Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Zekrom() : base(
			644,
			SpecieZekrom.Instance, // Pokemon Specie
			Dragon.Instance, Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}