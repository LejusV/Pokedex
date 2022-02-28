using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Clawitzer Specie to store common natural stats of all Clawitzers
	#region SpecieClawitzer
	public class SpecieClawitzer : PokemonSpecie
	{
#nullable enable
		private static SpecieClawitzer? _instance = null;
#nullable restore
        public static SpecieClawitzer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieClawitzer();
                }
                return _instance;
            }
        }

		#region SpecieClawitzer Builder
		public SpecieClawitzer() : base(
			"Clawitzer",
			71, // HPs
			73, 88, // Attack & Defense
			120, 89, // Special Attack & Defense
			59			
		) {}
		#endregion
	}
	#endregion

	//Clawitzer Pokemon Class
	#region Clawitzer
	public class Clawitzer : Pokemon
	{
		#region Clawitzer Builders
		/// <summary>
		/// Clawitzer Builder waiting for a Nickname & a Level
		/// </summary>
		public Clawitzer(string nickname, int level)
		: base(
				693,
				SpecieClawitzer.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clawitzer Builder only waiting for a Level
		/// </summary>
		public Clawitzer(int level)
		: base(
				693,
				SpecieClawitzer.Instance, // Pokemon Specie
				"Clawitzer", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clawitzer Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Clawitzer() : base(
			693,
			SpecieClawitzer.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		#endregion
	}
	#endregion
}