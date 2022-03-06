using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Floette Specie to store common natural stats of all Floettes
	#region SpecieFloette
	public class SpecieFloette : PokemonSpecie
	{
#nullable enable
		private static SpecieFloette? _instance = null;
#nullable restore
        public static SpecieFloette Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFloette();
                }
                return _instance;
            }
        }

		#region SpecieFloette Builder
		public SpecieFloette() : base(
			"Floette",
			54, // HPs
			45, 47, // Attack & Defense
			75, 98, // Special Attack & Defense
			52		
		)
		{
			this._height = 2;
			this._weight = 9;
		}
		#endregion
	}
	#endregion

	//Floette Pokemon Class
	#region Floette
	public class Floette : Pokemon
	{
		#region Floette Builders
		/// <summary>
		/// Floette Builder waiting for a Nickname & a Level
		/// </summary>
		public Floette(string nickname, int level)
		: base(
				670,
				SpecieFloette.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Floette Builder only waiting for a Level
		/// </summary>
		public Floette(int level)
		: base(
				670,
				SpecieFloette.Instance, // Pokemon Specie
				"Floette", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Floette Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Floette() : base(
			670,
			SpecieFloette.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}