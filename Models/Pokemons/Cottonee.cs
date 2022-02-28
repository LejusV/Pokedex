using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cottonee Specie to store common natural stats of all Cottonees
	#region SpecieCottonee
	public class SpecieCottonee : PokemonSpecie
	{
#nullable enable
		private static SpecieCottonee? _instance = null;
#nullable restore
        public static SpecieCottonee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCottonee();
                }
                return _instance;
            }
        }

		#region SpecieCottonee Builder
		public SpecieCottonee() : base(
			"Cottonee",
			40, // HPs
			27, 60, // Attack & Defense
			37, 50, // Special Attack & Defense
			66			
		) {}
		#endregion
	}
	#endregion

	//Cottonee Pokemon Class
	#region Cottonee
	public class Cottonee : Pokemon
	{
		#region Cottonee Builders
		/// <summary>
		/// Cottonee Builder waiting for a Nickname & a Level
		/// </summary>
		public Cottonee(string nickname, int level)
		: base(
				546,
				SpecieCottonee.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cottonee Builder only waiting for a Level
		/// </summary>
		public Cottonee(int level)
		: base(
				546,
				SpecieCottonee.Instance, // Pokemon Specie
				"Cottonee", level,
				Grass.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cottonee Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Cottonee() : base(
			546,
			SpecieCottonee.Instance, // Pokemon Specie
			Grass.Instance, Fairy.Instance			
		) {}
		#endregion
	}
	#endregion
}