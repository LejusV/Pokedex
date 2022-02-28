using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Steenee Specie to store common natural stats of all Steenees
	#region SpecieSteenee
	public class SpecieSteenee : PokemonSpecie
	{
#nullable enable
		private static SpecieSteenee? _instance = null;
#nullable restore
        public static SpecieSteenee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSteenee();
                }
                return _instance;
            }
        }

		#region SpecieSteenee Builder
		public SpecieSteenee() : base(
			"Steenee",
			52, // HPs
			40, 48, // Attack & Defense
			40, 48, // Special Attack & Defense
			62			
		) {}
		#endregion
	}
	#endregion

	//Steenee Pokemon Class
	#region Steenee
	public class Steenee : Pokemon
	{
		#region Steenee Builders
		/// <summary>
		/// Steenee Builder waiting for a Nickname & a Level
		/// </summary>
		public Steenee(string nickname, int level)
		: base(
				762,
				SpecieSteenee.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Steenee Builder only waiting for a Level
		/// </summary>
		public Steenee(int level)
		: base(
				762,
				SpecieSteenee.Instance, // Pokemon Specie
				"Steenee", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Steenee Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Steenee() : base(
			762,
			SpecieSteenee.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		#endregion
	}
	#endregion
}