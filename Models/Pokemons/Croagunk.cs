using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Croagunk Specie to store common natural stats of all Croagunks
	#region SpecieCroagunk
	public class SpecieCroagunk : PokemonSpecie
	{
#nullable enable
		private static SpecieCroagunk? _instance = null;
#nullable restore
        public static SpecieCroagunk Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCroagunk();
                }
                return _instance;
            }
        }

		#region SpecieCroagunk Builder
		public SpecieCroagunk() : base(
			"Croagunk",
			48, // HPs
			61, 40, // Attack & Defense
			61, 40, // Special Attack & Defense
			50			
		) {}
		#endregion
	}
	#endregion

	//Croagunk Pokemon Class
	#region Croagunk
	public class Croagunk : Pokemon
	{
		#region Croagunk Builders
		/// <summary>
		/// Croagunk Builder waiting for a Nickname & a Level
		/// </summary>
		public Croagunk(string nickname, int level)
		: base(
				453,
				SpecieCroagunk.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Croagunk Builder only waiting for a Level
		/// </summary>
		public Croagunk(int level)
		: base(
				453,
				SpecieCroagunk.Instance, // Pokemon Specie
				"Croagunk", level,
				Poison.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Croagunk Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Croagunk() : base(
			453,
			SpecieCroagunk.Instance, // Pokemon Specie
			Poison.Instance, Fighting.Instance			
		) {}
		#endregion
	}
	#endregion
}