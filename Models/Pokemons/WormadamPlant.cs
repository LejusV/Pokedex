using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Wormadam-Plant Specie to store common natural stats of all Wormadam-Plants
	#region SpecieWormadam-Plant
	public class SpecieWormadamPlant : PokemonSpecie
	{
#nullable enable
		private static SpecieWormadamPlant? _instance = null;
#nullable restore
        public static SpecieWormadamPlant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWormadamPlant();
                }
                return _instance;
            }
        }

		#region SpecieWormadam-Plant Builder
		public SpecieWormadamPlant() : base(
			"Wormadam-Plant",
			60, // HPs
			59, 85, // Attack & Defense
			79, 105, // Special Attack & Defense
			36		
		)
		{
			this._height = 5;
			this._weight = 65;
		}
		#endregion
	}
	#endregion

	//Wormadam-Plant Pokemon Class
	#region Wormadam-Plant
	public class WormadamPlant : Pokemon
	{
		#region Wormadam-Plant Builders
		/// <summary>
		/// Wormadam-Plant Builder waiting for a Nickname & a Level
		/// </summary>
		public WormadamPlant(string nickname, int level)
		: base(
				413,
				SpecieWormadamPlant.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wormadam-Plant Builder only waiting for a Level
		/// </summary>
		public WormadamPlant(int level)
		: base(
				413,
				SpecieWormadamPlant.Instance, // Pokemon Specie
				"Wormadam-Plant", level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wormadam-Plant Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public WormadamPlant() : base(
			413,
			SpecieWormadamPlant.Instance, // Pokemon Specie
			Bug.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}