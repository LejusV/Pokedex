using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Ivysaur Specie to store common natural stats of all Ivysaurs
	#region SpecieIvysaur
	public class SpecieIvysaur : PokemonSpecie
	{
#nullable enable
		private static SpecieIvysaur? _instance = null;
#nullable restore
        public static SpecieIvysaur Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieIvysaur();
                }
                return _instance;
            }
        }

		#region SpecieIvysaur Builder
		public SpecieIvysaur() : base(
			"Ivysaur",
			1.0,
			13.0,
			60, // HPs
			62, 63, // Attack & Defense
			80, 80, // Special Attack & Defense
			60		
		)
		{}
		#endregion
	}
	#endregion

	//Ivysaur Pokemon Class
	#region Ivysaur
	public class Ivysaur : Pokemon
	{
		#region Ivysaur Builders
		/// <summary>
		/// Ivysaur Builder waiting for a Nickname & a Level
		/// </summary>
		public Ivysaur(string nickname, int level)
		: base(
				2,
				SpecieIvysaur.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ivysaur Builder only waiting for a Level
		/// </summary>
		public Ivysaur(int level)
		: base(
				2,
				SpecieIvysaur.Instance, // Pokemon Specie
				"Ivysaur", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ivysaur Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Ivysaur() : base(
			2,
			SpecieIvysaur.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}