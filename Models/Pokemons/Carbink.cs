using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Carbink Specie to store common natural stats of all Carbinks
	#region SpecieCarbink
	public class SpecieCarbink : PokemonSpecie
	{
#nullable enable
		private static SpecieCarbink? _instance = null;
#nullable restore
        public static SpecieCarbink Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCarbink();
                }
                return _instance;
            }
        }

		#region SpecieCarbink Builder
		public SpecieCarbink() : base(
			"Carbink",
			50, // HPs
			50, 150, // Attack & Defense
			50, 150, // Special Attack & Defense
			50			
		) {}
		#endregion
	}
	#endregion

	//Carbink Pokemon Class
	#region Carbink
	public class Carbink : Pokemon
	{
		#region Carbink Builders
		/// <summary>
		/// Carbink Builder waiting for a Nickname & a Level
		/// </summary>
		public Carbink(string nickname, int level)
		: base(
				703,
				SpecieCarbink.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carbink Builder only waiting for a Level
		/// </summary>
		public Carbink(int level)
		: base(
				703,
				SpecieCarbink.Instance, // Pokemon Specie
				"Carbink", level,
				Rock.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carbink Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Carbink() : base(
			703,
			SpecieCarbink.Instance, // Pokemon Specie
			Rock.Instance, Fairy.Instance			
		) {}
		#endregion
	}
	#endregion
}