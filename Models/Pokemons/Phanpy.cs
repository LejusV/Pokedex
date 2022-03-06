using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Phanpy Specie to store common natural stats of all Phanpys
	#region SpeciePhanpy
	public class SpeciePhanpy : PokemonSpecie
	{
#nullable enable
		private static SpeciePhanpy? _instance = null;
#nullable restore
        public static SpeciePhanpy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePhanpy();
                }
                return _instance;
            }
        }

		#region SpeciePhanpy Builder
		public SpeciePhanpy() : base(
			"Phanpy",
			0.5,
			33.5,
			90, // HPs
			60, 60, // Attack & Defense
			40, 40, // Special Attack & Defense
			40		
		)
		{}
		#endregion
	}
	#endregion

	//Phanpy Pokemon Class
	#region Phanpy
	public class Phanpy : Pokemon
	{
		#region Phanpy Builders
		/// <summary>
		/// Phanpy Builder waiting for a Nickname & a Level
		/// </summary>
		public Phanpy(string nickname, int level)
		: base(
				231,
				SpeciePhanpy.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Phanpy Builder only waiting for a Level
		/// </summary>
		public Phanpy(int level)
		: base(
				231,
				SpeciePhanpy.Instance, // Pokemon Specie
				"Phanpy", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Phanpy Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Phanpy() : base(
			231,
			SpeciePhanpy.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}