using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Raichu Specie to store common natural stats of all Raichus
	#region SpecieRaichu
	public class SpecieRaichu : PokemonSpecie
	{
#nullable enable
		private static SpecieRaichu? _instance = null;
#nullable restore
        public static SpecieRaichu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRaichu();
                }
                return _instance;
            }
        }

		#region SpecieRaichu Builder
		public SpecieRaichu() : base(
			"Raichu",
			60, // HPs
			90, 55, // Attack & Defense
			90, 80, // Special Attack & Defense
			110			
		) {}
		#endregion
	}
	#endregion

	//Raichu Pokemon Class
	#region Raichu
	public class Raichu : Pokemon
	{
		#region Raichu Builders
		/// <summary>
		/// Raichu Builder waiting for a Nickname & a Level
		/// </summary>
		public Raichu(string nickname, int level)
		: base(
				26,
				SpecieRaichu.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Raichu Builder only waiting for a Level
		/// </summary>
		public Raichu(int level)
		: base(
				26,
				SpecieRaichu.Instance, // Pokemon Specie
				"Raichu", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Raichu Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Raichu() : base(
			26,
			SpecieRaichu.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		#endregion
	}
	#endregion
}