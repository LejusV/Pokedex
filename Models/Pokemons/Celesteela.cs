using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Celesteela Specie to store common natural stats of all Celesteelas
	#region SpecieCelesteela
	public class SpecieCelesteela : PokemonSpecie
	{
#nullable enable
		private static SpecieCelesteela? _instance = null;
#nullable restore
        public static SpecieCelesteela Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCelesteela();
                }
                return _instance;
            }
        }

		#region SpecieCelesteela Builder
		public SpecieCelesteela() : base(
			"Celesteela",
			9.2,
			999.9,
			97, // HPs
			101, 103, // Attack & Defense
			107, 101, // Special Attack & Defense
			61		
		)
		{}
		#endregion
	}
	#endregion

	//Celesteela Pokemon Class
	#region Celesteela
	public class Celesteela : Pokemon
	{
		#region Celesteela Builders
		/// <summary>
		/// Celesteela Builder waiting for a Nickname & a Level
		/// </summary>
		public Celesteela(string nickname, int level)
		: base(
				797,
				SpecieCelesteela.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Celesteela Builder only waiting for a Level
		/// </summary>
		public Celesteela(int level)
		: base(
				797,
				SpecieCelesteela.Instance, // Pokemon Specie
				"Celesteela", level,
				Steel.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Celesteela Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Celesteela() : base(
			797,
			SpecieCelesteela.Instance, // Pokemon Specie
			Steel.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}