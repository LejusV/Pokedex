using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Pichu Specie to store common natural stats of all Pichus
	#region SpeciePichu
	public class SpeciePichu : PokemonSpecie
	{
#nullable enable
		private static SpeciePichu? _instance = null;
#nullable restore
        public static SpeciePichu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePichu();
                }
                return _instance;
            }
        }

		#region SpeciePichu Builder
		public SpeciePichu() : base(
			"Pichu",
			0.3,
			2.0,
			20, // HPs
			40, 15, // Attack & Defense
			35, 35, // Special Attack & Defense
			60		
		)
		{}
		#endregion
	}
	#endregion

	//Pichu Pokemon Class
	#region Pichu
	public class Pichu : Pokemon
	{
		#region Pichu Builders
		/// <summary>
		/// Pichu Builder waiting for a Nickname & a Level
		/// </summary>
		public Pichu(string nickname, int level)
		: base(
				172,
				SpeciePichu.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pichu Builder only waiting for a Level
		/// </summary>
		public Pichu(int level)
		: base(
				172,
				SpeciePichu.Instance, // Pokemon Specie
				"Pichu", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pichu Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Pichu() : base(
			172,
			SpeciePichu.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}