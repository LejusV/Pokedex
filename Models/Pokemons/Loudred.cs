using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Loudred Specie to store common natural stats of all Loudreds
	#region SpecieLoudred
	public class SpecieLoudred : PokemonSpecie
	{
#nullable enable
		private static SpecieLoudred? _instance = null;
#nullable restore
        public static SpecieLoudred Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLoudred();
                }
                return _instance;
            }
        }

		#region SpecieLoudred Builder
		public SpecieLoudred() : base(
			"Loudred",
			84, // HPs
			71, 43, // Attack & Defense
			71, 43, // Special Attack & Defense
			48			
		) {}
		#endregion
	}
	#endregion

	//Loudred Pokemon Class
	#region Loudred
	public class Loudred : Pokemon
	{
		#region Loudred Builders
		/// <summary>
		/// Loudred Builder waiting for a Nickname & a Level
		/// </summary>
		public Loudred(string nickname, int level)
		: base(
				294,
				SpecieLoudred.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Loudred Builder only waiting for a Level
		/// </summary>
		public Loudred(int level)
		: base(
				294,
				SpecieLoudred.Instance, // Pokemon Specie
				"Loudred", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Loudred Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Loudred() : base(
			294,
			SpecieLoudred.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		#endregion
	}
	#endregion
}