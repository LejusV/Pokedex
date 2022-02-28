using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dhelmise Specie to store common natural stats of all Dhelmises
	#region SpecieDhelmise
	public class SpecieDhelmise : PokemonSpecie
	{
#nullable enable
		private static SpecieDhelmise? _instance = null;
#nullable restore
        public static SpecieDhelmise Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDhelmise();
                }
                return _instance;
            }
        }

		#region SpecieDhelmise Builder
		public SpecieDhelmise() : base(
			"Dhelmise",
			70, // HPs
			131, 100, // Attack & Defense
			86, 90, // Special Attack & Defense
			40			
		) {}
		#endregion
	}
	#endregion

	//Dhelmise Pokemon Class
	#region Dhelmise
	public class Dhelmise : Pokemon
	{
		#region Dhelmise Builders
		/// <summary>
		/// Dhelmise Builder waiting for a Nickname & a Level
		/// </summary>
		public Dhelmise(string nickname, int level)
		: base(
				781,
				SpecieDhelmise.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dhelmise Builder only waiting for a Level
		/// </summary>
		public Dhelmise(int level)
		: base(
				781,
				SpecieDhelmise.Instance, // Pokemon Specie
				"Dhelmise", level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dhelmise Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Dhelmise() : base(
			781,
			SpecieDhelmise.Instance, // Pokemon Specie
			Ghost.Instance, Grass.Instance			
		) {}
		#endregion
	}
	#endregion
}