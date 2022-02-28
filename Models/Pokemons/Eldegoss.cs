using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Eldegoss Specie to store common natural stats of all Eldegosss
	#region SpecieEldegoss
	public class SpecieEldegoss : PokemonSpecie
	{
#nullable enable
		private static SpecieEldegoss? _instance = null;
#nullable restore
        public static SpecieEldegoss Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEldegoss();
                }
                return _instance;
            }
        }

		#region SpecieEldegoss Builder
		public SpecieEldegoss() : base(
			"Eldegoss",
			60, // HPs
			50, 90, // Attack & Defense
			80, 120, // Special Attack & Defense
			60			
		) {}
		#endregion
	}
	#endregion

	//Eldegoss Pokemon Class
	#region Eldegoss
	public class Eldegoss : Pokemon
	{
		#region Eldegoss Builders
		/// <summary>
		/// Eldegoss Builder waiting for a Nickname & a Level
		/// </summary>
		public Eldegoss(string nickname, int level)
		: base(
				830,
				SpecieEldegoss.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eldegoss Builder only waiting for a Level
		/// </summary>
		public Eldegoss(int level)
		: base(
				830,
				SpecieEldegoss.Instance, // Pokemon Specie
				"Eldegoss", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eldegoss Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Eldegoss() : base(
			830,
			SpecieEldegoss.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		#endregion
	}
	#endregion
}