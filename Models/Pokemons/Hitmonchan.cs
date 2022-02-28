using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Hitmonchan Specie to store common natural stats of all Hitmonchans
	#region SpecieHitmonchan
	public class SpecieHitmonchan : PokemonSpecie
	{
#nullable enable
		private static SpecieHitmonchan? _instance = null;
#nullable restore
        public static SpecieHitmonchan Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHitmonchan();
                }
                return _instance;
            }
        }

		#region SpecieHitmonchan Builder
		public SpecieHitmonchan() : base(
			"Hitmonchan",
			50, // HPs
			105, 79, // Attack & Defense
			35, 110, // Special Attack & Defense
			76			
		) {}
		#endregion
	}
	#endregion

	//Hitmonchan Pokemon Class
	#region Hitmonchan
	public class Hitmonchan : Pokemon
	{
		#region Hitmonchan Builders
		/// <summary>
		/// Hitmonchan Builder waiting for a Nickname & a Level
		/// </summary>
		public Hitmonchan(string nickname, int level)
		: base(
				107,
				SpecieHitmonchan.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hitmonchan Builder only waiting for a Level
		/// </summary>
		public Hitmonchan(int level)
		: base(
				107,
				SpecieHitmonchan.Instance, // Pokemon Specie
				"Hitmonchan", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hitmonchan Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Hitmonchan() : base(
			107,
			SpecieHitmonchan.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		#endregion
	}
	#endregion
}