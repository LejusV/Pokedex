using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Stunfisk Specie to store common natural stats of all Stunfisks
	#region SpecieStunfisk
	public class SpecieStunfisk : PokemonSpecie
	{
#nullable enable
		private static SpecieStunfisk? _instance = null;
#nullable restore
        public static SpecieStunfisk Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieStunfisk();
                }
                return _instance;
            }
        }

		#region SpecieStunfisk Builder
		public SpecieStunfisk() : base(
			"Stunfisk",
			109, // HPs
			66, 84, // Attack & Defense
			81, 99, // Special Attack & Defense
			32		
		)
		{
			this._height = 7;
			this._weight = 110;
		}
		#endregion
	}
	#endregion

	//Stunfisk Pokemon Class
	#region Stunfisk
	public class Stunfisk : Pokemon
	{
		#region Stunfisk Builders
		/// <summary>
		/// Stunfisk Builder waiting for a Nickname & a Level
		/// </summary>
		public Stunfisk(string nickname, int level)
		: base(
				618,
				SpecieStunfisk.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stunfisk Builder only waiting for a Level
		/// </summary>
		public Stunfisk(int level)
		: base(
				618,
				SpecieStunfisk.Instance, // Pokemon Specie
				"Stunfisk", level,
				Ground.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stunfisk Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Stunfisk() : base(
			618,
			SpecieStunfisk.Instance, // Pokemon Specie
			Ground.Instance, Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}