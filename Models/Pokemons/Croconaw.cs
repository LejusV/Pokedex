using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Croconaw Specie to store common natural stats of all Croconaws
	#region SpecieCroconaw
	public class SpecieCroconaw : PokemonSpecie
	{
#nullable enable
		private static SpecieCroconaw? _instance = null;
#nullable restore
        public static SpecieCroconaw Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCroconaw();
                }
                return _instance;
            }
        }

		#region SpecieCroconaw Builder
		public SpecieCroconaw() : base(
			"Croconaw",
			65, // HPs
			80, 80, // Attack & Defense
			59, 63, // Special Attack & Defense
			58			
		) {}
		#endregion
	}
	#endregion

	//Croconaw Pokemon Class
	#region Croconaw
	public class Croconaw : Pokemon
	{
		#region Croconaw Builders
		/// <summary>
		/// Croconaw Builder waiting for a Nickname & a Level
		/// </summary>
		public Croconaw(string nickname, int level)
		: base(
				159,
				SpecieCroconaw.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Croconaw Builder only waiting for a Level
		/// </summary>
		public Croconaw(int level)
		: base(
				159,
				SpecieCroconaw.Instance, // Pokemon Specie
				"Croconaw", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Croconaw Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Croconaw() : base(
			159,
			SpecieCroconaw.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		#endregion
	}
	#endregion
}