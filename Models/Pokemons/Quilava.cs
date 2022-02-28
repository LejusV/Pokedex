using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Quilava Specie to store common natural stats of all Quilavas
	#region SpecieQuilava
	public class SpecieQuilava : PokemonSpecie
	{
#nullable enable
		private static SpecieQuilava? _instance = null;
#nullable restore
        public static SpecieQuilava Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieQuilava();
                }
                return _instance;
            }
        }

		#region SpecieQuilava Builder
		public SpecieQuilava() : base(
			"Quilava",
			58, // HPs
			64, 58, // Attack & Defense
			80, 65, // Special Attack & Defense
			80			
		) {}
		#endregion
	}
	#endregion

	//Quilava Pokemon Class
	#region Quilava
	public class Quilava : Pokemon
	{
		#region Quilava Builders
		/// <summary>
		/// Quilava Builder waiting for a Nickname & a Level
		/// </summary>
		public Quilava(string nickname, int level)
		: base(
				156,
				SpecieQuilava.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Quilava Builder only waiting for a Level
		/// </summary>
		public Quilava(int level)
		: base(
				156,
				SpecieQuilava.Instance, // Pokemon Specie
				"Quilava", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Quilava Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Quilava() : base(
			156,
			SpecieQuilava.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		#endregion
	}
	#endregion
}