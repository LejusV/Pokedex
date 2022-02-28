using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cinccino Specie to store common natural stats of all Cinccinos
	#region SpecieCinccino
	public class SpecieCinccino : PokemonSpecie
	{
#nullable enable
		private static SpecieCinccino? _instance = null;
#nullable restore
        public static SpecieCinccino Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCinccino();
                }
                return _instance;
            }
        }

		#region SpecieCinccino Builder
		public SpecieCinccino() : base(
			"Cinccino",
			75, // HPs
			95, 60, // Attack & Defense
			65, 60, // Special Attack & Defense
			115			
		) {}
		#endregion
	}
	#endregion

	//Cinccino Pokemon Class
	#region Cinccino
	public class Cinccino : Pokemon
	{
		#region Cinccino Builders
		/// <summary>
		/// Cinccino Builder waiting for a Nickname & a Level
		/// </summary>
		public Cinccino(string nickname, int level)
		: base(
				573,
				SpecieCinccino.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cinccino Builder only waiting for a Level
		/// </summary>
		public Cinccino(int level)
		: base(
				573,
				SpecieCinccino.Instance, // Pokemon Specie
				"Cinccino", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cinccino Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Cinccino() : base(
			573,
			SpecieCinccino.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		#endregion
	}
	#endregion
}