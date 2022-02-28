using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Leavanny Specie to store common natural stats of all Leavannys
	#region SpecieLeavanny
	public class SpecieLeavanny : PokemonSpecie
	{
#nullable enable
		private static SpecieLeavanny? _instance = null;
#nullable restore
        public static SpecieLeavanny Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLeavanny();
                }
                return _instance;
            }
        }

		#region SpecieLeavanny Builder
		public SpecieLeavanny() : base(
			"Leavanny",
			75, // HPs
			103, 80, // Attack & Defense
			70, 80, // Special Attack & Defense
			92			
		) {}
		#endregion
	}
	#endregion

	//Leavanny Pokemon Class
	#region Leavanny
	public class Leavanny : Pokemon
	{
		#region Leavanny Builders
		/// <summary>
		/// Leavanny Builder waiting for a Nickname & a Level
		/// </summary>
		public Leavanny(string nickname, int level)
		: base(
				542,
				SpecieLeavanny.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Leavanny Builder only waiting for a Level
		/// </summary>
		public Leavanny(int level)
		: base(
				542,
				SpecieLeavanny.Instance, // Pokemon Specie
				"Leavanny", level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Leavanny Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Leavanny() : base(
			542,
			SpecieLeavanny.Instance, // Pokemon Specie
			Bug.Instance, Grass.Instance			
		) {}
		#endregion
	}
	#endregion
}