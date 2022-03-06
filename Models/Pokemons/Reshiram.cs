using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Reshiram Specie to store common natural stats of all Reshirams
	#region SpecieReshiram
	public class SpecieReshiram : PokemonSpecie
	{
#nullable enable
		private static SpecieReshiram? _instance = null;
#nullable restore
        public static SpecieReshiram Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieReshiram();
                }
                return _instance;
            }
        }

		#region SpecieReshiram Builder
		public SpecieReshiram() : base(
			"Reshiram",
			100, // HPs
			120, 100, // Attack & Defense
			150, 120, // Special Attack & Defense
			90		
		)
		{
			this._height = 32;
			this._weight = 3300;
		}
		#endregion
	}
	#endregion

	//Reshiram Pokemon Class
	#region Reshiram
	public class Reshiram : Pokemon
	{
		#region Reshiram Builders
		/// <summary>
		/// Reshiram Builder waiting for a Nickname & a Level
		/// </summary>
		public Reshiram(string nickname, int level)
		: base(
				643,
				SpecieReshiram.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Reshiram Builder only waiting for a Level
		/// </summary>
		public Reshiram(int level)
		: base(
				643,
				SpecieReshiram.Instance, // Pokemon Specie
				"Reshiram", level,
				Dragon.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Reshiram Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Reshiram() : base(
			643,
			SpecieReshiram.Instance, // Pokemon Specie
			Dragon.Instance, Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}