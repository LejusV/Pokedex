using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Nidorino Specie to store common natural stats of all Nidorinos
	#region SpecieNidorino
	public class SpecieNidorino : PokemonSpecie
	{
#nullable enable
		private static SpecieNidorino? _instance = null;
#nullable restore
        public static SpecieNidorino Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNidorino();
                }
                return _instance;
            }
        }

		#region SpecieNidorino Builder
		public SpecieNidorino() : base(
			"Nidorino",
			61, // HPs
			72, 57, // Attack & Defense
			55, 55, // Special Attack & Defense
			65		
		)
		{
			this._height = 9;
			this._weight = 195;
		}
		#endregion
	}
	#endregion

	//Nidorino Pokemon Class
	#region Nidorino
	public class Nidorino : Pokemon
	{
		#region Nidorino Builders
		/// <summary>
		/// Nidorino Builder waiting for a Nickname & a Level
		/// </summary>
		public Nidorino(string nickname, int level)
		: base(
				33,
				SpecieNidorino.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidorino Builder only waiting for a Level
		/// </summary>
		public Nidorino(int level)
		: base(
				33,
				SpecieNidorino.Instance, // Pokemon Specie
				"Nidorino", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidorino Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Nidorino() : base(
			33,
			SpecieNidorino.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}