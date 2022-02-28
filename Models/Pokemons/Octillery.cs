using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Octillery Specie to store common natural stats of all Octillerys
	#region SpecieOctillery
	public class SpecieOctillery : PokemonSpecie
	{
#nullable enable
		private static SpecieOctillery? _instance = null;
#nullable restore
        public static SpecieOctillery Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieOctillery();
                }
                return _instance;
            }
        }

		#region SpecieOctillery Builder
		public SpecieOctillery() : base(
			"Octillery",
			75, // HPs
			105, 75, // Attack & Defense
			105, 75, // Special Attack & Defense
			45			
		) {}
		#endregion
	}
	#endregion

	//Octillery Pokemon Class
	#region Octillery
	public class Octillery : Pokemon
	{
		#region Octillery Builders
		/// <summary>
		/// Octillery Builder waiting for a Nickname & a Level
		/// </summary>
		public Octillery(string nickname, int level)
		: base(
				224,
				SpecieOctillery.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Octillery Builder only waiting for a Level
		/// </summary>
		public Octillery(int level)
		: base(
				224,
				SpecieOctillery.Instance, // Pokemon Specie
				"Octillery", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Octillery Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Octillery() : base(
			224,
			SpecieOctillery.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		#endregion
	}
	#endregion
}