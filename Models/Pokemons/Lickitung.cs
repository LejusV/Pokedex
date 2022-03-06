using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Lickitung Specie to store common natural stats of all Lickitungs
	#region SpecieLickitung
	public class SpecieLickitung : PokemonSpecie
	{
#nullable enable
		private static SpecieLickitung? _instance = null;
#nullable restore
        public static SpecieLickitung Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLickitung();
                }
                return _instance;
            }
        }

		#region SpecieLickitung Builder
		public SpecieLickitung() : base(
			"Lickitung",
			1.2,
			65.5,
			90, // HPs
			55, 75, // Attack & Defense
			60, 75, // Special Attack & Defense
			30		
		)
		{}
		#endregion
	}
	#endregion

	//Lickitung Pokemon Class
	#region Lickitung
	public class Lickitung : Pokemon
	{
		#region Lickitung Builders
		/// <summary>
		/// Lickitung Builder waiting for a Nickname & a Level
		/// </summary>
		public Lickitung(string nickname, int level)
		: base(
				108,
				SpecieLickitung.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lickitung Builder only waiting for a Level
		/// </summary>
		public Lickitung(int level)
		: base(
				108,
				SpecieLickitung.Instance, // Pokemon Specie
				"Lickitung", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lickitung Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Lickitung() : base(
			108,
			SpecieLickitung.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}