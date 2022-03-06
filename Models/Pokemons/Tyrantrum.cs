using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Tyrantrum Specie to store common natural stats of all Tyrantrums
	#region SpecieTyrantrum
	public class SpecieTyrantrum : PokemonSpecie
	{
#nullable enable
		private static SpecieTyrantrum? _instance = null;
#nullable restore
        public static SpecieTyrantrum Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTyrantrum();
                }
                return _instance;
            }
        }

		#region SpecieTyrantrum Builder
		public SpecieTyrantrum() : base(
			"Tyrantrum",
			82, // HPs
			121, 119, // Attack & Defense
			69, 59, // Special Attack & Defense
			71		
		)
		{
			this._height = 25;
			this._weight = 2700;
		}
		#endregion
	}
	#endregion

	//Tyrantrum Pokemon Class
	#region Tyrantrum
	public class Tyrantrum : Pokemon
	{
		#region Tyrantrum Builders
		/// <summary>
		/// Tyrantrum Builder waiting for a Nickname & a Level
		/// </summary>
		public Tyrantrum(string nickname, int level)
		: base(
				697,
				SpecieTyrantrum.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tyrantrum Builder only waiting for a Level
		/// </summary>
		public Tyrantrum(int level)
		: base(
				697,
				SpecieTyrantrum.Instance, // Pokemon Specie
				"Tyrantrum", level,
				Rock.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tyrantrum Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Tyrantrum() : base(
			697,
			SpecieTyrantrum.Instance, // Pokemon Specie
			Rock.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}