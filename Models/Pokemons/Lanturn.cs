using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Lanturn Specie to store common natural stats of all Lanturns
	#region SpecieLanturn
	public class SpecieLanturn : PokemonSpecie
	{
#nullable enable
		private static SpecieLanturn? _instance = null;
#nullable restore
        public static SpecieLanturn Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLanturn();
                }
                return _instance;
            }
        }

		#region SpecieLanturn Builder
		public SpecieLanturn() : base(
			"Lanturn",
			125, // HPs
			58, 58, // Attack & Defense
			76, 76, // Special Attack & Defense
			67		
		)
		{
			this._height = 12;
			this._weight = 225;
		}
		#endregion
	}
	#endregion

	//Lanturn Pokemon Class
	#region Lanturn
	public class Lanturn : Pokemon
	{
		#region Lanturn Builders
		/// <summary>
		/// Lanturn Builder waiting for a Nickname & a Level
		/// </summary>
		public Lanturn(string nickname, int level)
		: base(
				171,
				SpecieLanturn.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lanturn Builder only waiting for a Level
		/// </summary>
		public Lanturn(int level)
		: base(
				171,
				SpecieLanturn.Instance, // Pokemon Specie
				"Lanturn", level,
				Water.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lanturn Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Lanturn() : base(
			171,
			SpecieLanturn.Instance, // Pokemon Specie
			Water.Instance, Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}