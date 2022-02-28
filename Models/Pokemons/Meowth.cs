using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Meowth Specie to store common natural stats of all Meowths
	#region SpecieMeowth
	public class SpecieMeowth : PokemonSpecie
	{
#nullable enable
		private static SpecieMeowth? _instance = null;
#nullable restore
        public static SpecieMeowth Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMeowth();
                }
                return _instance;
            }
        }

		#region SpecieMeowth Builder
		public SpecieMeowth() : base(
			"Meowth",
			40, // HPs
			45, 35, // Attack & Defense
			40, 40, // Special Attack & Defense
			90			
		) {}
		#endregion
	}
	#endregion

	//Meowth Pokemon Class
	#region Meowth
	public class Meowth : Pokemon
	{
		#region Meowth Builders
		/// <summary>
		/// Meowth Builder waiting for a Nickname & a Level
		/// </summary>
		public Meowth(string nickname, int level)
		: base(
				52,
				SpecieMeowth.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meowth Builder only waiting for a Level
		/// </summary>
		public Meowth(int level)
		: base(
				52,
				SpecieMeowth.Instance, // Pokemon Specie
				"Meowth", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meowth Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Meowth() : base(
			52,
			SpecieMeowth.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		#endregion
	}
	#endregion
}