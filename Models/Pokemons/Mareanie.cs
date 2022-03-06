using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Mareanie Specie to store common natural stats of all Mareanies
	#region SpecieMareanie
	public class SpecieMareanie : PokemonSpecie
	{
#nullable enable
		private static SpecieMareanie? _instance = null;
#nullable restore
        public static SpecieMareanie Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMareanie();
                }
                return _instance;
            }
        }

		#region SpecieMareanie Builder
		public SpecieMareanie() : base(
			"Mareanie",
			0.4,
			8.0,
			50, // HPs
			53, 62, // Attack & Defense
			43, 52, // Special Attack & Defense
			45		
		)
		{}
		#endregion
	}
	#endregion

	//Mareanie Pokemon Class
	#region Mareanie
	public class Mareanie : Pokemon
	{
		#region Mareanie Builders
		/// <summary>
		/// Mareanie Builder waiting for a Nickname & a Level
		/// </summary>
		public Mareanie(string nickname, int level)
		: base(
				747,
				SpecieMareanie.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mareanie Builder only waiting for a Level
		/// </summary>
		public Mareanie(int level)
		: base(
				747,
				SpecieMareanie.Instance, // Pokemon Specie
				"Mareanie", level,
				Poison.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mareanie Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Mareanie() : base(
			747,
			SpecieMareanie.Instance, // Pokemon Specie
			Poison.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}