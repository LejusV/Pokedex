using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Ledian Specie to store common natural stats of all Ledians
	#region SpecieLedian
	public class SpecieLedian : PokemonSpecie
	{
#nullable enable
		private static SpecieLedian? _instance = null;
#nullable restore
        public static SpecieLedian Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLedian();
                }
                return _instance;
            }
        }

		#region SpecieLedian Builder
		public SpecieLedian() : base(
			"Ledian",
			1.4,
			35.6,
			55, // HPs
			35, 50, // Attack & Defense
			55, 110, // Special Attack & Defense
			85		
		)
		{}
		#endregion
	}
	#endregion

	//Ledian Pokemon Class
	#region Ledian
	public class Ledian : Pokemon
	{
		#region Ledian Builders
		/// <summary>
		/// Ledian Builder waiting for a Nickname & a Level
		/// </summary>
		public Ledian(string nickname, int level)
		: base(
				166,
				SpecieLedian.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ledian Builder only waiting for a Level
		/// </summary>
		public Ledian(int level)
		: base(
				166,
				SpecieLedian.Instance, // Pokemon Specie
				"Ledian", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ledian Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Ledian() : base(
			166,
			SpecieLedian.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}