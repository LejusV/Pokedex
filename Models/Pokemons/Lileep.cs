using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lileep Specie to store common natural stats of all Lileeps
	#region SpecieLileep
	public class SpecieLileep : PokemonSpecie
	{
#nullable enable
		private static SpecieLileep? _instance = null;
#nullable restore
        public static SpecieLileep Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLileep();
                }
                return _instance;
            }
        }

		#region SpecieLileep Builder
		public SpecieLileep() : base(
			"Lileep",
			66, // HPs
			41, 77, // Attack & Defense
			61, 87, // Special Attack & Defense
			23			
		) {}
		#endregion
	}
	#endregion

	//Lileep Pokemon Class
	#region Lileep
	public class Lileep : Pokemon
	{
		#region Lileep Builders
		/// <summary>
		/// Lileep Builder waiting for a Nickname & a Level
		/// </summary>
		public Lileep(string nickname, int level)
		: base(
				345,
				SpecieLileep.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lileep Builder only waiting for a Level
		/// </summary>
		public Lileep(int level)
		: base(
				345,
				SpecieLileep.Instance, // Pokemon Specie
				"Lileep", level,
				Rock.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lileep Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Lileep() : base(
			345,
			SpecieLileep.Instance, // Pokemon Specie
			Rock.Instance, Grass.Instance			
		) {}
		#endregion
	}
	#endregion
}