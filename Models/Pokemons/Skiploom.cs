using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Skiploom Specie to store common natural stats of all Skiplooms
	#region SpecieSkiploom
	public class SpecieSkiploom : PokemonSpecie
	{
#nullable enable
		private static SpecieSkiploom? _instance = null;
#nullable restore
        public static SpecieSkiploom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSkiploom();
                }
                return _instance;
            }
        }

		#region SpecieSkiploom Builder
		public SpecieSkiploom() : base(
			"Skiploom",
			55, // HPs
			45, 50, // Attack & Defense
			45, 65, // Special Attack & Defense
			80			
		) {}
		#endregion
	}
	#endregion

	//Skiploom Pokemon Class
	#region Skiploom
	public class Skiploom : Pokemon
	{
		#region Skiploom Builders
		/// <summary>
		/// Skiploom Builder waiting for a Nickname & a Level
		/// </summary>
		public Skiploom(string nickname, int level)
		: base(
				188,
				SpecieSkiploom.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skiploom Builder only waiting for a Level
		/// </summary>
		public Skiploom(int level)
		: base(
				188,
				SpecieSkiploom.Instance, // Pokemon Specie
				"Skiploom", level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skiploom Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Skiploom() : base(
			188,
			SpecieSkiploom.Instance, // Pokemon Specie
			Grass.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}