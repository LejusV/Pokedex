using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Panpour Specie to store common natural stats of all Panpours
	#region SpeciePanpour
	public class SpeciePanpour : PokemonSpecie
	{
#nullable enable
		private static SpeciePanpour? _instance = null;
#nullable restore
        public static SpeciePanpour Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePanpour();
                }
                return _instance;
            }
        }

		#region SpeciePanpour Builder
		public SpeciePanpour() : base(
			"Panpour",
			0.6,
			13.5,
			50, // HPs
			53, 48, // Attack & Defense
			53, 48, // Special Attack & Defense
			64		
		)
		{}
		#endregion
	}
	#endregion

	//Panpour Pokemon Class
	#region Panpour
	public class Panpour : Pokemon
	{
		#region Panpour Builders
		/// <summary>
		/// Panpour Builder waiting for a Nickname & a Level
		/// </summary>
		public Panpour(string nickname, int level)
		: base(
				515,
				SpeciePanpour.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Panpour Builder only waiting for a Level
		/// </summary>
		public Panpour(int level)
		: base(
				515,
				SpeciePanpour.Instance, // Pokemon Specie
				"Panpour", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Panpour Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Panpour() : base(
			515,
			SpeciePanpour.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}