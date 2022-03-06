using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Deino Specie to store common natural stats of all Deinos
	#region SpecieDeino
	public class SpecieDeino : PokemonSpecie
	{
#nullable enable
		private static SpecieDeino? _instance = null;
#nullable restore
        public static SpecieDeino Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDeino();
                }
                return _instance;
            }
        }

		#region SpecieDeino Builder
		public SpecieDeino() : base(
			"Deino",
			0.8,
			17.3,
			52, // HPs
			65, 50, // Attack & Defense
			45, 50, // Special Attack & Defense
			38		
		)
		{}
		#endregion
	}
	#endregion

	//Deino Pokemon Class
	#region Deino
	public class Deino : Pokemon
	{
		#region Deino Builders
		/// <summary>
		/// Deino Builder waiting for a Nickname & a Level
		/// </summary>
		public Deino(string nickname, int level)
		: base(
				633,
				SpecieDeino.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Deino Builder only waiting for a Level
		/// </summary>
		public Deino(int level)
		: base(
				633,
				SpecieDeino.Instance, // Pokemon Specie
				"Deino", level,
				Dark.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Deino Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Deino() : base(
			633,
			SpecieDeino.Instance, // Pokemon Specie
			Dark.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}