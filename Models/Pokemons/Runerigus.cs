using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Runerigus Specie to store common natural stats of all Runeriguss
	#region SpecieRunerigus
	public class SpecieRunerigus : PokemonSpecie
	{
#nullable enable
		private static SpecieRunerigus? _instance = null;
#nullable restore
        public static SpecieRunerigus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRunerigus();
                }
                return _instance;
            }
        }

		#region SpecieRunerigus Builder
		public SpecieRunerigus() : base(
			"Runerigus",
			58, // HPs
			95, 145, // Attack & Defense
			50, 105, // Special Attack & Defense
			30			
		) {}
		#endregion
	}
	#endregion

	//Runerigus Pokemon Class
	#region Runerigus
	public class Runerigus : Pokemon
	{
		#region Runerigus Builders
		/// <summary>
		/// Runerigus Builder waiting for a Nickname & a Level
		/// </summary>
		public Runerigus(string nickname, int level)
		: base(
				867,
				SpecieRunerigus.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Runerigus Builder only waiting for a Level
		/// </summary>
		public Runerigus(int level)
		: base(
				867,
				SpecieRunerigus.Instance, // Pokemon Specie
				"Runerigus", level,
				Ground.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Runerigus Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Runerigus() : base(
			867,
			SpecieRunerigus.Instance, // Pokemon Specie
			Ground.Instance, Ghost.Instance			
		) {}
		#endregion
	}
	#endregion
}