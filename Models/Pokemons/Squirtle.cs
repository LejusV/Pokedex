using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Squirtle Specie to store common natural stats of all Squirtles
	#region SpecieSquirtle
	public class SpecieSquirtle : PokemonSpecie
	{
#nullable enable
		private static SpecieSquirtle? _instance = null;
#nullable restore
        public static SpecieSquirtle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSquirtle();
                }
                return _instance;
            }
        }

		#region SpecieSquirtle Builder
		public SpecieSquirtle() : base(
			"Squirtle",
			0.5,
			9.0,
			44, // HPs
			48, 65, // Attack & Defense
			50, 64, // Special Attack & Defense
			43		
		)
		{}
		#endregion
	}
	#endregion

	//Squirtle Pokemon Class
	#region Squirtle
	public class Squirtle : Pokemon
	{
		#region Squirtle Builders
		/// <summary>
		/// Squirtle Builder waiting for a Nickname & a Level
		/// </summary>
		public Squirtle(string nickname, int level)
		: base(
				7,
				SpecieSquirtle.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Squirtle Builder only waiting for a Level
		/// </summary>
		public Squirtle(int level)
		: base(
				7,
				SpecieSquirtle.Instance, // Pokemon Specie
				"Squirtle", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Squirtle Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Squirtle() : base(
			7,
			SpecieSquirtle.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}