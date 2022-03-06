using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Meowstic-Male Specie to store common natural stats of all Meowstic-Males
	#region SpecieMeowstic-Male
	public class SpecieMeowsticMale : PokemonSpecie
	{
#nullable enable
		private static SpecieMeowsticMale? _instance = null;
#nullable restore
        public static SpecieMeowsticMale Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMeowsticMale();
                }
                return _instance;
            }
        }

		#region SpecieMeowstic-Male Builder
		public SpecieMeowsticMale() : base(
			"Meowstic-Male",
			74, // HPs
			48, 76, // Attack & Defense
			83, 81, // Special Attack & Defense
			104		
		)
		{
			this._height = 6;
			this._weight = 85;
		}
		#endregion
	}
	#endregion

	//Meowstic-Male Pokemon Class
	#region Meowstic-Male
	public class MeowsticMale : Pokemon
	{
		#region Meowstic-Male Builders
		/// <summary>
		/// Meowstic-Male Builder waiting for a Nickname & a Level
		/// </summary>
		public MeowsticMale(string nickname, int level)
		: base(
				678,
				SpecieMeowsticMale.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meowstic-Male Builder only waiting for a Level
		/// </summary>
		public MeowsticMale(int level)
		: base(
				678,
				SpecieMeowsticMale.Instance, // Pokemon Specie
				"Meowstic-Male", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meowstic-Male Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public MeowsticMale() : base(
			678,
			SpecieMeowsticMale.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}