using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Ledyba Specie to store common natural stats of all Ledybas
	#region SpecieLedyba
	public class SpecieLedyba : PokemonSpecie
	{
#nullable enable
		private static SpecieLedyba? _instance = null;
#nullable restore
        public static SpecieLedyba Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLedyba();
                }
                return _instance;
            }
        }

		#region SpecieLedyba Builder
		public SpecieLedyba() : base(
			"Ledyba",
			1.0,
			10.8,
			40, // HPs
			20, 30, // Attack & Defense
			40, 80, // Special Attack & Defense
			55		
		)
		{}
		#endregion
	}
	#endregion

	//Ledyba Pokemon Class
	#region Ledyba
	public class Ledyba : Pokemon
	{
		#region Ledyba Builders
		/// <summary>
		/// Ledyba Builder waiting for a Nickname & a Level
		/// </summary>
		public Ledyba(string nickname, int level)
		: base(
				165,
				SpecieLedyba.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ledyba Builder only waiting for a Level
		/// </summary>
		public Ledyba(int level)
		: base(
				165,
				SpecieLedyba.Instance, // Pokemon Specie
				"Ledyba", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ledyba Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Ledyba() : base(
			165,
			SpecieLedyba.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}