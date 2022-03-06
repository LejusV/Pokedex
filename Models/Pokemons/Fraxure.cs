using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Fraxure Specie to store common natural stats of all Fraxures
	#region SpecieFraxure
	public class SpecieFraxure : PokemonSpecie
	{
#nullable enable
		private static SpecieFraxure? _instance = null;
#nullable restore
        public static SpecieFraxure Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFraxure();
                }
                return _instance;
            }
        }

		#region SpecieFraxure Builder
		public SpecieFraxure() : base(
			"Fraxure",
			66, // HPs
			117, 70, // Attack & Defense
			40, 50, // Special Attack & Defense
			67		
		)
		{
			this._height = 10;
			this._weight = 360;
		}
		#endregion
	}
	#endregion

	//Fraxure Pokemon Class
	#region Fraxure
	public class Fraxure : Pokemon
	{
		#region Fraxure Builders
		/// <summary>
		/// Fraxure Builder waiting for a Nickname & a Level
		/// </summary>
		public Fraxure(string nickname, int level)
		: base(
				611,
				SpecieFraxure.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fraxure Builder only waiting for a Level
		/// </summary>
		public Fraxure(int level)
		: base(
				611,
				SpecieFraxure.Instance, // Pokemon Specie
				"Fraxure", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fraxure Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Fraxure() : base(
			611,
			SpecieFraxure.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}