using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Venusaur Specie to store common natural stats of all Venusaurs
	#region SpecieVenusaur
	public class SpecieVenusaur : PokemonSpecie
	{
#nullable enable
		private static SpecieVenusaur? _instance = null;
#nullable restore
        public static SpecieVenusaur Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVenusaur();
                }
                return _instance;
            }
        }

		#region SpecieVenusaur Builder
		public SpecieVenusaur() : base(
			"Venusaur",
			80, // HPs
			82, 83, // Attack & Defense
			100, 100, // Special Attack & Defense
			80			
		) {}
		#endregion
	}
	#endregion

	//Venusaur Pokemon Class
	#region Venusaur
	public class Venusaur : Pokemon
	{
		#region Venusaur Builders
		/// <summary>
		/// Venusaur Builder waiting for a Nickname & a Level
		/// </summary>
		public Venusaur(string nickname, int level)
		: base(
				3,
				SpecieVenusaur.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Venusaur Builder only waiting for a Level
		/// </summary>
		public Venusaur(int level)
		: base(
				3,
				SpecieVenusaur.Instance, // Pokemon Specie
				"Venusaur", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Venusaur Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Venusaur() : base(
			3,
			SpecieVenusaur.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
		#endregion
	}
	#endregion
}