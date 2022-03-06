using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Malamar Specie to store common natural stats of all Malamars
	#region SpecieMalamar
	public class SpecieMalamar : PokemonSpecie
	{
#nullable enable
		private static SpecieMalamar? _instance = null;
#nullable restore
        public static SpecieMalamar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMalamar();
                }
                return _instance;
            }
        }

		#region SpecieMalamar Builder
		public SpecieMalamar() : base(
			"Malamar",
			1.5,
			47.0,
			86, // HPs
			92, 88, // Attack & Defense
			68, 75, // Special Attack & Defense
			73		
		)
		{}
		#endregion
	}
	#endregion

	//Malamar Pokemon Class
	#region Malamar
	public class Malamar : Pokemon
	{
		#region Malamar Builders
		/// <summary>
		/// Malamar Builder waiting for a Nickname & a Level
		/// </summary>
		public Malamar(string nickname, int level)
		: base(
				687,
				SpecieMalamar.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Malamar Builder only waiting for a Level
		/// </summary>
		public Malamar(int level)
		: base(
				687,
				SpecieMalamar.Instance, // Pokemon Specie
				"Malamar", level,
				Dark.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Malamar Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Malamar() : base(
			687,
			SpecieMalamar.Instance, // Pokemon Specie
			Dark.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}