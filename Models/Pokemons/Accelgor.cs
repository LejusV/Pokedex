using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Accelgor Specie to store common natural stats of all Accelgors
	#region SpecieAccelgor
	public class SpecieAccelgor : PokemonSpecie
	{
#nullable enable
		private static SpecieAccelgor? _instance = null;
#nullable restore
        public static SpecieAccelgor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAccelgor();
                }
                return _instance;
            }
        }

		#region SpecieAccelgor Builder
		public SpecieAccelgor() : base(
			"Accelgor",
			80, // HPs
			70, 40, // Attack & Defense
			100, 60, // Special Attack & Defense
			145			
		) {}
		#endregion
	}
	#endregion

	//Accelgor Pokemon Class
	#region Accelgor
	public class Accelgor : Pokemon
	{
		#region Accelgor Builders
		/// <summary>
		/// Accelgor Builder waiting for a Nickname & a Level
		/// </summary>
		public Accelgor(string nickname, int level)
		: base(
				617,
				SpecieAccelgor.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Accelgor Builder only waiting for a Level
		/// </summary>
		public Accelgor(int level)
		: base(
				617,
				SpecieAccelgor.Instance, // Pokemon Specie
				"Accelgor", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Accelgor Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Accelgor() : base(
			617,
			SpecieAccelgor.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
		#endregion
	}
	#endregion
}