using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Rillaboom Specie to store common natural stats of all Rillabooms
	#region SpecieRillaboom
	public class SpecieRillaboom : PokemonSpecie
	{
#nullable enable
		private static SpecieRillaboom? _instance = null;
#nullable restore
        public static SpecieRillaboom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRillaboom();
                }
                return _instance;
            }
        }

		#region SpecieRillaboom Builder
		public SpecieRillaboom() : base(
			"Rillaboom",
			100, // HPs
			125, 90, // Attack & Defense
			60, 70, // Special Attack & Defense
			85			
		) {}
		#endregion
	}
	#endregion

	//Rillaboom Pokemon Class
	#region Rillaboom
	public class Rillaboom : Pokemon
	{
		#region Rillaboom Builders
		/// <summary>
		/// Rillaboom Builder waiting for a Nickname & a Level
		/// </summary>
		public Rillaboom(string nickname, int level)
		: base(
				812,
				SpecieRillaboom.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rillaboom Builder only waiting for a Level
		/// </summary>
		public Rillaboom(int level)
		: base(
				812,
				SpecieRillaboom.Instance, // Pokemon Specie
				"Rillaboom", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rillaboom Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Rillaboom() : base(
			812,
			SpecieRillaboom.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		#endregion
	}
	#endregion
}