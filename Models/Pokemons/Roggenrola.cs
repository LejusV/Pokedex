using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Roggenrola Specie to store common natural stats of all Roggenrolas
	#region SpecieRoggenrola
	public class SpecieRoggenrola : PokemonSpecie
	{
#nullable enable
		private static SpecieRoggenrola? _instance = null;
#nullable restore
        public static SpecieRoggenrola Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRoggenrola();
                }
                return _instance;
            }
        }

		#region SpecieRoggenrola Builder
		public SpecieRoggenrola() : base(
			"Roggenrola",
			55, // HPs
			75, 85, // Attack & Defense
			25, 25, // Special Attack & Defense
			15		
		)
		{
			this._height = 4;
			this._weight = 180;
		}
		#endregion
	}
	#endregion

	//Roggenrola Pokemon Class
	#region Roggenrola
	public class Roggenrola : Pokemon
	{
		#region Roggenrola Builders
		/// <summary>
		/// Roggenrola Builder waiting for a Nickname & a Level
		/// </summary>
		public Roggenrola(string nickname, int level)
		: base(
				524,
				SpecieRoggenrola.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Roggenrola Builder only waiting for a Level
		/// </summary>
		public Roggenrola(int level)
		: base(
				524,
				SpecieRoggenrola.Instance, // Pokemon Specie
				"Roggenrola", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Roggenrola Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Roggenrola() : base(
			524,
			SpecieRoggenrola.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}