using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Roserade Specie to store common natural stats of all Roserades
	#region SpecieRoserade
	public class SpecieRoserade : PokemonSpecie
	{
#nullable enable
		private static SpecieRoserade? _instance = null;
#nullable restore
        public static SpecieRoserade Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRoserade();
                }
                return _instance;
            }
        }

		#region SpecieRoserade Builder
		public SpecieRoserade() : base(
			"Roserade",
			60, // HPs
			70, 65, // Attack & Defense
			125, 105, // Special Attack & Defense
			90		
		)
		{
			this._height = 9;
			this._weight = 145;
		}
		#endregion
	}
	#endregion

	//Roserade Pokemon Class
	#region Roserade
	public class Roserade : Pokemon
	{
		#region Roserade Builders
		/// <summary>
		/// Roserade Builder waiting for a Nickname & a Level
		/// </summary>
		public Roserade(string nickname, int level)
		: base(
				407,
				SpecieRoserade.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Roserade Builder only waiting for a Level
		/// </summary>
		public Roserade(int level)
		: base(
				407,
				SpecieRoserade.Instance, // Pokemon Specie
				"Roserade", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Roserade Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Roserade() : base(
			407,
			SpecieRoserade.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}