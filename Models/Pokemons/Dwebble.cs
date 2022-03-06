using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Dwebble Specie to store common natural stats of all Dwebbles
	#region SpecieDwebble
	public class SpecieDwebble : PokemonSpecie
	{
#nullable enable
		private static SpecieDwebble? _instance = null;
#nullable restore
        public static SpecieDwebble Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDwebble();
                }
                return _instance;
            }
        }

		#region SpecieDwebble Builder
		public SpecieDwebble() : base(
			"Dwebble",
			0.3,
			14.5,
			50, // HPs
			65, 85, // Attack & Defense
			35, 35, // Special Attack & Defense
			55		
		)
		{}
		#endregion
	}
	#endregion

	//Dwebble Pokemon Class
	#region Dwebble
	public class Dwebble : Pokemon
	{
		#region Dwebble Builders
		/// <summary>
		/// Dwebble Builder waiting for a Nickname & a Level
		/// </summary>
		public Dwebble(string nickname, int level)
		: base(
				557,
				SpecieDwebble.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dwebble Builder only waiting for a Level
		/// </summary>
		public Dwebble(int level)
		: base(
				557,
				SpecieDwebble.Instance, // Pokemon Specie
				"Dwebble", level,
				Bug.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dwebble Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Dwebble() : base(
			557,
			SpecieDwebble.Instance, // Pokemon Specie
			Bug.Instance, Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}