using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Venipede Specie to store common natural stats of all Venipedes
	#region SpecieVenipede
	public class SpecieVenipede : PokemonSpecie
	{
#nullable enable
		private static SpecieVenipede? _instance = null;
#nullable restore
        public static SpecieVenipede Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVenipede();
                }
                return _instance;
            }
        }

		#region SpecieVenipede Builder
		public SpecieVenipede() : base(
			"Venipede",
			30, // HPs
			45, 59, // Attack & Defense
			30, 39, // Special Attack & Defense
			57			
		) {}
		#endregion
	}
	#endregion

	//Venipede Pokemon Class
	#region Venipede
	public class Venipede : Pokemon
	{
		#region Venipede Builders
		/// <summary>
		/// Venipede Builder waiting for a Nickname & a Level
		/// </summary>
		public Venipede(string nickname, int level)
		: base(
				543,
				SpecieVenipede.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Venipede Builder only waiting for a Level
		/// </summary>
		public Venipede(int level)
		: base(
				543,
				SpecieVenipede.Instance, // Pokemon Specie
				"Venipede", level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Venipede Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Venipede() : base(
			543,
			SpecieVenipede.Instance, // Pokemon Specie
			Bug.Instance, Poison.Instance			
		) {}
		#endregion
	}
	#endregion
}