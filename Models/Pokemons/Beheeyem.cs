using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Beheeyem Specie to store common natural stats of all Beheeyems
	#region SpecieBeheeyem
	public class SpecieBeheeyem : PokemonSpecie
	{
#nullable enable
		private static SpecieBeheeyem? _instance = null;
#nullable restore
        public static SpecieBeheeyem Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBeheeyem();
                }
                return _instance;
            }
        }

		#region SpecieBeheeyem Builder
		public SpecieBeheeyem() : base(
			"Beheeyem",
			1.0,
			34.5,
			75, // HPs
			75, 75, // Attack & Defense
			125, 95, // Special Attack & Defense
			40		
		)
		{}
		#endregion
	}
	#endregion

	//Beheeyem Pokemon Class
	#region Beheeyem
	public class Beheeyem : Pokemon
	{
		#region Beheeyem Builders
		/// <summary>
		/// Beheeyem Builder waiting for a Nickname & a Level
		/// </summary>
		public Beheeyem(string nickname, int level)
		: base(
				606,
				SpecieBeheeyem.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beheeyem Builder only waiting for a Level
		/// </summary>
		public Beheeyem(int level)
		: base(
				606,
				SpecieBeheeyem.Instance, // Pokemon Specie
				"Beheeyem", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beheeyem Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Beheeyem() : base(
			606,
			SpecieBeheeyem.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}