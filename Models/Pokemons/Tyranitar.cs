using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Tyranitar Specie to store common natural stats of all Tyranitars
	#region SpecieTyranitar
	public class SpecieTyranitar : PokemonSpecie
	{
#nullable enable
		private static SpecieTyranitar? _instance = null;
#nullable restore
        public static SpecieTyranitar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTyranitar();
                }
                return _instance;
            }
        }

		#region SpecieTyranitar Builder
		public SpecieTyranitar() : base(
			"Tyranitar",
			2.0,
			202.0,
			100, // HPs
			134, 110, // Attack & Defense
			95, 100, // Special Attack & Defense
			61		
		)
		{}
		#endregion
	}
	#endregion

	//Tyranitar Pokemon Class
	#region Tyranitar
	public class Tyranitar : Pokemon
	{
		#region Tyranitar Builders
		/// <summary>
		/// Tyranitar Builder waiting for a Nickname & a Level
		/// </summary>
		public Tyranitar(string nickname, int level)
		: base(
				248,
				SpecieTyranitar.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tyranitar Builder only waiting for a Level
		/// </summary>
		public Tyranitar(int level)
		: base(
				248,
				SpecieTyranitar.Instance, // Pokemon Specie
				"Tyranitar", level,
				Rock.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tyranitar Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Tyranitar() : base(
			248,
			SpecieTyranitar.Instance, // Pokemon Specie
			Rock.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}