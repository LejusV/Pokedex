using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pikachu Specie to store common natural stats of all Pikachus
	#region SpeciePikachu
	public class SpeciePikachu : PokemonSpecie
	{
#nullable enable
		private static SpeciePikachu? _instance = null;
#nullable restore
        public static SpeciePikachu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePikachu();
                }
                return _instance;
            }
        }

		#region SpeciePikachu Builder
		public SpeciePikachu() : base(
			"Pikachu",
			35, // HPs
			55, 40, // Attack & Defense
			50, 50, // Special Attack & Defense
			90			
		) {}
		#endregion
	}
	#endregion

	//Pikachu Pokemon Class
	#region Pikachu
	public class Pikachu : Pokemon
	{
		#region Pikachu Builders
		/// <summary>
		/// Pikachu Builder waiting for a Nickname & a Level
		/// </summary>
		public Pikachu(string nickname, int level)
		: base(
				25,
				SpeciePikachu.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pikachu Builder only waiting for a Level
		/// </summary>
		public Pikachu(int level)
		: base(
				25,
				SpeciePikachu.Instance, // Pokemon Specie
				"Pikachu", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pikachu Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Pikachu() : base(
			25,
			SpeciePikachu.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		#endregion
	}
	#endregion
}