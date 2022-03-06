using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Escavalier Specie to store common natural stats of all Escavaliers
	#region SpecieEscavalier
	public class SpecieEscavalier : PokemonSpecie
	{
#nullable enable
		private static SpecieEscavalier? _instance = null;
#nullable restore
        public static SpecieEscavalier Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEscavalier();
                }
                return _instance;
            }
        }

		#region SpecieEscavalier Builder
		public SpecieEscavalier() : base(
			"Escavalier",
			1.0,
			33.0,
			70, // HPs
			135, 105, // Attack & Defense
			60, 105, // Special Attack & Defense
			20		
		)
		{}
		#endregion
	}
	#endregion

	//Escavalier Pokemon Class
	#region Escavalier
	public class Escavalier : Pokemon
	{
		#region Escavalier Builders
		/// <summary>
		/// Escavalier Builder waiting for a Nickname & a Level
		/// </summary>
		public Escavalier(string nickname, int level)
		: base(
				589,
				SpecieEscavalier.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Escavalier Builder only waiting for a Level
		/// </summary>
		public Escavalier(int level)
		: base(
				589,
				SpecieEscavalier.Instance, // Pokemon Specie
				"Escavalier", level,
				Bug.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Escavalier Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Escavalier() : base(
			589,
			SpecieEscavalier.Instance, // Pokemon Specie
			Bug.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}