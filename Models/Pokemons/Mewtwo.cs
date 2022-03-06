using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Mewtwo Specie to store common natural stats of all Mewtwos
	#region SpecieMewtwo
	public class SpecieMewtwo : PokemonSpecie
	{
#nullable enable
		private static SpecieMewtwo? _instance = null;
#nullable restore
        public static SpecieMewtwo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMewtwo();
                }
                return _instance;
            }
        }

		#region SpecieMewtwo Builder
		public SpecieMewtwo() : base(
			"Mewtwo",
			2.0,
			122.0,
			106, // HPs
			110, 90, // Attack & Defense
			154, 90, // Special Attack & Defense
			130		
		)
		{}
		#endregion
	}
	#endregion

	//Mewtwo Pokemon Class
	#region Mewtwo
	public class Mewtwo : Pokemon
	{
		#region Mewtwo Builders
		/// <summary>
		/// Mewtwo Builder waiting for a Nickname & a Level
		/// </summary>
		public Mewtwo(string nickname, int level)
		: base(
				150,
				SpecieMewtwo.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mewtwo Builder only waiting for a Level
		/// </summary>
		public Mewtwo(int level)
		: base(
				150,
				SpecieMewtwo.Instance, // Pokemon Specie
				"Mewtwo", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mewtwo Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Mewtwo() : base(
			150,
			SpecieMewtwo.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}