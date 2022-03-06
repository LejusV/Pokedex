using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Corviknight Specie to store common natural stats of all Corviknights
	#region SpecieCorviknight
	public class SpecieCorviknight : PokemonSpecie
	{
#nullable enable
		private static SpecieCorviknight? _instance = null;
#nullable restore
        public static SpecieCorviknight Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCorviknight();
                }
                return _instance;
            }
        }

		#region SpecieCorviknight Builder
		public SpecieCorviknight() : base(
			"Corviknight",
			2.2,
			75.0,
			98, // HPs
			87, 105, // Attack & Defense
			53, 85, // Special Attack & Defense
			67		
		)
		{}
		#endregion
	}
	#endregion

	//Corviknight Pokemon Class
	#region Corviknight
	public class Corviknight : Pokemon
	{
		#region Corviknight Builders
		/// <summary>
		/// Corviknight Builder waiting for a Nickname & a Level
		/// </summary>
		public Corviknight(string nickname, int level)
		: base(
				823,
				SpecieCorviknight.Instance, // Pokemon Specie
				nickname, level,
				Flying.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Corviknight Builder only waiting for a Level
		/// </summary>
		public Corviknight(int level)
		: base(
				823,
				SpecieCorviknight.Instance, // Pokemon Specie
				"Corviknight", level,
				Flying.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Corviknight Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Corviknight() : base(
			823,
			SpecieCorviknight.Instance, // Pokemon Specie
			Flying.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}